﻿#pragma checksum "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98881088EDC393CC76E20B06F46852078A63979A"
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
    /// Update_Cc
    /// </summary>
    public partial class Update_Cc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxIdClientCc;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNumeroCc;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSoldeCc;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxDecouvert;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnModifier;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_CompteBancaire2;component/windows%20views/each_window_menu_cc/update_cc.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
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
            this.tbxNumeroCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxSoldeCc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxDecouvert = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnModifier = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\Windows Views\Each_Window_Menu_Cc\Update_Cc.xaml"
            this.BtnModifier.Click += new System.Windows.RoutedEventHandler(this.BtnModifier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

