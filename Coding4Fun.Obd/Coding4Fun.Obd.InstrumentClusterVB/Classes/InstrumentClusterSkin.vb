Imports System.Windows
Imports System.Windows.Controls

Imports Coding4Fun.Obd.InstrumentCluster.Controls
Imports Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967

Namespace Coding4Fun.Obd.InstrumentCluster.Classes
	Public Class InstrumentClusterSkin
		Inherits UserControl
		Public uxSettings As Button
		Public uxLeftTurn As Blinker
		Public uxRightTurn As Blinker
		Public uxLowFuel As FrameworkElement
		Public uxHazard As FrameworkElement
		Public uxMalfunction As FrameworkElement
		Public uxOpenDoor As FrameworkElement
		Public uxMessage As TextBlock
		Public uxMessageMarquee As Marquee
		Public uxOdometer As TextBlock
		Public uxMPG As TextBlock
		Public uxMPH As Slider
		Public uxRPM As Slider
		Public uxFuel As Slider
		Public uxTemp As Slider
		Public uxOil As Slider
		Public uxBattery As Slider
		Public uxMPHLabel As TextBlock
		Public uxRPMLabel As TextBlock

		Private _IsLeftTurnBlinkerVisible As Boolean
		Private _IsRightTurnBlinkerVisible As Boolean
		Private _IsLowFuelVisible As Boolean
		Private _IsHazardVisible As Boolean
		Private _IsMalfunctionVisible As Boolean
		Private _IsOpenDoorVisible As Boolean
		Private _Message As String
		Private _Mileage As Double
		Private _MPG As Double
		Private _MPH As Double
		Private _RPM As Double
		Private _Fuel As Double
		Private _Temperature As Double
		Private _Oil As Double
		Private _BatteryLevel As Double

		Public Sub New()
			AddHandler Initialized, AddressOf Skin_Initialized
		End Sub

		Private Sub Skin_Initialized(ByVal sender As Object, ByVal e As EventArgs)
			uxSettings = TryCast(FindName("uxSettings"), Button)
			uxLeftTurn = TryCast(FindName("uxLeftTurn"), Blinker)
			uxRightTurn = TryCast(FindName("uxRightTurn"), Blinker)
			uxLowFuel = TryCast(FindName("uxLowFuel"), FrameworkElement)
			uxHazard = TryCast(FindName("uxHazard"), FrameworkElement)
			uxMalfunction = TryCast(FindName("uxMalfunction"), FrameworkElement)
			uxOpenDoor = TryCast(FindName("uxOpenDoor"), FrameworkElement)
			uxMessage = TryCast(FindName("uxMessage"), TextBlock)
			uxMessageMarquee = TryCast(FindName("uxMessageMarquee"), Marquee)
			uxOdometer = TryCast(FindName("uxOdometer"), TextBlock)
			uxMPG = TryCast(FindName("uxMPG"), TextBlock)
			uxMPH = TryCast(FindName("uxMPH"), Slider)
			uxRPM = TryCast(FindName("uxRPM"), Slider)
			uxFuel = TryCast(FindName("uxFuel"), Slider)
			uxTemp = TryCast(FindName("uxTemp"), Slider)
			uxOil = TryCast(FindName("uxOil"), Slider)
			uxBattery = TryCast(FindName("uxBattery"), Slider)
			uxMPHLabel = TryCast(FindName("uxMPHLabel"), TextBlock)
			uxRPMLabel = TryCast(FindName("uxRPMLabel"), TextBlock)
		End Sub

		Public Property IsLeftTurnBlinkerVisible() As Boolean
			Get
				Return _IsLeftTurnBlinkerVisible
			End Get
			Set(ByVal value As Boolean)
				_IsLeftTurnBlinkerVisible = value
				If uxLeftTurn IsNot Nothing Then
					uxLeftTurn.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
			End Set
		End Property

		Public Property IsRightTurnBlinkerVisible() As Boolean
			Get
				Return _IsRightTurnBlinkerVisible
			End Get
			Set(ByVal value As Boolean)
				_IsRightTurnBlinkerVisible = value
				If uxRightTurn IsNot Nothing Then
					uxRightTurn.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
			End Set
		End Property

		Public Property IsLowFuelVisible() As Boolean
			Get
				Return _IsLowFuelVisible
			End Get
			Set(ByVal value As Boolean)
				_IsLowFuelVisible = value
				If uxLowFuel IsNot Nothing Then
					uxLowFuel.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
				If uxFuel IsNot Nothing Then
					uxFuel.IsEnabled = Not value
				End If
			End Set
		End Property

		Public Property IsHazardVisible() As Boolean
			Get
				Return _IsHazardVisible
			End Get
			Set(ByVal value As Boolean)
				_IsHazardVisible = value
				If uxHazard IsNot Nothing Then
					uxHazard.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
			End Set
		End Property

		Public Property IsMalfunctionVisible() As Boolean
			Get
				Return _IsMalfunctionVisible
			End Get
			Set(ByVal value As Boolean)
				_IsMalfunctionVisible = value
				If uxMalfunction IsNot Nothing Then
					uxMalfunction.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
			End Set
		End Property

		Public Property IsOpenDoorVisible() As Boolean
			Get
				Return _IsOpenDoorVisible
			End Get
			Set(ByVal value As Boolean)
				_IsOpenDoorVisible = value
				If uxOpenDoor IsNot Nothing Then
					uxOpenDoor.Visibility = If(value, Visibility.Visible, Visibility.Hidden)
				End If
			End Set
		End Property

		Public Property Message() As String
			Get
				Return _Message
			End Get
			Set(ByVal value As String)
				_Message = value
				If uxMessage IsNot Nothing Then
					uxMessage.Text = value
				End If
				If uxMessageMarquee IsNot Nothing Then
					uxMessageMarquee.Text = value
				End If
			End Set
		End Property

		Public Property Mileage() As Double
			Get
				Return _Mileage
			End Get
			Set(ByVal value As Double)
				_Mileage = value
				If uxOdometer IsNot Nothing Then
					uxOdometer.Text = Math.Floor(value).ToString()
				End If
			End Set
		End Property

		Public Property MPG() As Double
			Get
				Return _MPG
			End Get
			Set(ByVal value As Double)
				_MPG = value
				If uxMPG IsNot Nothing Then
					uxMPG.Text = Math.Round(value).ToString()
				End If
			End Set
		End Property

		Public Property MPH() As Double
			Get
				Return _MPH
			End Get
			Set(ByVal value As Double)
				_MPH = value
				If uxMPH IsNot Nothing Then
					uxMPH.Value = value
				End If
				If uxMPHLabel IsNot Nothing Then
					uxMPHLabel.Text = Math.Ceiling(value).ToString()
				End If
			End Set
		End Property

		Public Property RPM() As Double
			Get
				Return _RPM
			End Get
			Set(ByVal value As Double)
				_RPM = value
				If uxRPM IsNot Nothing Then
					uxRPM.Value = value
				End If
				If uxRPMLabel IsNot Nothing Then
					uxRPMLabel.Text = Math.Ceiling(value).ToString()
				End If
			End Set
		End Property

		Public Property Fuel() As Double
			Get
				Return _Fuel
			End Get
			Set(ByVal value As Double)
				_Fuel = value
				If uxFuel IsNot Nothing Then
					uxFuel.Value = value
				End If
				IsLowFuelVisible = value < 10
			End Set
		End Property

		Public Property Temperature() As Double
			Get
				Return _Temperature
			End Get
			Set(ByVal value As Double)
				_Temperature = value
				If uxTemp IsNot Nothing Then
					uxTemp.Value = value
				End If
			End Set
		End Property

		Public Property Oil() As Double
			Get
				Return _Oil
			End Get
			Set(ByVal value As Double)
				_Oil = value
				If uxOil IsNot Nothing Then
					uxOil.Value = value
				End If
			End Set
		End Property

		Public Property BatteryLevel() As Double
			Get
				Return _BatteryLevel
			End Get
			Set(ByVal value As Double)
				_BatteryLevel = value
				If uxBattery IsNot Nothing Then
					uxBattery.Value = value
				End If
			End Set
		End Property
	End Class
End Namespace
