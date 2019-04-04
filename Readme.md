<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/MapControl_CustomProjections/MainPage.xaml) (VB: [MainPage.xaml](./VB/MapControl_CustomProjections/MainPage.xaml))
* [MainPage.xaml.cs](./CS/MapControl_CustomProjections/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/MapControl_CustomProjections/MainPage.xaml.vb))
<!-- default file list end -->
# How to: Customize the Cylindrical Equal-Area Projection


To customize equal-area projection, do the following.<br><br>1. Set an <strong>EqualAreaProjection</strong> object to the <strong>MapItemsLayerBase.MapProjection</strong> property of a vector data layer.<br>2. Specify its Width/Height ratio. To do this, assign this ratio based size to the <strong>MapItemsLayerBase.InitialMapSize</strong> property of the vector data layer.

<br/>


