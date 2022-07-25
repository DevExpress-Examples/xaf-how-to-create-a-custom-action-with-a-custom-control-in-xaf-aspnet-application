<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588557/16.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4357)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyProcessActionContainerHolderController.cs](./CS/Solution28.Module.Web/Controllers/MyProcessActionContainerHolderController.cs) (VB: [MyProcessActionContainerHolderController.vb](./VB/Solution28.Module.Web/Controllers/MyProcessActionContainerHolderController.vb))
* [ParametrizedRangeActionMenuActionItem.cs](./CS/Solution28.Module.Web/ParametrizedRangeActionMenuActionItem.cs) (VB: [ParametrizedRangeActionMenuActionItem.vb](./VB/Solution28.Module.Web/ParametrizedRangeActionMenuActionItem.vb))
<!-- default file list end -->
# How to create a custom Action with a custom control in XAF ASP.NET WebForms application


<p><strong>Scenario</strong><br>Sometimes, it is necessary to extend our built-in Actions to be able to use a custom control for a specific task. For example, add two DateTime editors to accept a data range instead of creating two separate ParametrizedActions.</p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application-e4357/16.1.7+/media/dfa5b301-c102-11e6-80bf-00155d62480c.png"><br><br></p>
<p><strong>Steps to implement:<br></strong></p>

Inherit the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppWebSystemModuleProcessActionContainerHolderControllertopic">ProcessActionContainerHolderController</a> and override the OnCreateCustomMenuActionItem method and return a custom TemplatedMenuActionItem, which will represent the Action's control. See the MyProcessActionContainerHolderController.xx class code for additional details.<br>
<br/>

## See Also

 - [How to create a custom action type with a custom control (BarCheckItem), associated with it](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977) (WinForms)
 - [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor) (ASP.NET Core Blazor Server)
