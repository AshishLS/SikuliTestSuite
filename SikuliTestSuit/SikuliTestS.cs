using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SikuliTestSuit
{
    public partial class SikuliTestS : Form
    {
        string resultFileName;
        List<TreeNode> listOfSelectedNodes;

        public SikuliTestS()
        {
            InitializeComponent();
            trViewScripts.CheckBoxes = true;
            trViewScripts.AfterCheck += AfterCheck;
        }

        private void AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in e.Node.Nodes)
            {
                item.Checked = e.Node.Checked; // It will call the same event for each check.
            }
        }

        private void btnSetPrereq_Click(object sender, EventArgs e)
        {
            trViewScripts.Nodes.Clear();
            var parentNode = trViewScripts.Nodes.Add(tBxScriptsFolder.Text);
            CheckAndAddSikuliFoldersInTreeNode(parentNode.Nodes, tBxScriptsFolder.Text);

            // Enable the Run Tests button.
            btnRunTests.Enabled = true;

            // Save the Most Recent Used.
            SaveMRU();
        }

        private void SaveMRU()
        {
            Properties.Settings.Default.settingTestDataPath = tBxTestDataPath.Text;
            Properties.Settings.Default.settingScriptsFolder = tBxScriptsFolder.Text;
            Properties.Settings.Default.settingSikuliInstallationPath = tBxSikuliInstallationPath.Text;
            Properties.Settings.Default.settingImageRepoPath = tbxImageRepoPath.Text;
            Properties.Settings.Default.Save();
        }

        private bool hasAccessPermission(string path)
        {
            try
            {
                var accessControl = Directory.GetAccessControl(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CheckAndAddSikuliFoldersInTreeNode(TreeNodeCollection topNodes, string fullName)
        {
            var directoryInfo = new DirectoryInfo(fullName);

            if (!hasAccessPermission(fullName))
                return;

            // Get all top folders in this directory.
            var listOfDiectories = directoryInfo.EnumerateDirectories();

            foreach (var item in listOfDiectories)
            {
                if (!hasAccessPermission(item.FullName))
                    continue;

                // If any of them has .sikuli extention, directly add them in this tree node.
                if (item.Name.Contains(".sikuli"))
                    topNodes.Add(item.FullName, item.Name);
                else
                {
                    // Otherwise, check if any of its subdirectories has .sikuli folders.
                    // If they don't have .sikuli folders, they are not relevant to us.
                    var releventDirs = item.GetDirectories("*.sikuli", SearchOption.AllDirectories);
                    if (releventDirs.Count() > 0)
                    {
                        // Since the subdirectory has .sikuli folder, add it in the node and
                        // send this directory for further processing recursively.
                        TreeNode parent = topNodes.Add(item.FullName, item.Name);
                        CheckAndAddSikuliFoldersInTreeNode(parent.Nodes, item.FullName);
                    }
                }
            }
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            string runCommand = tBxSikuliInstallationPath.Text + "\\" + "runsikulix.cmd ";
            resultFileName = tBxTestDataPath.Text + "\\" + DateTime.Now.ToFileTimeUtc() + ".txt";

            // Get all tests to be run - 
            listOfSelectedNodes = getSelectedNodes(trViewScripts.Nodes);

            // Run only those tests
            foreach (var item in listOfSelectedNodes)
            {
                string finalCommand = "";
                SetEnvironmentVariables(ref finalCommand);
                // example - "H:\Softwares\Sikuli built\runsikulix.cmd" -r "H:\Sikuli Scripts\Sik_TableSelectCells.sikuli" >> "H:\Sikuli Scripts\SikuliTestData\131274998357987988.txt"
                finalCommand += String.Format("\"{0}\" -r \"{1}\" >> \"{2}\"", runCommand, item.Name, resultFileName);
                //finalCommand += String.Format("\"{0}\" -r \"{1}\"", runCommand, item.Name);

                PrintMessageInLogFile("Running " + item.Name);
                RunOnCmdLine(ref finalCommand);
                PrintMessageInLogFile("++++++++++++++++++++++++++++++++ \n\n ");
            }

            PublishResults();
            MessageBox.Show("Sikuli Tests All Done");
        }

        private void SetEnvironmentVariables(ref string finalCommand)
        {
            string envFilePath = tBxScriptsFolder.Text + "\\SetEnvVariables.py";
            StreamWriter strWriter = File.CreateText(envFilePath);
            if (strWriter != null)
            {
                strWriter.WriteLine("from sikuli import* #http://doc.sikuli.org/globals.html#importingsikuliscripts");
                strWriter.WriteLine("import os");
                //strWriter.WriteLine(String.Format("os.environ[\"{0}\"]=\"{1}\"", "SIKULI_IMAGE_REPO", tbxImageRepoPath.Text));
                strWriter.WriteLine(String.Format("addImagePath('{0}')", tbxImageRepoPath.Text));
                //strWriter.WriteLine("print(\"Validation - Check Env Variable SIKULI_IMAGE_PATH = %s\" % os.environ['SIKULI_IMAGE_REPO'])");
                strWriter.WriteLine("Debug.log(\"Validation - Check if image path is okay = %s\" % getImagePath())");
                finalCommand += String.Format("\"{0}\" \n", envFilePath);
                strWriter.Close();
            }            
        }

        private void PublishResults()
        {
            if (!File.Exists(resultFileName))
                return;

            StreamReader reader = File.OpenText(resultFileName);
            int index = 0;
            bool findResultBegun = false;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!findResultBegun)
                {
                    if (listOfSelectedNodes.Count > index && line.Contains(listOfSelectedNodes[index].Name)) // Name.. not Text
                        findResultBegun = true;
                }
                else
                {
                    if (line.Contains("TEST PASSED!!"))
                    {
                        // Test is passed..
                        listOfSelectedNodes[index++].BackColor = Color.LightGreen;
                        // consume next ++++++ line.
                        reader.ReadLine();
                        findResultBegun = false;
                    }
                    else if (line.Contains("++++++"))
                    {
                        // Test is failed.
                        findResultBegun = false;
                        listOfSelectedNodes[index++].BackColor = Color.Red;
                    }
                }
            }
        }

        private List<TreeNode> getSelectedNodes(TreeNodeCollection parentNodes)
        {
            List<TreeNode> selectedNodes = new List<TreeNode>();
            foreach (TreeNode item in parentNodes)
            {
                if (item.GetNodeCount(false) > 0)
                    selectedNodes.AddRange(getSelectedNodes(item.Nodes));
                else
                {
                    if(item.Checked)
                        selectedNodes.Add(item);
                }
            }
            return selectedNodes;
        }

        private void RunOnCmdLine(ref string mycmd)
        {
            //http://stackoverflow.com/questions/1469764/run-command-prompt-commands Ogglas' answer.
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(mycmd);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        private void PrintMessageInLogFile(string mgs)
        {
            StreamWriter filestream = null;

            if (!File.Exists(resultFileName))
            {
                filestream = File.CreateText(resultFileName);
            }
            else
            {
                filestream = File.AppendText(resultFileName);
            }
            filestream.WriteLine(mgs);
            filestream.Close();
        }
    }
}
