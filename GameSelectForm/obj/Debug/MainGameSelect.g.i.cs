﻿#pragma checksum "..\..\MainGameSelect.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "724A3117E3737EC658A4DA37BC27DEBD57BB6D97135FEE8D71C5F653FFA9621B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameSelectForm;
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


namespace GameSelectForm {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainGameSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GameMenuLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainGameSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuildMasterButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainGameSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RobbersButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainGameSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TurtleGameButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainGameSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WelcomeLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/GameSelectForm;component/maingameselect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainGameSelect.xaml"
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
            this.GameMenuLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.GuildMasterButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\MainGameSelect.xaml"
            this.GuildMasterButton.Click += new System.Windows.RoutedEventHandler(this.GameButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RobbersButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MainGameSelect.xaml"
            this.RobbersButton.Click += new System.Windows.RoutedEventHandler(this.GameButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TurtleGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\MainGameSelect.xaml"
            this.TurtleGameButton.Click += new System.Windows.RoutedEventHandler(this.GameButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WelcomeLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

