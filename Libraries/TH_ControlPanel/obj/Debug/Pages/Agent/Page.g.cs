﻿#pragma checksum "..\..\..\..\Pages\Agent\Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "30D32324558A1BC7DACA287A1736B7F7"
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
using TH_DeviceManager.Controls;
using TH_WPF;
using TH_WPF.LoadingAnimation;


namespace TH_DeviceManager.Pages.Agent {
    
    
    /// <summary>
    /// Page
    /// </summary>
    public partial class Page : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 197 "..\..\..\..\Pages\Agent\Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox currentHeartbeat_TXT;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\..\..\Pages\Agent\Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sampleHeartbeat_TXT;
        
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
            System.Uri resourceLocater = new System.Uri("/TH_DeviceManager;component/pages/agent/page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Agent\Page.xaml"
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
            
            #line 49 "..\..\..\..\Pages\Agent\Page.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 56 "..\..\..\..\Pages\Agent\Page.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 65 "..\..\..\..\Pages\Agent\Page.xaml"
            ((TH_WPF.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 92 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Help_MouseDown);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Help_MouseEnter);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Help_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 161 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Controls.Slider)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.CurrentSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.currentHeartbeat_TXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 197 "..\..\..\..\Pages\Agent\Page.xaml"
            this.currentHeartbeat_TXT.LostFocus += new System.Windows.RoutedEventHandler(this.currentHeartbeat_TXT_LostFocus);
            
            #line default
            #line hidden
            
            #line 197 "..\..\..\..\Pages\Agent\Page.xaml"
            this.currentHeartbeat_TXT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.currentHeartbeat_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 227 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Help_MouseDown);
            
            #line default
            #line hidden
            
            #line 227 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Help_MouseEnter);
            
            #line default
            #line hidden
            
            #line 227 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Help_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 299 "..\..\..\..\Pages\Agent\Page.xaml"
            ((System.Windows.Controls.Slider)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SampleSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.sampleHeartbeat_TXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 335 "..\..\..\..\Pages\Agent\Page.xaml"
            this.sampleHeartbeat_TXT.LostFocus += new System.Windows.RoutedEventHandler(this.sampleHeartbeat_TXT_LostFocus);
            
            #line default
            #line hidden
            
            #line 335 "..\..\..\..\Pages\Agent\Page.xaml"
            this.sampleHeartbeat_TXT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.sampleHeartbeat_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 355 "..\..\..\..\Pages\Agent\Page.xaml"
            ((TH_WPF.Button_01)(target)).Clicked += new TH_WPF.Button_01.Clicked_Handler(this.TestConnection_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

