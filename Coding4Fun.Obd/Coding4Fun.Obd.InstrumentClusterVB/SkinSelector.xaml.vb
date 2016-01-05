Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input

Imports System.ComponentModel
Imports System.Threading.Tasks
Imports System.Windows.Media.Animation
Imports Coding4Fun.Obd.InstrumentCluster.Classes
Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967
Imports Coding4Fun.Obd.ObdManager

Namespace Coding4Fun.Obd.InstrumentCluster
	''' <summary>
	''' Interaction logic for SkinSelector.xaml
	''' </summary>
	Partial Public Class SkinSelector
		Inherits UserControl
		Private Const SwipeDistance As Integer = 200

		Private ReadOnly _skins(2) As InstrumentClusterSkin
		Private _startPoint As Point
		Private _obd As ObdDevice

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			_obd = New ObdDevice()

			AddHandler _obd.ObdConnectionChanged, AddressOf _obd_ObdConnectionChanged
			AddHandler _obd.ObdChanged, AddressOf _obd_ObdChanged

			SetMessage("Connecting to OBD...")

			If (Not DesignerProperties.GetIsInDesignMode(Me)) AndAlso (Not String.IsNullOrEmpty(My.Settings.Default.ComPort)) Then
				Try
					Task.Factory.StartNew(Sub() _obd.Connect(My.Settings.Default.ComPort, My.Settings.Default.Baud, ObdDevice.UnknownProtocol, True)).ContinueWith(Sub(action)
					Dim ex as Exception = action.Exception.Flatten
					SetMessage("Unable to connect to OBD device: " & ex.Message)
					Debug.WriteLine(ex)
					End Sub
				)
				Catch ex As Exception
					SetMessage("Unable to connect to OBD device: " & ex.Message)
					Debug.WriteLine(ex)
				End Try
			End If

			AddHandler uxSkin1967.uxSettings.Click, AddressOf uxSettings_Click
			AddHandler uxSkin2011.uxSettings.Click, AddressOf uxSettings_Click
			AddHandler uxSkinMetro.uxSettings.Click, AddressOf uxSettings_Click

			_skins(0) = uxSkin2011
			_skins(1) = uxSkin1967
			_skins(2) = uxSkinMetro

			uxSkin1967.Visibility = Visibility.Collapsed
			uxSkinMetro.Visibility = Visibility.Collapsed
		End Sub

		Private Sub SetMessage(ByVal txt As String)
			Dispatcher.BeginInvoke(New Action(Sub()
				uxSkin1967.Message = txt
				uxSkin2011.Message = txt
				uxSkinMetro.Message = txt
			End Sub))
		End Sub

		Private Sub _obd_ObdConnectionChanged(ByVal sender As Object, ByVal e As ConnectionChangedEventArgs)
			SetMessage("OBD " & (If(e.Connected, "Connected", "Disconnected")))
		End Sub

		Private Sub _obd_ObdChanged(ByVal sender As Object, ByVal e As ObdChangedEventArgs)
			Dispatcher.BeginInvoke(New Action(Sub() SetInstrumentClusterValues(e.ObdState)))
		End Sub

		Private Sub SetInstrumentClusterValues(ByVal measurement As ObdState)
			For Each item In _skins
				If Not item.IsVisible Then
					Continue For
				End If

				item.IsMalfunctionVisible = measurement.MilLightOn

				item.IsLowFuelVisible = item.Fuel < 10

				item.MPG = measurement.MilesPerGallon
				item.MPH = measurement.MilesPerHour
				item.RPM = measurement.Rpm
				item.Fuel = measurement.FuelLevel
				item.Temperature = measurement.EngineCoolantTemperature
			Next item
		End Sub

		Private Sub uxSettings_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			uxAccentColorsSelection.IsOpen = True
		End Sub

		Private Sub Scroll_TouchDown(ByVal sender As Object, ByVal e As TouchEventArgs)
			TouchMouseDown(e.GetTouchPoint(Scroll).Position)
			e.Handled = True
		End Sub

		Private Sub Scroll_TouchMove(ByVal sender As Object, ByVal e As TouchEventArgs)
			e.Handled = True
		End Sub

		Private Sub Scroll_TouchUp(ByVal sender As Object, ByVal e As TouchEventArgs)
			TouchMouseUp(e.GetTouchPoint(Scroll).Position)
			e.Handled = True
		End Sub

		Private Sub Scroll_PreviewMouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			TouchMouseDown(e.GetPosition(Scroll))
			e.Handled = True
		End Sub

		Private Sub Scroll_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			e.Handled = True
		End Sub

		Private Sub Scroll_MouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			TouchMouseUp(e.GetPosition(Scroll))
			e.Handled = True
		End Sub

		Private Sub TouchMouseDown(ByVal p As Point)
			uxSkin1967.Visibility = Visibility.Visible
			uxSkin2011.Visibility = Visibility.Visible
			uxSkinMetro.Visibility = Visibility.Visible

			_startPoint = p
		End Sub

		Private Sub TouchMouseUp(ByVal p As Point)
			If p.X > _startPoint.X + SwipeDistance Then
				DoScrollAnimation(-1)
			ElseIf p.X < _startPoint.X - SwipeDistance Then
				DoScrollAnimation(1)
			Else
				HandleVisibility()
			End If
		End Sub


		Private Sub DoScrollAnimation(ByVal direction As Integer)
			Dim sb As Storyboard = CType(FindResource("ScrollAnimation"), Storyboard)
			Dim da As DoubleAnimation = CType(sb.Children(0), DoubleAnimation)
			da.To = Scroll.HorizontalOffset + (Scroll.ViewportWidth * direction)
			AddHandler sb.Completed, AddressOf sb_Completed
			sb.Begin()
		End Sub

		Private Sub sb_Completed(ByVal sender As Object, ByVal e As EventArgs)
			HandleVisibility()
		End Sub

		Private Sub HandleVisibility()
			If Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 0) < 1 Then
				uxSkin2011.Visibility = Visibility.Visible
				uxSkin1967.Visibility = Visibility.Collapsed
				uxSkinMetro.Visibility = Visibility.Collapsed

			ElseIf Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 1) < 1 Then
				uxSkin2011.Visibility = Visibility.Collapsed
				uxSkin1967.Visibility = Visibility.Visible
				uxSkinMetro.Visibility = Visibility.Collapsed

			ElseIf Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 2) < 1 Then
				uxSkin2011.Visibility = Visibility.Collapsed
				uxSkin1967.Visibility = Visibility.Collapsed
				uxSkinMetro.Visibility = Visibility.Visible
			End If
		End Sub
	End Class
End Namespace