' This classs ported from code at 
' http://marlongrech.wordpress.com/2009/09/14/how-to-set-wpf-scrollviewer-verticaloffset-and-horizontal-offset/
' by Marlon Grech


Namespace Coding4Fun.Obd.InstrumentCluster
	Friend Class ScrollViewerHelper
		#Region "HorizontalOffset"

		''' <summary>
		''' HorizontalOffset Attached Dependency Property
		''' </summary>
		Public Shared ReadOnly HorizontalOffsetProperty As DependencyProperty = DependencyProperty.RegisterAttached("HorizontalOffset", GetType(Double), GetType(ScrollViewerHelper), New FrameworkPropertyMetadata(0.0, AddressOf OnHorizontalOffsetChanged))

		''' <summary>
		''' Gets the HorizontalOffset property.  This dependency property 
		''' indicates ....
		''' </summary>
		Public Shared Function GetHorizontalOffset(ByVal d As DependencyObject) As Double
			Return CDbl(d.GetValue(HorizontalOffsetProperty))
		End Function

		''' <summary>
		''' Sets the HorizontalOffset property.  This dependency property 
		''' indicates ....
		''' </summary>
		Public Shared Sub SetHorizontalOffset(ByVal d As DependencyObject, ByVal value As Double)
			d.SetValue(HorizontalOffsetProperty, value)
		End Sub

		''' <summary>
		''' Handles changes to the HorizontalOffset property.
		''' </summary>
		Private Shared Sub OnHorizontalOffsetChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim viewer = CType(d, ScrollViewer)
			viewer.ScrollToHorizontalOffset(CDbl(e.NewValue))
		End Sub

		#End Region

		#Region "VerticalOffset"

		''' <summary>
		''' VerticalOffset Attached Dependency Property
		''' </summary>
		Public Shared ReadOnly VerticalOffsetProperty As DependencyProperty = DependencyProperty.RegisterAttached("VerticalOffset", GetType(Double), GetType(ScrollViewerHelper), New FrameworkPropertyMetadata(0.0, AddressOf OnVerticalOffsetChanged))

		''' <summary>
		''' Gets the VerticalOffset property.  This dependency property 
		''' indicates ....
		''' </summary>
		Public Shared Function GetVerticalOffset(ByVal d As DependencyObject) As Double
			Return CDbl(d.GetValue(VerticalOffsetProperty))
		End Function

		''' <summary>
		''' Sets the VerticalOffset property.  This dependency property 
		''' indicates ....
		''' </summary>
		Public Shared Sub SetVerticalOffset(ByVal d As DependencyObject, ByVal value As Double)
			d.SetValue(VerticalOffsetProperty, value)
		End Sub

		''' <summary>
		''' Handles changes to the VerticalOffset property.
		''' </summary>
		Private Shared Sub OnVerticalOffsetChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim viewer = CType(d, ScrollViewer)
			viewer.ScrollToVerticalOffset(CDbl(e.NewValue))
		End Sub

		#End Region
	End Class
End Namespace