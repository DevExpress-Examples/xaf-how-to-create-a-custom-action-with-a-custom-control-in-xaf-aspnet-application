Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Xpo

Namespace Solution28.Web

    Public Partial Class Solution28AspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule

        Private module3 As [Module].Solution28Module

        Private module4 As [Module].Web.Solution28AspNetModule

        Private sqlConnection1 As Data.SqlClient.SqlConnection

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProviderThreadSafe(args.ConnectionString, args.Connection)
        End Sub

        Private Sub Solution28AspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
#If EASYTEST
			e.Updater.Update();
			e.Handled = true;
#Else
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Dim message As String = "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Microsoft.VisualBasic.Constants.vbCrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Microsoft.VisualBasic.Constants.vbCrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & Microsoft.VisualBasic.Constants.vbCrLf & "Anyway, refer to the following help topics for more detailed information:" & Microsoft.VisualBasic.Constants.vbCrLf & "'Update Application and Database Versions' at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm" & Microsoft.VisualBasic.Constants.vbCrLf & "'Database Security References' at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument3237.htm" & Microsoft.VisualBasic.Constants.vbCrLf & "If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/"
                If e.CompatibilityError IsNot Nothing AndAlso e.CompatibilityError.Exception IsNot Nothing Then
                    message += Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "Inner exception: " & e.CompatibilityError.Exception.Message
                End If

                Throw New InvalidOperationException(message)
            End If
#End If
        End Sub

        Private Sub InitializeComponent()
            module1 = New SystemModule.SystemModule()
            module2 = New SystemModule.SystemAspNetModule()
            module3 = New [Module].Solution28Module()
            module4 = New [Module].Web.Solution28AspNetModule()
            sqlConnection1 = New Data.SqlClient.SqlConnection()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            sqlConnection1.ConnectionString = ""
            sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' Solution28AspNetApplication
            ' 
            ApplicationName = "Solution28"
            Connection = sqlConnection1
            Modules.Add(module1)
            Modules.Add(module2)
            Modules.Add(module3)
            Modules.Add(module4)
            AddHandler DatabaseVersionMismatch, New EventHandler(Of DatabaseVersionMismatchEventArgs)(AddressOf Solution28AspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
