﻿#pragma checksum "..\..\Register.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "405689DD38798B7FC581FE23A84F870761BE3AC08C8B36F3CF9EC3723734DB1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Admin {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label checkName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtDigitalSecurity;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label checkDigitalSecurity;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassWord;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label checkPassordLength;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtCPassWord;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label checkPassword;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button login;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HotelManagementSystem;component/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\Register.xaml"
            this.txtname.LostFocus += new System.Windows.RoutedEventHandler(this.txtname_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtDigitalSecurity = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 36 "..\..\Register.xaml"
            this.txtDigitalSecurity.LostFocus += new System.Windows.RoutedEventHandler(this.txtDigitalSecurity_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.checkDigitalSecurity = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtPassWord = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 40 "..\..\Register.xaml"
            this.txtPassWord.LostFocus += new System.Windows.RoutedEventHandler(this.txtPassWord_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkPassordLength = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtCPassWord = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 44 "..\..\Register.xaml"
            this.txtCPassWord.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtCPassWord_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.login = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Register.xaml"
            this.login.Click += new System.Windows.RoutedEventHandler(this.register_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

