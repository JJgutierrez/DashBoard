Imports System.Windows
Imports System.Windows.Controls

Namespace Coding4Fun.Obd.InstrumentCluster
	''' <summary>
	''' Interaction logic for AccentColorsSelection.xaml
	''' </summary>
	Partial Public Class AccentColorsSelection
		Inherits UserControl
		Private _IsOpen As Boolean = False

		Public Sub New()
			Me.InitializeComponent()
			AddHandler Loaded, AddressOf AccentColorsSelection_Loaded
		End Sub

		Private Sub AccentColorsSelection_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			VisualStateManager.GoToState(Me, "Closed", False)

			AddHandler uxClose.Click, AddressOf uxClose_Click

			AddHandler uxThemeColor_Green.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Red.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Blue.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Yellow.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Pink.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Brown.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Lime.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Teal.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Purple.Click, AddressOf uxThemeColor_Click
			AddHandler uxThemeColor_Magenta.Click, AddressOf uxThemeColor_Click
		End Sub

		Private Sub uxThemeColor_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Application.Current.Resources("AccentColor") = CType(sender, RadioButton).Foreground
			IsOpen = False
		End Sub

		Private Sub uxClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			IsOpen = False
		End Sub

		Public Property IsOpen() As Boolean
			Get
				Return _IsOpen
			End Get
			Set(ByVal value As Boolean)
				_IsOpen = value
				VisualStateManager.GoToState(Me,If(value, "Open", "Closed"), True)
			End Set
		End Property
	End Class
End Namespace