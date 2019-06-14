Imports DevExpress.UI.Xaml.Map
Imports Windows.Foundation
Imports Windows.UI.Xaml.Controls

Namespace MapControl_CustomProjections
	Public NotInheritable Partial Class MainPage
		Inherits Page

'INSTANT VB NOTE: The field projectionRatios was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private projectionRatios_Renamed() As ProjectionRatio = {
			New ProjectionRatio("Lambert", 3.14),
			New ProjectionRatio("Behrmann", 2.36),
			New ProjectionRatio("Trystan Edwards", 2),
			New ProjectionRatio("Gall-Peters", 1.57),
			New ProjectionRatio("Balthasart", 1.3),
			New ProjectionRatio("Default", 1)
		}

		Private sizeValue As Integer = 512

		Public ReadOnly Property ProjectionRatios() As ProjectionRatio()
			Get
				Return projectionRatios_Renamed
			End Get
		End Property

		Public Sub New()
			Me.InitializeComponent()
			Me.DataContext = Me
		End Sub

		Private Sub ListView_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			Dim listView As ListView = TryCast(sender, ListView)
			If listView Is Nothing Then
				Return
			End If

			CType(mapControl.Layers(0), VectorFileLayer).InitialMapSize = New Size(CType(listView.SelectedItem, ProjectionRatio).Value * sizeValue, sizeValue)
		End Sub

		Private Sub Page_Loaded(ByVal sender As Object, ByVal e As Windows.UI.Xaml.RoutedEventArgs)
			listView.SelectedIndex = ProjectionRatios.Length - 1
		End Sub
	End Class

	Public Class ProjectionRatio
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal name_Renamed As String, ByVal value_Renamed As Double)
			Me.Name = name_Renamed
			Me.Value = value_Renamed
		End Sub

		Public Property Name() As String
		Public Property Value() As Double
	End Class

End Namespace
