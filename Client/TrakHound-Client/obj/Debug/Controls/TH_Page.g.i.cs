﻿#pragma checksum "..\..\..\Controls\TH_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB7A71ED18D84AF2639882F63DCBB824"
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


namespace TrakHound_Client.Controls {
    
    
    /// <summary>
    /// TH_Page
    /// </summary>
    public partial class TH_Page : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 114 "..\..\..\Controls\TH_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox zoom_COMBO;
        
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
            System.Uri resourceLocater = new System.Uri("/TrakHound-Client;component/controls/th_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\TH_Page.xaml"
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
            
            #line 108 "..\..\..\Controls\TH_Page.xaml"
            ((TH_WPF.Button_02)(target)).Clicked += new TH_WPF.Button_02.Clicked_Handler(this.ZoomOut_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 111 "..\..\..\Controls\TH_Page.xaml"
            ((TH_WPF.Button_02)(target)).Clicked += new TH_WPF.Button_02.Clicked_Handler(this.ZoomIn_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.zoom_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 114 "..\..\..\Controls\TH_Page.xaml"
            this.zoom_COMBO.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.zoom_COMBO_TextChanged));
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 119 "..\..\..\Controls\TH_Page.xaml"
            ((TH_WPF.Button_02)(target)).Clicked += new TH_WPF.Button_02.Clicked_Handler(this.Fullscreen_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

