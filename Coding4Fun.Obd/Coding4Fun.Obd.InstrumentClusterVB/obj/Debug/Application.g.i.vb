﻿#ExternalChecksum("..\..\Application.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","3A1F68BAB13CA859BA004A91D05B1E03")
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

Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967
Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin2011
Imports Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro
Imports Microsoft.Windows.Themes
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
    '''App
    '''</summary>
    Partial Public Class App
        Inherits System.Windows.Application
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            
            #ExternalSource("..\..\Application.xaml",12)
            Me.StartupUri = New System.Uri("MainWindow.xaml", System.UriKind.Relative)
            
            #End ExternalSource
            Dim resourceLocater As System.Uri = New System.Uri("/Coding4Fun.Obd.InstrumentCluster;component/application.xaml", System.UriKind.Relative)
            
            #ExternalSource("..\..\Application.xaml",1)
            System.Windows.Application.LoadComponent(Me, resourceLocater)
            
            #End ExternalSource
        End Sub
        
        '''<summary>
        '''Application Entry Point.
        '''</summary>
        <System.STAThreadAttribute(),  _
         System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Shared Sub Main()
            Dim app As Coding4Fun.Obd.InstrumentCluster.App = New Coding4Fun.Obd.InstrumentCluster.App()
            app.InitializeComponent
            app.Run
        End Sub
    End Class
End Namespace

