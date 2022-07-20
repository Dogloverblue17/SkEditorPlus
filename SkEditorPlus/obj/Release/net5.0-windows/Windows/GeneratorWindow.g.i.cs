﻿#pragma checksum "..\..\..\..\Windows\GeneratorWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78C0151565AF7E4C5B2D1EB8DF865938874CB2E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using SkEditorPlus;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SkEditorPlus.Windows {
    
    
    /// <summary>
    /// GeneratorWindow
    /// </summary>
    public partial class GeneratorWindow : HandyControl.Controls.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SkEditorPlus.Windows.GeneratorWindow generatorWindow;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox nameTextbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox permTextbox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox permMessTextbox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox aliasesTextbox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox usageTextbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\GeneratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox executableByTextbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SkEditorPlus;V1.0.0.0;component/windows/generatorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\GeneratorWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.generatorWindow = ((SkEditorPlus.Windows.GeneratorWindow)(target));
            
            #line 9 "..\..\..\..\Windows\GeneratorWindow.xaml"
            this.generatorWindow.KeyUp += new System.Windows.Input.KeyEventHandler(this.OnKey);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 3:
            this.permTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 4:
            this.permMessTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 5:
            this.aliasesTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 6:
            this.usageTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 7:
            this.executableByTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 17 "..\..\..\..\Windows\GeneratorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Generate);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

