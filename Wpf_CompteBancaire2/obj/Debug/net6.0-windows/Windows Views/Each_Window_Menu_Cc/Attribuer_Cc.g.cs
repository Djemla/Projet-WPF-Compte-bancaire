﻿#pragma checksum "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B7D7BC847E8F4CE26D9B2ECEFC9C3E80A85963BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Cc;


namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Cc {
    
    
    /// <summary>
    /// Attribuer_Cc
    /// </summary>
    public partial class Attribuer_Cc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAttribuer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxIdClientCc;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNumeroCc;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSoldeCc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf_CompteBancaire2;component/windows%20views/each_window_menu_cc/attribuer_cc.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnAttribuer = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Attribuer_Cc.xaml"
            this.BtnAttribuer.Click += new System.Windows.RoutedEventHandler(this.BtnAttribuer_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbxIdClientCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxNumeroCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxSoldeCc = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

