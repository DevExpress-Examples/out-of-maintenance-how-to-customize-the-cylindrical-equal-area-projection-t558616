
Imports DevExpress.UI.Xaml.Map

Partial Public NotInheritable Class MainPage
    Inherits Page

    Private projRatios() As ProjectionRatio = {
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
            Return projRatios
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

