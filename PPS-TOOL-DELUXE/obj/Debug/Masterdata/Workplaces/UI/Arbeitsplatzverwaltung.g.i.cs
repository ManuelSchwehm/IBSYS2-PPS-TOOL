﻿#pragma checksum "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C4483C8E4B9F0638F93353566887550"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;
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


namespace PPS_TOOL_DELUXE.Masterdata.Workplaces.UI {
    
    
    /// <summary>
    /// Arbeitsplatzverwaltung
    /// </summary>
    public partial class Arbeitsplatzverwaltung : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Arbeitsplatzverwaltung_zurück;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Arbeitsplatzverwaltung_bearbeiten;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid workspacesGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/masterdata/workplaces/ui/arbeitsplatzverwaltung.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
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
            this.btn_Arbeitsplatzverwaltung_zurück = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
            this.btn_Arbeitsplatzverwaltung_zurück.Click += new System.Windows.RoutedEventHandler(this.btn_Arbeitsplatzverwaltung_zurück_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Arbeitsplatzverwaltung_bearbeiten = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
            this.btn_Arbeitsplatzverwaltung_bearbeiten.Click += new System.Windows.RoutedEventHandler(this.btn_Arbeitsplatzverwaltung_bearbeiten_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.workspacesGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
            this.workspacesGrid.Initialized += new System.EventHandler(this.DataGrid_Initialized);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\..\..\Masterdata\Workplaces\UI\Arbeitsplatzverwaltung.xaml"
            this.workspacesGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.workspacesGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

