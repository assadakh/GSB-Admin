Imports MySql.Data.MySqlClient

Public Class FormListeUtilisateurs
    Private Sub FormListeUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerUtilisateurs()
    End Sub

    Private Sub ChargerUtilisateurs()
        Try
            Dim requete = "SELECT u.id, u.nom, u.prenom, u.login,
                        IF(c.id IS NOT NULL, 'Comptable', 'Visiteur') AS role
                       FROM utilisateur u
                       LEFT JOIN comptable c ON c.id = u.id
                       ORDER BY u.nom"
            Dim adapter As New MySqlDataAdapter(requete, ConnexionBDD.GetConnexion())
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Renommage des colonnes
            table.Columns("id").ColumnName = "ID"
            table.Columns("nom").ColumnName = "Nom"
            table.Columns("prenom").ColumnName = "Prénom"
            table.Columns("login").ColumnName = "Login"
            table.Columns("role").ColumnName = "Rôle"


            dgvUtilisateurs.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub
End Class