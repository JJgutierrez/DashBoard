﻿#ExternalChecksum("..\..\SkinSelector.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","B6D3962FB274276931D0EA392C4E6DBF")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Coding4Fun.Obd.InstrumentCluster
Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967
Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011
Imports Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell

Namespace Coding4Fun.Obd.InstrumentCluster
    
    '''<summary>
    '''SkinSelector
    '''</summary>
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class SkinSelector
        Inherits System.Windows.Controls.UserControl
        Implements System.Windows.Markup.IComponentConnector
        
        
        #ExternalSource("..\..\SkinSelector.xaml",8)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents UserControl As Coding4Fun.Obd.InstrumentCluster.SkinSelector
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",24)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",25)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents Scroll As System.Windows.Controls.ScrollViewer
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",29)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents uxSkin2011 As Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011.Skin
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",30)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents uxSkin1967 As Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967.Skin
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",31)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents uxSkinMetro As Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro.Skin
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\SkinSelector.xaml",34)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents uxAccentColorsSelection As Coding4Fun.Obd.InstrumentCluster.AccentColorsSelection
        
        #End ExternalSource
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            Dim resourceLocater As System.Uri = New System.Uri("/Coding4Fun.Obd.InstrumentCluster;component/skinselector.xaml", System.UriKind.Relative)
            
            #ExternalSource("..\..\SkinSelector.xaml",1)
            System.Windows.Application.LoadComponent(Me, resourceLocater)
            
            #End ExternalSource
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Function _CreateDelegate(ByVal delegateType As System.Type, ByVal handler As String) As System.[Delegate]
            Return System.[Delegate].CreateDelegate(delegateType, Me, handler)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
        Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
            If (connectionId = 1) Then
                Me.UserControl = CType(target,Coding4Fun.Obd.InstrumentCluster.SkinSelector)
                
                #ExternalSource("..\..\SkinSelector.xaml",12)
                AddHandler Me.UserControl.Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.UserControl_Loaded)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 2) Then
                Me.LayoutRoot = CType(target,System.Windows.Controls.Grid)
                Return
            End If
            If (connectionId = 3) Then
                Me.Scroll = CType(target,System.Windows.Controls.ScrollViewer)
                
                #ExternalSource("..\..\SkinSelector.xaml",26)
                AddHandler Me.Scroll.TouchDown, New System.EventHandler(Of System.Windows.Input.TouchEventArgs)(AddressOf Me.Scroll_TouchDown)
                
                #End ExternalSource
                
                #ExternalSource("..\..\SkinSelector.xaml",26)
                AddHandler Me.Scroll.TouchMove, New System.EventHandler(Of System.Windows.Input.TouchEventArgs)(AddressOf Me.Scroll_TouchMove)
                
                #End ExternalSource
                
                #ExternalSource("..\..\SkinSelector.xaml",26)
                AddHandler Me.Scroll.TouchUp, New System.EventHandler(Of System.Windows.Input.TouchEventArgs)(AddressOf Me.Scroll_TouchUp)
                
                #End ExternalSource
                
                #ExternalSource("..\..\SkinSelector.xaml",27)
                AddHandler Me.Scroll.PreviewMouseDown, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.Scroll_PreviewMouseDown)
                
                #End ExternalSource
                
                #ExternalSource("..\..\SkinSelector.xaml",27)
                AddHandler Me.Scroll.MouseMove, New System.Windows.Input.MouseEventHandler(AddressOf Me.Scroll_MouseMove)
                
                #End ExternalSource
                
                #ExternalSource("..\..\SkinSelector.xaml",27)
                AddHandler Me.Scroll.MouseUp, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.Scroll_MouseUp)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 4) Then
                Me.uxSkin2011 = CType(target,Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011.Skin)
                Return
            End If
            If (connectionId = 5) Then
                Me.uxSkin1967 = CType(target,Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967.Skin)
                Return
            End If
            If (connectionId = 6) Then
                Me.uxSkinMetro = CType(target,Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro.Skin)
                Return
            End If
            If (connectionId = 7) Then
                Me.uxAccentColorsSelection = CType(target,Coding4Fun.Obd.InstrumentCluster.AccentColorsSelection)
                Return
            End If
            Me._contentLoaded = true
        End Sub
    End Class
End Namespace

