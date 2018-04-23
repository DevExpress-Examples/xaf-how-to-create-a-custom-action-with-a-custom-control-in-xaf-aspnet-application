Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Web.SystemModule
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers.Menu

Namespace Solution28.Module.Web.Controllers
    Public Class MyProcessActionContainerHolderController
        Inherits ProcessActionContainerHolderController

        Protected Overrides Function OnCreateCustomMenuActionItem(ByVal action As ActionBase) As MenuActionItemBase
            If action.Id = "FilterRange" Then
                Return New ParametrizedRangeActionMenuActionItem(CType(action, ParametrizedAction))
            End If
            Return Nothing
        End Function
    End Class
End Namespace
