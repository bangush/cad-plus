﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xarial.CadPlus.CustomToolbar.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("toolbars.setts")]
        public string ToolbarsSpecFile {
            get {
                return ((string)(this["ToolbarsSpecFile"]));
            }
            set {
                this["ToolbarsSpecFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Xarial\\CADPlusToolset")]
        public string AppRootDir {
            get {
                return ((string)(this["AppRootDir"]));
            }
            set {
                this["AppRootDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xtoolbar.json")]
        public string XToolbarSettingsFile {
            get {
                return ((string)(this["XToolbarSettingsFile"]));
            }
            set {
                this["XToolbarSettingsFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"using Xarial.CadPlus.CustomToolbar.Base;
using Xarial.XCad;

namespace Xarial.CadPlus.CustomToolbar.Services.ToggleButton
{{
    public class {0}: IToggleButtonStateResolver
    {{
        public IXApplication Application {{ get; }}

        public {0}(IXApplication app)
        {{
            Application = app;
        }}

        public bool Resolve()
        {{
            {1}
        }}
    }}
}}")]
        public string ToggleButtonResolverCSharp {
            get {
                return ((string)(this["ToggleButtonResolverCSharp"]));
            }
            set {
                this["ToggleButtonResolverCSharp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Imports Xarial.CadPlus.CustomToolbar.Base
Imports Xarial.XCad

Namespace Xarial.CadPlus.CustomToolbar.Services.ToggleButton

    Public Class {0}
        Implements IToggleButtonStateResolver

        Public ReadOnly Property Application As IXApplication Implements IToggleButtonStateResolver.Application

        Public Sub New(ByVal app As IXApplication)
            Application = app
        End Sub

        Public Function Resolve() As Boolean Implements IToggleButtonStateResolver.Resolve
            {1}
        End Function
    End Class
End Namespace")]
        public string ToggleButtonResolverVBNET {
            get {
                return ((string)(this["ToggleButtonResolverVBNET"]));
            }
            set {
                this["ToggleButtonResolverVBNET"] = value;
            }
        }
    }
}
