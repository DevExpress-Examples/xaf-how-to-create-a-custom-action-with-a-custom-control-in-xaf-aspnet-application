Imports System
Imports System.Data
Imports DevExpress.Xpo.DB
Imports System.Runtime.InteropServices

Namespace E2813.Demo.Web

'#Region "For demo purposes only!!!"
    Public Class CodeCentralExampleInMemoryDataStoreProvider

        Private Shared ReadOnly fConnectionString As String

        Private Shared ReadOnly fdataSet As DataSet

        Public Shared ReadOnly Property ConnectionString As String
            Get
                Return fConnectionString
            End Get
        End Property

        Shared Sub New()
            Dim providerKey As String = Guid.NewGuid().ToString()
            fConnectionString = String.Format("XpoProvider={0}", providerKey)
            fdataSet = New DataSet()
            Call DataStoreBase.RegisterDataStoreProvider(providerKey, New Helpers.DataStoreCreationFromStringDelegate(AddressOf CreateProviderFromString))
        End Sub

        Public Shared Function CreateProviderFromString(ByVal connectionString As String, ByVal autoCreateOption As AutoCreateOption, <Out> ByRef objectsToDisposeOnDisconnect As IDisposable()) As IDataStore
            objectsToDisposeOnDisconnect = New IDisposable() {}
            Return New DataSetDataStore(fdataSet, autoCreateOption)
        End Function
    End Class
'#End Region
End Namespace
