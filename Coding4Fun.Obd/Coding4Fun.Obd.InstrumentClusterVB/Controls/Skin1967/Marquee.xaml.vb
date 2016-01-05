Imports System.Windows
Imports System.Windows.Controls

Imports System.ComponentModel
Imports System.Windows.Media.Animation

Namespace Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967
	''' <summary>
	''' Interaction logic for Marquee.xaml
	''' </summary>
	Partial Public Class Marquee
		Inherits UserControl
		Private uxSB_GameLoop As Storyboard

		Public Sub New()
			Me.InitializeComponent()
			AddHandler Loaded, AddressOf Marquee_Loaded
		End Sub

		Private Sub Marquee_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			uxSB_GameLoop = CType(TryFindResource("uxSB_GameLoop"), Storyboard)
			If uxSB_GameLoop IsNot Nothing Then
				AddHandler uxSB_GameLoop.Completed, AddressOf uxSB_GameLoop_Completed
				uxSB_GameLoop.Begin()
			End If
		End Sub

		Private Sub uxSB_GameLoop_Completed(ByVal sender As Object, ByVal e As EventArgs)
			Dim x As Double = CDbl(uxTextBlock.GetValue(Canvas.LeftProperty))-2
			If x <= -uxTextBlock.ActualWidth Then
				x = LayoutRoot.Width
			End If

			uxTextBlock.SetValue(Canvas.LeftProperty, x)
			uxSB_GameLoop.Begin()
		End Sub

		Private Shared Sub OnValuesChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim m As Marquee = CType(d, Marquee)
			m.UpdateText()
		End Sub

		Public Sub UpdateText()
			uxTextBlock.Text = Text
			uxTextBlock.SetValue(Canvas.LeftProperty, LayoutRoot.Width)
		End Sub

		<Category("Common Properties")> _
		Public Property Text() As String
			Get
				Return CStr(GetValue(TextProperty))
			End Get
			Set(ByVal value As String)
				SetValue(TextProperty, value)
			End Set
		End Property
		Public Shared ReadOnly TextProperty As DependencyProperty = DependencyProperty.Register("Text", GetType(String), GetType(Marquee), New PropertyMetadata("", New PropertyChangedCallback(AddressOf OnValuesChanged)))
	End Class
End Namespace