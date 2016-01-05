Imports Coding4Fun.Obd.InstrumentCluster.Classes

Namespace Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro
	''' <summary>
	''' Interaction logic for Skin.xaml
	''' </summary>
	Partial Public Class Skin
		Inherits InstrumentClusterSkin
		Private _MPG As Double
		Private _Mileage As Double

		Public Sub New()
			Me.InitializeComponent()
		End Sub

		Public Shadows Property MPG() As Double
			Get
				Return _MPG
			End Get
			Set(ByVal value As Double)
				_MPG = value
				If uxMPG IsNot Nothing Then
					uxMPG.Text = String.Format("{0:0.0}", value)
				End If
			End Set
		End Property

		Public Shadows Property Mileage() As Double
			Get
				Return _Mileage
			End Get
			Set(ByVal value As Double)
				_Mileage = value
				If uxOdometer IsNot Nothing Then
					uxOdometer.Text = String.Format("{0:0,0.0}", value)
				End If
			End Set
		End Property

	End Class
End Namespace