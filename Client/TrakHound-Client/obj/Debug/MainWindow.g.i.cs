﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6AF0DE38B811DA5BC40F13772B53F405"
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
using TH_UserManagement;
using TH_WPF;
using TH_WPF.LoadingAnimation;
using TrakHound_Client;
using TrakHound_Client.Controls;
using TrakHound_Client.Developer_Console;
using TrakHound_Client.Main_Menu;
using TrakHound_Client.Message_Center;
using TrakHound_Client.Notifications;
using TrakHound_Client.Plugins.Launcher;


namespace TrakHound_Client {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TrakHound_Client.MainWindow Main_Window;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Root_GRID;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main_GRID;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TitleBar;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Close_BD;
        
        #line default
        #line hidden
        
        
        #line 332 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Maximize_BD;
        
        #line default
        #line hidden
        
        
        #line 460 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Minimize_BD;
        
        #line default
        #line hidden
        
        
        #line 516 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Login_GRID;
        
        #line default
        #line hidden
        
        
        #line 709 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Icon_IMG;
        
        #line default
        #line hidden
        
        
        #line 722 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel Root_DOCK;
        
        #line default
        #line hidden
        
        
        #line 864 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StatusBar_GRID;
        
        #line default
        #line hidden
        
        
        #line 953 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Corner_BottomRight_RECT;
        
        #line default
        #line hidden
        
        
        #line 967 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Pages_TABCONTROL;
        
        #line default
        #line hidden
        
        
        #line 976 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TrakHound_Client.Developer_Console.PopUp developerConsole;
        
        #line default
        #line hidden
        
        
        #line 998 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.Button_01 PluginLauncher_BT;
        
        #line default
        #line hidden
        
        
        #line 1010 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.Button_01 MainMenu_BT;
        
        #line default
        #line hidden
        
        
        #line 1027 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TrakHound_Client.Plugins.Launcher.Menu PluginLauncher;
        
        #line default
        #line hidden
        
        
        #line 1032 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TrakHound_Client.Main_Menu.DropDown MainMenu;
        
        #line default
        #line hidden
        
        
        #line 1037 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_UserManagement.Menu LoginMenu;
        
