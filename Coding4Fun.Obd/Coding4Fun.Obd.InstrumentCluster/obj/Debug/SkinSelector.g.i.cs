﻿#pragma checksum "..\..\SkinSelector.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6D3962FB274276931D0EA392C4E6DBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Obd.InstrumentCluster;
using Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967;
using Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011;
using Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro;
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


namespace Coding4Fun.Obd.InstrumentCluster {
    
    
    /// <summary>
    /// SkinSelector
    /// </summary>
    public partial class SkinSelector : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Coding4Fun.Obd.InstrumentCluster.SkinSelector UserControl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Scroll;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011.Skin uxSkin2011;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967.Skin uxSkin1967;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro.Skin uxSkinMetro;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SkinSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Coding4Fun.Obd.InstrumentCluster.AccentColorsSelection uxAccentColorsSelection;
        
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
            System.Uri resourceLocater = new System.Uri("/Coding4Fun.Obd.InstrumentCluster;component/skinselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SkinSelector.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.UserControl = ((Coding4Fun.Obd.InstrumentCluster.SkinSelector)(target));
            
            #line 12 "..\..\SkinSelector.xaml"
            this.UserControl.Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Scroll = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 26 "..\..\SkinSelector.xaml"
            this.Scroll.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Scroll_TouchDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\SkinSelector.xaml"
            this.Scroll.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Scroll_TouchMove);
            
            #line default
            #line hidden
            
            #line 26 "..\..\SkinSelector.xaml"
            this.Scroll.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Scroll_TouchUp);
            
            #line default
            #line hidden
            
            #line 27 "..\..\SkinSelector.xaml"
            this.Scroll.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Scroll_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\SkinSelector.xaml"
            this.Scroll.MouseMove += new System.Windows.Input.MouseEventHandler(this.Scroll_MouseMove);
            
            #line default
            #line hidden
            
            #line 27 "..\..\SkinSelector.xaml"
            this.Scroll.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Scroll_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uxSkin2011 = ((Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011.Skin)(target));
            return;
            case 5:
            this.uxSkin1967 = ((Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967.Skin)(target));
            return;
            case 6:
            this.uxSkinMetro = ((Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro.Skin)(target));
            return;
            case 7:
            this.uxAccentColorsSelection = ((Coding4Fun.Obd.InstrumentCluster.AccentColorsSelection)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

