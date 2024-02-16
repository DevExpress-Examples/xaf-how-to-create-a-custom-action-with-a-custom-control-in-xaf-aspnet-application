Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports Solution28.Module.BusinessObjects

Namespace Solution28.Module.DatabaseUpdate

    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            If ObjectSpace.FindObject(Of DomainObject1)(Nothing) Is Nothing Then
                Dim dt As Date = Date.Today.AddDays(-10)
                For i As Integer = 1 To 30 - 1
                    Dim obj As DomainObject1 = ObjectSpace.CreateObject(Of DomainObject1)()
                    obj.Name = String.Format("sample{0:d3}", i)
                    obj.Date = dt.AddDays(i)
                Next
            End If
        End Sub
    End Class
End Namespace