        #line default
        #line hidden
        
        
        #line 1045 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TrakHound_Client.Message_Center.MessageCenter messageCenter;
        
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
            System.Uri resourceLocater = new System.Uri("/TrakHound-Client;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Main_Window = ((TrakHound_Client.MainWindow)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.Main_Window.Loaded += new System.Windows.RoutedEventHandler(this.Main_Window_Loaded);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.Main_Window.Closing += new System.ComponentModel.CancelEventHandler(this.Main_Window_Closing);
            
            #line default
            #line hidden
            
            #line 44 "..\..\MainWindow.xaml"
            this.Main_Window.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Main_Window_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MainWindow.xaml"
            this.Main_Window.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.Main_Window_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Root_GRID = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Main_GRID = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            
            #line 210 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_TopLeft_MouseEnter);
            
            #line default
            #line hidden
            
            #line 210 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 210 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 210 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 210 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 211 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_TopRight_MouseEnter);
            
            #line default
            #line hidden
            
            #line 211 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 211 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 211 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 211 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_TopMiddle_MouseEnter);
            
            #line default
            #line hidden
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 217 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_BottomLeft_MouseEnter);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 218 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_BottomRight_MouseEnter);
            
            #line default
            #line hidden
            
            #line 218 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 218 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 218 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 218 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 219 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_BottomMiddle_MouseEnter);
            
            #line default
            #line hidden
            
            #line 219 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 219 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 219 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 219 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_WE_MouseEnter);
            
            #line default
            #line hidden
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_WE_MouseEnter);
            
            #line default
            #line hidden
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 228 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.TitleBar = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 14:
            this.Close_BD = ((System.Windows.Controls.Border)(target));
            
            #line 232 "..\..\MainWindow.xaml"
            this.Close_BD.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_BD_MouseDown);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Maximize_BD = ((System.Windows.Controls.Border)(target));
            
            #line 332 "..\..\MainWindow.xaml"
            this.Maximize_BD.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Maximize_BD_MouseDown);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Minimize_BD = ((System.Windows.Controls.Border)(target));
            
            #line 460 "..\..\MainWindow.xaml"
            this.Minimize_BD.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize_BD_MouseDown);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Login_GRID = ((System.Windows.Controls.Grid)(target));
            
            #line 516 "..\..\MainWindow.xaml"
            this.Login_GRID.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Login_GRID_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Icon_IMG = ((System.Windows.Controls.Image)(target));
            return;
            case 19:
            this.Root_DOCK = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 20:
            this.StatusBar_GRID = ((System.Windows.Controls.Grid)(target));
            return;
            case 21:
            this.Corner_BottomRight_RECT = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 953 "..\..\MainWindow.xaml"
            this.Corner_BottomRight_RECT.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_BottomRight_MouseEnter);
            
            #line default
            #line hidden
            
            #line 953 "..\..\MainWindow.xaml"
            this.Corner_BottomRight_RECT.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Resize_MouseLeave);
            
            #line default
            #line hidden
            
            #line 953 "..\..\MainWindow.xaml"
            this.Corner_BottomRight_RECT.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize_Begin);
            
            #line default
            #line hidden
            
            #line 953 "..\..\MainWindow.xaml"
            this.Corner_BottomRight_RECT.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Resize_End);
            
            #line default
            #line hidden
            
            #line 953 "..\..\MainWindow.xaml"
            this.Corner_BottomRight_RECT.MouseMove += new System.Windows.Input.MouseEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 22:
            this.Pages_TABCONTROL = ((System.Windows.Controls.TabControl)(target));
            
            #line 972 "..\..\MainWindow.xaml"
            this.Pages_TABCONTROL.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Pages_TABCONTROL_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 23:
            this.developerConsole = ((TrakHound_Client.Developer_Console.PopUp)(target));
            return;
            case 24:
            this.PluginLauncher_BT = ((TH_WPF.Button_01)(target));
            
            #line 998 "..\..\MainWindow.xaml"
            this.PluginLauncher_BT.Clicked += new TH_WPF.Button_01.Clicked_Handler(this.PluginLauncher_BT_Clicked);
            
            #line default
            #line hidden
            return;
            case 25:
            this.MainMenu_BT = ((TH_WPF.Button_01)(target));
            
            #line 1010 "..\..\MainWindow.xaml"
            this.MainMenu_BT.Clicked += new TH_WPF.Button_01.Clicked_Handler(this.MainMenu_BT_Clicked);
            
            #line default
            #line hidden
            return;
            case 26:
            this.PluginLauncher = ((TrakHound_Client.Plugins.Launcher.Menu)(target));
            return;
            case 27:
            this.MainMenu = ((TrakHound_Client.Main_Menu.DropDown)(target));
            return;
            case 28:
            this.LoginMenu = ((TH_UserManagement.Menu)(target));
            
            #line 1038 "..\..\MainWindow.xaml"
            this.LoginMenu.CurrentUserChanged += new TH_UserManagement.Menu.CurrentUserChanged_Handler(this.LoginMenu_CurrentUserChanged);
            
            #line default
            #line hidden
            
            #line 1039 "..\..\MainWindow.xaml"
            this.LoginMenu.ShownChanged += new TH_UserManagement.Menu.ShownChanged_Handler(this.LoginMenu_ShownChanged);
            
            #line default
            #line hidden
            
            #line 1040 "..\..\MainWindow.xaml"
            this.LoginMenu.MyAccountClicked += new TH_UserManagement.Menu.Clicked_Handler(this.LoginMenu_MyAccountClicked);
            
            #line default
            #line hidden
            
            #line 1041 "..\..\MainWindow.xaml"
            this.LoginMenu.CreateClicked += new TH_UserManagement.Menu.Clicked_Handler(this.LoginMenu_CreateClicked);
            
            #line default
            #line hidden
            return;
            case 29:
            this.messageCenter = ((TrakHound_Client.Message_Center.MessageCenter)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

