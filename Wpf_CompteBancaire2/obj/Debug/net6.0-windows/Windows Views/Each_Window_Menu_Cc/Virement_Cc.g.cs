﻿#pragma checksum "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67EC01430B5114C9A704A40FA9105CA3EB035A61"
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
    /// Virement_Cc
    /// </summary>
    public partial class Virement_Cc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxIdClientCc;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxMontantVirementCc;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnValiderVirement;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_CompteBancaire2;component/windows%20views/each_window_menu_cc/virement_cc.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml"
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
            this.tbxIdClientCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxMontantVirementCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnValiderVirement = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Virement_Cc.xaml"
            this.BtnValiderVirement.Click += new System.Windows.RoutedEventHandler(this.BtnValiderVirement_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

