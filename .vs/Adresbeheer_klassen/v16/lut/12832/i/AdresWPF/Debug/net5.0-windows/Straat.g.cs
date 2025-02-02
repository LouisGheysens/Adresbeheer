﻿#pragma checksum "Straat.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B8B198806AA70BA556E8C1FA25916E2140D9E659"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdresWPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AdresWPF {
    
    
    /// <summary>
    /// Straat
    /// </summary>
    public partial class Straat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StratenSelecteren;
        
        #line default
        #line hidden
        
        
        #line 25 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StratenBestaan;
        
        #line default
        #line hidden
        
        
        #line 26 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stratenverwijderen;
        
        #line default
        #line hidden
        
        
        #line 27 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StratenToevoegen;
        
        #line default
        #line hidden
        
        
        #line 28 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GaNaarHome;
        
        #line default
        #line hidden
        
        
        #line 29 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StratenUpdaten;
        
        #line default
        #line hidden
        
        
        #line 30 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelID;
        
        #line default
        #line hidden
        
        
        #line 31 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelStraatnaam;
        
        #line default
        #line hidden
        
        
        #line 32 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNISCODE;
        
        #line default
        #line hidden
        
        
        #line 33 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxStraatWindowID;
        
        #line default
        #line hidden
        
        
        #line 34 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxStraatWindowNISCODE;
        
        #line default
        #line hidden
        
        
        #line 35 "Straat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxStraatnaam;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AdresWPF;component/straat.xaml", System.UriKind.Relative);
            
            #line 1 "Straat.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.StratenSelecteren = ((System.Windows.Controls.Button)(target));
            
            #line 24 "Straat.xaml"
            this.StratenSelecteren.Click += new System.Windows.RoutedEventHandler(this.SelecteerStraat_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StratenBestaan = ((System.Windows.Controls.Button)(target));
            
            #line 25 "Straat.xaml"
            this.StratenBestaan.Click += new System.Windows.RoutedEventHandler(this.BestaatStraat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Stratenverwijderen = ((System.Windows.Controls.Button)(target));
            
            #line 26 "Straat.xaml"
            this.Stratenverwijderen.Click += new System.Windows.RoutedEventHandler(this.VerwijderStraat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StratenToevoegen = ((System.Windows.Controls.Button)(target));
            
            #line 27 "Straat.xaml"
            this.StratenToevoegen.Click += new System.Windows.RoutedEventHandler(this.VoegStraatToe_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GaNaarHome = ((System.Windows.Controls.Button)(target));
            
            #line 28 "Straat.xaml"
            this.GaNaarHome.Click += new System.Windows.RoutedEventHandler(this.KeerTerugNaarMain_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StratenUpdaten = ((System.Windows.Controls.Button)(target));
            
            #line 29 "Straat.xaml"
            this.StratenUpdaten.Click += new System.Windows.RoutedEventHandler(this.UpdateStraat_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.labelID = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.labelStraatnaam = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labelNISCODE = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.textBoxStraatWindowID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textBoxStraatWindowNISCODE = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.textBoxStraatnaam = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

