<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588557/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4357)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF - How to create a custom Action with a custom control in XAF ASP.NET WebForms application

Sometimes, it is necessary to extend our built-in Actions to be able to use a custom control for a specific task. For example, add two `DateTime` editors to accept a data range instead of creating two separate `ParametrizedActions`.

![image](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application-e4357/16.1.7+/media/dfa5b301-c102-11e6-80bf-00155d62480c.png)

## Implementation Details

Inherit the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppWebSystemModuleProcessActionContainerHolderControllertopic">ProcessActionContainerHolderController</a> and override the `OnCreateCustomMenuActionItem` method and return a custom `TemplatedMenuActionItem`, that defines the Action's control. See the _MyProcessActionContainerHolderController.xx_ class code for additional details.

## Files to Review

* [MyProcessActionContainerHolderController.cs](./CS/Solution28.Module.Web/Controllers/MyProcessActionContainerHolderController.cs) (VB: [MyProcessActionContainerHolderController.vb](./VB/Solution28.Module.Web/Controllers/MyProcessActionContainerHolderController.vb))
* [ParametrizedRangeActionMenuActionItem.cs](./CS/Solution28.Module.Web/ParametrizedRangeActionMenuActionItem.cs) (VB: [ParametrizedRangeActionMenuActionItem.vb](./VB/Solution28.Module.Web/ParametrizedRangeActionMenuActionItem.vb))

## More Examples

 - [How to create a custom action type with a custom control (BarCheckItem), associated with it](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977) (WinForms)
 - [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor) (ASP.NET Core Blazor Server)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
