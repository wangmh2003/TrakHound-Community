﻿#pragma checksum "..\..\..\Controls\MyAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DFDDB749FA1975BAAD4188C699F6166"
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
using TH_WPF;
using TH_WPF.LoadingAnimation;


namespace TH_UserManagement {
    
    
    /// <summary>
    /// MyAccountPage
    /// </summary>
    public partial class MyAccountPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 210 "..\..\..\Controls\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.PasswordBox password_TXT;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\Controls\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.PasswordBox confirmpassword_TXT;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\..\Controls\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox country_COMBO;
        
        #line default
        #line hidden
        
        
        #line 341 "..\..\..\Controls\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox state_COMBO;
        
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
            System.Uri resourceLocater = new System.Uri("/TH_UserManagement;component/controls/myaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\MyAccount.xaml"
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
            
            #line 10 "..\..\..\Controls\MyAccount.xaml"
            ((TH_UserManagement.MyAccountPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 87 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 90 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 110 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.username_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 164 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.Button)(target)).Clicked += new TH_WPF.Button.Clicked_Handler(this.ChangePassword_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.password_TXT = ((TH_WPF.PasswordBox)(target));
            
            #line 210 "..\..\..\Controls\MyAccount.xaml"
            this.password_TXT.PasswordChanged += new System.Windows.RoutedEventHandler(this.password_TXT_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.confirmpassword_TXT = ((TH_WPF.PasswordBox)(target));
            
            #line 268 "..\..\..\Controls\MyAccount.xaml"
            this.confirmpassword_TXT.PasswordChanged += new System.Windows.RoutedEventHandler(this.confirmpassword_TXT_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 299 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 303 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 307 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 311 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 313 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 317 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.country_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 323 "..\..\..\Controls\MyAccount.xaml"
            this.country_COMBO.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.country_COMBO_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.state_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 341 "..\..\..\Controls\MyAccount.xaml"
            this.state_COMBO.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.state_COMBO_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 347 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 358 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.ImageBox)(target)).UploadClicked += new TH_WPF.ImageBox.Clicked_Handler(this.ProfileImage_UploadClicked);
            
            #line default
            #line hidden
            
            #line 359 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.ImageBox)(target)).ClearClicked += new TH_WPF.ImageBox.Clicked_Handler(this.ProfileImage_ClearClicked);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 403 "..\..\..\Controls\MyAccount.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.PrivacyPolicy_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 414 "..\..\..\Controls\MyAccount.xaml"
            ((TH_WPF.Button)(target)).Clicked += new TH_WPF.Button.Clicked_Handler(this.Apply_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

