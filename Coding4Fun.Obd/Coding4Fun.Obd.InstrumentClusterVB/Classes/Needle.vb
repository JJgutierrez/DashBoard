Imports System.Windows
Imports System.Windows.Controls

Imports System.ComponentModel
Imports System.Windows.Media.Animation

Namespace Coding4Fun.Obd.InstrumentCluster.Classes
	Public Class Needle
		Inherits UserControl
		Private Const SLOWNESS As Double = 5

		Private uxSB_GameLoop As Storyboard
		Private uxNeedle As FrameworkElement
		Public Needle_RotateTransform As New RotateTransform()
		Public tg As New TransformGroup()
		Private desiredAngle As Double

		Public Sub New()
			AddHandler Loaded, AddressOf Needle_Loaded
			AddHandler Initialized, AddressOf Needle_Initialized
		End Sub

		Private Sub Needle_Initialized(ByVal sender As Object, ByVal e As EventArgs)
			uxNeedle = CType(FindName("uxNeedle"), FrameworkElement)
			uxSB_GameLoop = CType(TryFindResource("uxSB_GameLoop"), Storyboard)
		End Sub

		Private Sub Needle_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			If uxNeedle IsNot Nothing Then
				uxNeedle.RenderTransform = Needle_RotateTransform
			End If
			If uxSB_GameLoop IsNot Nothing Then
				AddHandler uxSB_GameLoop.Completed, AddressOf uxSB_GameLoop_Completed
				uxSB_GameLoop.Begin()
			End If
		End Sub

		Private Sub uxSB_GameLoop_Completed(ByVal sender As Object, ByVal e As EventArgs)
			Needle_RotateTransform.Angle += (desiredAngle - Needle_RotateTransform.Angle) / Math.Max(SLOWNESS, 1)
			uxSB_GameLoop.Begin()
		End Sub

		Public Sub UpdateNeedle()
			desiredAngle = If(Maximum = Minimum, Maximum, MinAngle + (MaxAngle - MinAngle) * (Math.Min(Math.Max(Value, Minimum), Maximum) - Minimum) / (Maximum - Minimum))
			If uxSB_GameLoop Is Nothing Then
				Needle_RotateTransform.Angle = desiredAngle
			End If
		End Sub

		Private Shared Sub OnValuesChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim ln As Needle = CType(d, Needle)
			ln.UpdateNeedle()
		End Sub

		<Category("Common Properties")> _
		Public Property Value() As Double
			Get
				Return CDbl(GetValue(ValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(ValueProperty, value)
			End Set
		End Property
		Public Shared ReadOnly ValueProperty As DependencyProperty = DependencyProperty.Register("Value", GetType(Double), GetType(Needle), New PropertyMetadata(New Double(), New PropertyChangedCallback(AddressOf OnValuesChanged)))

		<Category("Common Properties")> _
		Public Property Minimum() As Double
			Get
				Return CDbl(GetValue(MinimumProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MinimumProperty, value)
			End Set
		End Property
		Public Shared ReadOnly MinimumProperty As DependencyProperty = DependencyProperty.Register("Minimum", GetType(Double), GetType(Needle), New PropertyMetadata(New Double(), New PropertyChangedCallback(AddressOf OnValuesChanged)))


		<Category("Common Properties")> _
		Public Property Maximum() As Double
			Get
				Return CDbl(GetValue(MaximumProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MaximumProperty, value)
			End Set
		End Property
		Public Shared ReadOnly MaximumProperty As DependencyProperty = DependencyProperty.Register("Maximum", GetType(Double), GetType(Needle), New PropertyMetadata(New Double(), New PropertyChangedCallback(AddressOf OnValuesChanged)))


		<Category("Common Properties")> _
		Public Property MinAngle() As Double
			Get
				Return CDbl(GetValue(MinAngleProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MinAngleProperty, value)
			End Set
		End Property
		Public Shared ReadOnly MinAngleProperty As DependencyProperty = DependencyProperty.Register("MinAngle", GetType(Double), GetType(Needle), New PropertyMetadata(New Double(), New PropertyChangedCallback(AddressOf OnValuesChanged)))


		<Category("Common Properties")> _
		Public Property MaxAngle() As Double
			Get
				Return CDbl(GetValue(MaxAngleProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MaxAngleProperty, value)
			End Set
		End Property
		Public Shared ReadOnly MaxAngleProperty As DependencyProperty = DependencyProperty.Register("MaxAngle", GetType(Double), GetType(Needle), New PropertyMetadata(New Double(), New PropertyChangedCallback(AddressOf OnValuesChanged)))

	End Class
End Namespace
