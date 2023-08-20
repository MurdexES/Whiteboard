﻿#pragma checksum "..\..\..\..\View\WhiteboardView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "219CE0E97884298674A7091C9406A9D6641A52F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Whiteboard.View;


namespace Whiteboard.View {
    
    
    /// <summary>
    /// WhiteboardView
    /// </summary>
    public partial class WhiteboardView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 376 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ColorBtn;
        
        #line default
        #line hidden
        
        
        #line 378 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PencilBtn;
        
        #line default
        #line hidden
        
        
        #line 382 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EraserBtn;
        
        #line default
        #line hidden
        
        
        #line 386 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EllipseBtn;
        
        #line default
        #line hidden
        
        
        #line 390 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RectangleBtn;
        
        #line default
        #line hidden
        
        
        #line 394 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LineBtn;
        
        #line default
        #line hidden
        
        
        #line 399 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ThicknessPicker;
        
        #line default
        #line hidden
        
        
        #line 425 "..\..\..\..\View\WhiteboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Pic;
        
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
            System.Uri resourceLocater = new System.Uri("/Whiteboard;component/view/whiteboardview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WhiteboardView.xaml"
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
            this.ColorBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.PencilBtn = ((System.Windows.Controls.Button)(target));
            
            #line 378 "..\..\..\..\View\WhiteboardView.xaml"
            this.PencilBtn.Click += new System.Windows.RoutedEventHandler(this.PencilBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EraserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 382 "..\..\..\..\View\WhiteboardView.xaml"
            this.EraserBtn.Click += new System.Windows.RoutedEventHandler(this.EraserBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EllipseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 386 "..\..\..\..\View\WhiteboardView.xaml"
            this.EllipseBtn.Click += new System.Windows.RoutedEventHandler(this.EllipseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RectangleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 390 "..\..\..\..\View\WhiteboardView.xaml"
            this.RectangleBtn.Click += new System.Windows.RoutedEventHandler(this.RectangleBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LineBtn = ((System.Windows.Controls.Button)(target));
            
            #line 394 "..\..\..\..\View\WhiteboardView.xaml"
            this.LineBtn.Click += new System.Windows.RoutedEventHandler(this.LineBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ColorPicker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 399 "..\..\..\..\View\WhiteboardView.xaml"
            this.ColorPicker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ColorPicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ThicknessPicker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 410 "..\..\..\..\View\WhiteboardView.xaml"
            this.ThicknessPicker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ThicknessPicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Pic = ((System.Windows.Controls.Canvas)(target));
            
            #line 425 "..\..\..\..\View\WhiteboardView.xaml"
            this.Pic.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Pic_MouseDown);
            
            #line default
            #line hidden
            
            #line 425 "..\..\..\..\View\WhiteboardView.xaml"
            this.Pic.MouseMove += new System.Windows.Input.MouseEventHandler(this.Pic_MouseMove);
            
            #line default
            #line hidden
            
            #line 425 "..\..\..\..\View\WhiteboardView.xaml"
            this.Pic.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Pic_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

