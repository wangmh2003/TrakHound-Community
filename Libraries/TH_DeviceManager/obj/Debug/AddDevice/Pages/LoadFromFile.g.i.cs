﻿#pragma checksum "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD0CE5D1CBED05820439547426309B85"
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
using TH_DeviceManager.AddDevice.Pages;
using TH_WPF;


namespace TH_DeviceManager.AddDevice.Pages {
    
    
    /// <summary>
    /// LoadFromFile
    /// </summary>
    public partial class LoadFromFile : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/TH_DeviceManager;component/adddevice/pages/loadfromfile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml"
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
            
            #line 85 "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml"
            ((TH_WPF.Button)(target)).Clicked += new TH_WPF.Button.Clicked_Handler(this.DeviceManager_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 94 "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).DragEnter += new System.Windows.DragEventHandler(this.Rectangle_DragEnter);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).Drop += new System.Windows.DragEventHandler(this.Rectangle_Drop);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 105 "..\..\..\..\AddDevice\Pages\LoadFromFile.xaml"
            ((TH_WPF.Button)(target)).Clicked += new TH_WPF.Button.Clicked_Handler(this.Browse_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

