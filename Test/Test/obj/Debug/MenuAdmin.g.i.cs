﻿#pragma checksum "..\..\MenuAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3F45AD8E879B616908F6BB78FEAD6BB01E800364"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Test;
using WpfAnimatedGif;


namespace Test {
    
    
    /// <summary>
    /// MenuAdmin
    /// </summary>
    public partial class MenuAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label7;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label8;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/menuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuAdmin.xaml"
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
            this.text = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\MenuAdmin.xaml"
            this.text.MouseEnter += new System.Windows.Input.MouseEventHandler(this.text_MouseMove);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MenuAdmin.xaml"
            this.text.MouseLeave += new System.Windows.Input.MouseEventHandler(this.text_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            
            #line 53 "..\..\MenuAdmin.xaml"
            this.label1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label1_MouseMove);
            
            #line default
            #line hidden
            
            #line 54 "..\..\MenuAdmin.xaml"
            this.label1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label1_MouseLeave);
            
            #line default
            #line hidden
            
            #line 55 "..\..\MenuAdmin.xaml"
            this.label1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Label1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label2 = ((System.Windows.Controls.Label)(target));
            
            #line 66 "..\..\MenuAdmin.xaml"
            this.label2.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label2_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 67 "..\..\MenuAdmin.xaml"
            this.label2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label2_MouseMove);
            
            #line default
            #line hidden
            
            #line 68 "..\..\MenuAdmin.xaml"
            this.label2.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label2_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label5 = ((System.Windows.Controls.Label)(target));
            
            #line 79 "..\..\MenuAdmin.xaml"
            this.label5.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label5_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 80 "..\..\MenuAdmin.xaml"
            this.label5.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label5_MouseMove);
            
            #line default
            #line hidden
            
            #line 81 "..\..\MenuAdmin.xaml"
            this.label5.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label5_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label7 = ((System.Windows.Controls.Label)(target));
            
            #line 93 "..\..\MenuAdmin.xaml"
            this.label7.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label7_MouseMove);
            
            #line default
            #line hidden
            
            #line 94 "..\..\MenuAdmin.xaml"
            this.label7.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label7_MouseLeave);
            
            #line default
            #line hidden
            
            #line 95 "..\..\MenuAdmin.xaml"
            this.label7.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label7_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label8 = ((System.Windows.Controls.Label)(target));
            
            #line 104 "..\..\MenuAdmin.xaml"
            this.label8.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label8_MouseMove);
            
            #line default
            #line hidden
            
            #line 105 "..\..\MenuAdmin.xaml"
            this.label8.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label8_MouseLeave);
            
            #line default
            #line hidden
            
            #line 106 "..\..\MenuAdmin.xaml"
            this.label8.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label8_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 116 "..\..\MenuAdmin.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown_one);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 117 "..\..\MenuAdmin.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

