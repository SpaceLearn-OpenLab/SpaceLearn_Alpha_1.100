﻿#pragma checksum "..\..\..\Page1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B3E79F4F095A19075A18ADC6D3C1C1BC9395C56"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SpaceLearn_demo;
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


namespace SpaceLearn_demo {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas QuizCanvas;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label questionNum;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock questionText;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans3;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans4;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SpaceLearn_demo;V1.0.0.0;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.QuizCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.questionNum = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.questionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ans1 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Page1.xaml"
            this.ans1.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ans2 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Page1.xaml"
            this.ans2.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ans3 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Page1.xaml"
            this.ans3.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ans4 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Page1.xaml"
            this.ans4.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

