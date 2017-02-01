﻿namespace SikuliTestSuit
{
    partial class SikuliTestS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTestDataPath = new System.Windows.Forms.Label();
            this.lblScriptsFolder = new System.Windows.Forms.Label();
            this.lblSikuliInstallation = new System.Windows.Forms.Label();
            this.gBxPreReq = new System.Windows.Forms.GroupBox();
            this.tbxImageRepoPath = new System.Windows.Forms.TextBox();
            this.lblImageRepoPath = new System.Windows.Forms.Label();
            this.tBxSikuliInstallationPath = new System.Windows.Forms.TextBox();
            this.tBxScriptsFolder = new System.Windows.Forms.TextBox();
            this.tBxTestDataPath = new System.Windows.Forms.TextBox();
            this.trViewScripts = new System.Windows.Forms.TreeView();
            this.btnSetPrereq = new System.Windows.Forms.Button();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.gBxPreReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestDataPath
            // 
            this.lblTestDataPath.AutoSize = true;
            this.lblTestDataPath.Location = new System.Drawing.Point(6, 25);
            this.lblTestDataPath.Name = "lblTestDataPath";
            this.lblTestDataPath.Size = new System.Drawing.Size(79, 13);
            this.lblTestDataPath.TabIndex = 0;
            this.lblTestDataPath.Text = "Test Data Path";
            // 
            // lblScriptsFolder
            // 
            this.lblScriptsFolder.AutoSize = true;
            this.lblScriptsFolder.Location = new System.Drawing.Point(6, 48);
            this.lblScriptsFolder.Name = "lblScriptsFolder";
            this.lblScriptsFolder.Size = new System.Drawing.Size(71, 13);
            this.lblScriptsFolder.TabIndex = 1;
            this.lblScriptsFolder.Text = "Scripts Folder";
            this.lblScriptsFolder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblSikuliInstallation
            // 
            this.lblSikuliInstallation.AutoSize = true;
            this.lblSikuliInstallation.Location = new System.Drawing.Point(6, 71);
            this.lblSikuliInstallation.Name = "lblSikuliInstallation";
            this.lblSikuliInstallation.Size = new System.Drawing.Size(110, 13);
            this.lblSikuliInstallation.TabIndex = 2;
            this.lblSikuliInstallation.Text = "Sikuli Installation Path";
            this.lblSikuliInstallation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // gBxPreReq
            // 
            this.gBxPreReq.Controls.Add(this.tbxImageRepoPath);
            this.gBxPreReq.Controls.Add(this.lblImageRepoPath);
            this.gBxPreReq.Controls.Add(this.tBxSikuliInstallationPath);
            this.gBxPreReq.Controls.Add(this.tBxScriptsFolder);
            this.gBxPreReq.Controls.Add(this.tBxTestDataPath);
            this.gBxPreReq.Controls.Add(this.lblTestDataPath);
            this.gBxPreReq.Controls.Add(this.lblSikuliInstallation);
            this.gBxPreReq.Controls.Add(this.lblScriptsFolder);
            this.gBxPreReq.Location = new System.Drawing.Point(12, 12);
            this.gBxPreReq.Name = "gBxPreReq";
            this.gBxPreReq.Size = new System.Drawing.Size(513, 143);
            this.gBxPreReq.TabIndex = 3;
            this.gBxPreReq.TabStop = false;
            this.gBxPreReq.Text = "Prerequisites";
            // 
            // tbxImageRepoPath
            // 
            this.tbxImageRepoPath.Location = new System.Drawing.Point(120, 94);
            this.tbxImageRepoPath.Name = "tbxImageRepoPath";
            this.tbxImageRepoPath.Size = new System.Drawing.Size(377, 20);
            this.tbxImageRepoPath.TabIndex = 7;
            this.tbxImageRepoPath.Text = "H:\\SikuliScripts\\ImageRepo";
            // 
            // lblImageRepoPath
            // 
            this.lblImageRepoPath.AutoSize = true;
            this.lblImageRepoPath.Location = new System.Drawing.Point(6, 97);
            this.lblImageRepoPath.Name = "lblImageRepoPath";
            this.lblImageRepoPath.Size = new System.Drawing.Size(90, 13);
            this.lblImageRepoPath.TabIndex = 6;
            this.lblImageRepoPath.Text = "Image Repo Path";
            this.lblImageRepoPath.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tBxSikuliInstallationPath
            // 
            this.tBxSikuliInstallationPath.Location = new System.Drawing.Point(120, 68);
            this.tBxSikuliInstallationPath.Name = "tBxSikuliInstallationPath";
            this.tBxSikuliInstallationPath.Size = new System.Drawing.Size(377, 20);
            this.tBxSikuliInstallationPath.TabIndex = 5;
            this.tBxSikuliInstallationPath.Text = "H:\\Softwares\\Sikuli built";
            // 
            // tBxScriptsFolder
            // 
            this.tBxScriptsFolder.Location = new System.Drawing.Point(120, 45);
            this.tBxScriptsFolder.Name = "tBxScriptsFolder";
            this.tBxScriptsFolder.Size = new System.Drawing.Size(377, 20);
            this.tBxScriptsFolder.TabIndex = 4;
            this.tBxScriptsFolder.Text = "H:\\SikuliScripts";
            // 
            // tBxTestDataPath
            // 
            this.tBxTestDataPath.Location = new System.Drawing.Point(120, 22);
            this.tBxTestDataPath.Name = "tBxTestDataPath";
            this.tBxTestDataPath.Size = new System.Drawing.Size(377, 20);
            this.tBxTestDataPath.TabIndex = 3;
            this.tBxTestDataPath.Text = "H:\\SikuliScripts\\SikuliTestData";
            // 
            // trViewScripts
            // 
            this.trViewScripts.Location = new System.Drawing.Point(13, 181);
            this.trViewScripts.Name = "trViewScripts";
            this.trViewScripts.Size = new System.Drawing.Size(512, 365);
            this.trViewScripts.TabIndex = 4;
            // 
            // btnSetPrereq
            // 
            this.btnSetPrereq.Location = new System.Drawing.Point(542, 26);
            this.btnSetPrereq.Name = "btnSetPrereq";
            this.btnSetPrereq.Size = new System.Drawing.Size(75, 23);
            this.btnSetPrereq.TabIndex = 5;
            this.btnSetPrereq.Text = "Set Prereq";
            this.btnSetPrereq.UseVisualStyleBackColor = true;
            this.btnSetPrereq.Click += new System.EventHandler(this.btnSetPrereq_Click);
            // 
            // btnRunTests
            // 
            this.btnRunTests.Enabled = false;
            this.btnRunTests.Location = new System.Drawing.Point(434, 203);
            this.btnRunTests.Name = "btnRunTests";
            this.btnRunTests.Size = new System.Drawing.Size(75, 23);
            this.btnRunTests.TabIndex = 6;
            this.btnRunTests.Text = "Run Tests";
            this.btnRunTests.UseVisualStyleBackColor = true;
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);
            // 
            // SikuliTestS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this.btnRunTests);
            this.Controls.Add(this.btnSetPrereq);
            this.Controls.Add(this.trViewScripts);
            this.Controls.Add(this.gBxPreReq);
            this.Name = "SikuliTestS";
            this.Text = "Sikuli Test Suit";
            this.gBxPreReq.ResumeLayout(false);
            this.gBxPreReq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTestDataPath;
        private System.Windows.Forms.Label lblScriptsFolder;
        private System.Windows.Forms.Label lblSikuliInstallation;
        private System.Windows.Forms.GroupBox gBxPreReq;
        private System.Windows.Forms.TextBox tBxSikuliInstallationPath;
        private System.Windows.Forms.TextBox tBxScriptsFolder;
        private System.Windows.Forms.TextBox tBxTestDataPath;
        private System.Windows.Forms.TreeView trViewScripts;
        private System.Windows.Forms.Button btnSetPrereq;
        private System.Windows.Forms.Button btnRunTests;
        private System.Windows.Forms.TextBox tbxImageRepoPath;
        private System.Windows.Forms.Label lblImageRepoPath;
    }
}

