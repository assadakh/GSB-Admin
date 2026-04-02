Imports MySql.Data.MySqlClient

Public Class ConnexionBDD

    Private Shared _connexion As MySqlConnection

    Public Shared Function GetConnexion() As MySqlConnection
        If _connexion Is Nothing Then
            _connexion = New MySqlConnection(ModuleConfig.GetConnectionString())
        End If
        If _connexion.State = ConnectionState.Closed Then
            _connexion.Open()
        End If
        Return _connexion
    End Function

End Class