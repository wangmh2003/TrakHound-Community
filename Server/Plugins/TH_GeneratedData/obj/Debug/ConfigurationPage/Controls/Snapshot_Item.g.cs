﻿#pragma checksum "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B9235C5061E55AAC5092E4FA8780DB4"
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


namespace TH_GeneratedData.ConfigurationPage.Controls {
    
    
    /// <summary>
    /// Snapshot_Item
    /// </summary>
    public partial class Snapshot_Item : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_TXT;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox variable_TXT;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox collectedlink_COMBO;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox generatedlink_COMBO;
        
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
            System.Uri resourceLocater = new System.Uri("/TH_GeneratedData;component/configurationpage/controls/snapshot_item.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
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
            this.name_TXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.name_TXT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.name_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 86 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Type_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.variable_TXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 131 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.variable_TXT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.variable_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.collectedlink_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 152 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.collectedlink_COMBO.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.ComboBox_TextChanged));
            
            #line default
            #line hidden
            
            #line 152 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.collectedlink_COMBO.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Link_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.generatedlink_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 169 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.generatedlink_COMBO.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.ComboBox_TextChanged));
            
            #line default
            #line hidden
            
            #line 169 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            this.generatedlink_COMBO.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Link_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 173 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            ((TH_WPF.Button_04)(target)).Clicked += new TH_WPF.Button_04.Clicked_Handler(this.Refresh_Clicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 180 "..\..\..\..\ConfigurationPage\Controls\Snapshot_Item.xaml"
            ((TH_WPF.Button_04)(target)).Clicked += new TH_WPF.Button_04.Clicked_Handler(this.Removed_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

