﻿#pragma checksum "..\..\Palette.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ADA164F3C5EDB56A26AD3474B534541BB1FAF332E14A1C5D681E0423E1EAFAF"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Palette
    /// </summary>
    public partial class Palette : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Palette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sld_RedColor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Palette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sld_GreenColor;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Palette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sld_BlueColor;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Palette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInf1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Palette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_valider;
        
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
            System.Uri resourceLocater = new System.Uri("/DrawITApp;component/palette.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Palette.xaml"
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
            this.sld_RedColor = ((System.Windows.Controls.Slider)(target));
            
            #line 10 "..\..\Palette.xaml"
            this.sld_RedColor.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sld_Color_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sld_GreenColor = ((System.Windows.Controls.Slider)(target));
            
            #line 15 "..\..\Palette.xaml"
            this.sld_GreenColor.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sld_Color_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sld_BlueColor = ((System.Windows.Controls.Slider)(target));
            
            #line 20 "..\..\Palette.xaml"
            this.sld_BlueColor.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sld_Color_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblInf1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.button_valider = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Palette.xaml"
            this.button_valider.Click += new System.Windows.RoutedEventHandler(this.validerCouleur);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

