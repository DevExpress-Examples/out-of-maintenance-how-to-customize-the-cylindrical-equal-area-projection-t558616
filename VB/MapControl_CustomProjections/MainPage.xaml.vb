Imports DevExpress.UI.Xaml.Map
Imports Windows.Foundation
Imports Windows.UI.Xaml.Controls

Namespace MapControl_CustomProjections
    Public NotInheritable Partial Class MainPage
        Inherits Page


        Private projectionRatios_Renamed() As ProjectionRatio = { _
            New ProjectionRatio("Lambert", 3.14), _
            New ProjectionRatio("Behrmann", 2.36), _
            New ProjectionRatio("Trystan Edwards", 2), _
            New ProjectionRatio("Gall-Peters", 1.57), _
            New ProjectionRatio("Balthasart", 1.3), _
            New ProjectionRatio("Default", 1) _
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
        Public Sub New(ByVal name As String, ByVal value As Double)
            Me.Name = name
            Me.Value = value
        End Sub

        Public Property Name() As String
        Public Property Value() As Double
    End Class

End Namespace
