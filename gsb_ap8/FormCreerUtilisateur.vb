Imports MySql.Data.MySqlClient

Public Class FormCreerUtilisateur
    Private Sub FormCreerUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("Visiteur")
        cmbRole.Items.Add("Comptable")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        ' Vérification des champs obligatoires
        If txtLogin.Text = "" OrElse txtNom.Text = "" OrElse txtPrenom.Text = "" OrElse txtLogin.Text = "" OrElse txtMdp.Text = "" OrElse cmbRole.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim mdpHash = HashSHA256(txtMdp.Text)

            Dim requete = "INSERT INTO utilisateur (id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES (@id, @nom, @prenom, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche)"
            Dim cmd As New MySqlCommand(requete, ConnexionBDD.GetConnexion())
            cmd.Parameters.AddWithValue("@id", txtLogin.Text)
            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@login", txtLogin.Text)
            cmd.Parameters.AddWithValue("@mdp", mdpHash)
            cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text)
            cmd.Parameters.AddWithValue("@cp", txtCodePostal.Text)
            cmd.Parameters.AddWithValue("@ville", txtVille.Text)
            cmd.Parameters.AddWithValue("@dateEmbauche", dtpEmbauche.Value)
            cmd.ExecuteNonQuery()

            If cmbRole.Text = "Visiteur" Then
                Dim requeteVisiteur = "INSERT INTO visiteur (id) VALUES (@id)"
                Dim cmdVisiteur As New MySqlCommand(requeteVisiteur, ConnexionBDD.GetConnexion())
                cmdVisiteur.Parameters.AddWithValue("@id", txtLogin.Text)
                cmdVisiteur.ExecuteNonQuery()
            Else
                Dim requeteComptable = "INSERT INTO comptable (id, nbFichesRefusees) VALUES (@id, 0)"
                Dim cmdComptable As New MySqlCommand(requeteComptable, ConnexionBDD.GetConnexion())
                cmdComptable.Parameters.AddWithValue("@id", txtLogin.Text)
                cmdComptable.ExecuteNonQuery()
            End If

            MessageBox.Show("Utilisateur créé avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Vider les champs
            txtLogin.Clear()
            txtNom.Clear()
            txtPrenom.Clear()
            txtLogin.Clear()
            txtMdp.Clear()
            txtAdresse.Clear()
            txtCodePostal.Clear()
            txtVille.Clear()

        Catch ex As MySqlException
            ' Erreur SQL
            MessageBox.Show("Erreur BDD : " & ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class