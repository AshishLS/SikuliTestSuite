﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SikuliTestSuit.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\SikuliScripts\\SikuliTestData")]
        public string settingTestDataPath {
            get {
                return ((string)(this["settingTestDataPath"]));
            }
            set {
                this["settingTestDataPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\SikuliScripts")]
        public string settingScriptsFolder {
            get {
                return ((string)(this["settingScriptsFolder"]));
            }
            set {
                this["settingScriptsFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\Softwares\\Sikuli built")]
        public string settingSikuliInstallationPath {
            get {
                return ((string)(this["settingSikuliInstallationPath"]));
            }
            set {
                this["settingSikuliInstallationPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\SikuliScripts\\ImageRepo")]
        public string settingImageRepoPath {
            get {
                return ((string)(this["settingImageRepoPath"]));
            }
            set {
                this["settingImageRepoPath"] = value;
            }
        }
    }
}
