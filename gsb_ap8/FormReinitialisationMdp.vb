Imports MySql.Data.MySqlClient

Public Class FormReinitialisationMdp
    Private Sub FormReinitialisationMdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les utilisateurs dans le ComboBox
        Dim requete = "SELECT id, CONCAT(nom, ' ', prenom) AS nomComplet FROM utilisateur ORDER BY nom"
        Dim adapter As New MySqlDataAdapter(requete, ConnexionBDD.GetConnexion())
        Dim table As New DataTable()
        adapter.Fill(table)
        cmbUtilisateurs.DataSource = table
        cmbUtilisateurs.DisplayMember = "nomComplet"
        cmbUtilisateurs.ValueMember = "id"
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If txtNouveauMdp.Text = txtConfirmerMdp.Text Then
            Dim nouveauMdpHashe = HashSHA256(txtNouveauMdp.Text)

            Dim requete = "UPDATE utilisateur SET mdp = @mdp WHERE id = @id"
            Dim cmd As New MySqlCommand(requete, ConnexionBDD.GetConnexion())
            cmd.Parameters.AddWithValue("@mdp", nouveauMdpHashe)
            cmd.Parameters.AddWithValue("@id", cmbUtilisateurs.SelectedValue)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Mot de passe réinitialisé avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNouveauMdp.Clear()
            txtConfirmerMdp.Clear()
        Else
            MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class