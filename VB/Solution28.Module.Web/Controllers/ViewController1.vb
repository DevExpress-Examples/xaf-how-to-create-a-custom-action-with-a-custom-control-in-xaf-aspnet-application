Imports System.ComponentModel
Imports System.Diagnostics
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Data.Filtering

Namespace Solution28.Module.Web

    Public Class ViewController1
        Inherits ViewController

        Public Sub New()
            Dim filterAction As ParametrizedRangeAction = New ParametrizedRangeAction(Me, "FilterRange", "Unspecified", GetType(Date))
            AddHandler filterAction.Execute, New ParametrizedActionExecuteEventHandler(AddressOf filterAction_Execute)
        End Sub

        Private Sub filterAction_Execute(ByVal sender As Object, ByVal e As ParametrizedActionExecuteEventArgs)
            Dim range As Web.Range(Of Date) = CType(e.ParameterCurrentValue, Web.Range(Of Date))
            CType(View, ListView).CollectionSource.Criteria("By Date") = CriteriaOperator.Parse("[Date] <= ? AND [Date] >= ?", range.To, range.From)
        End Sub
    End Class
End Namespace
