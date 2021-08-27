<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572178/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T558616)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/MapControl_CustomProjections/MainPage.xaml) (VB: [MainPage.xaml](./VB/MapControl_CustomProjections/MainPage.xaml))
* [MainPage.xaml.cs](./CS/MapControl_CustomProjections/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/MapControl_CustomProjections/MainPage.xaml.vb))
<!-- default file list end -->
# How to: Customize the Cylindrical Equal-Area Projection


To customize equal-area projection, do the following.<br><br>1. Set an <strong>EqualAreaProjection</strong> object to the <strong>MapItemsLayerBase.MapProjection</strong> property of a vector data layer.<br>2. Specify its Width/Height ratio. To do this, assign this ratio based size to the <strong>MapItemsLayerBase.InitialMapSize</strong> property of the vector data layer.

<br/>


