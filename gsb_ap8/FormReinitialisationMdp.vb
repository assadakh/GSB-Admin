Imports MySql.Data.MySqlClient

Public Class FormReinitialisationMdp

    Private Sub FormReinitialisationMdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Style formulaire ──
        Me.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Titre ──
        Dim lblTitre As New Label()
        lblTitre.Text = "🔑  Réinitialiser un mot de passe"
        lblTitre.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitre.ForeColor = Color.FromArgb(31, 73, 125)
        lblTitre.AutoSize = True
        lblTitre.Location = New Point(20, 20)
        Me.Controls.Add(lblTitre)

        ' ── Séparateur ──
        Dim sep As New Panel()
        sep.BackColor = Color.FromArgb(31, 73, 125)
        sep.Size = New Size(400, 2)
        sep.Location = New Point(20, 55)
        Me.Controls.Add(sep)

        ' ── Panel formulaire centré ──
        Dim pnl As New Panel()
        pnl.Size = New Size(420, 340)
        pnl.BackColor = Color.White
        pnl.Location = New Point((Me.ClientSize.Width - pnl.Width) \ 2, 80)
        pnl.Padding = New Padding(30)

        ' ── Label utilisateur ──
        Dim lblUser As New Label()
        lblUser.Text = "Sélectionner un utilisateur"
        lblUser.Font = New Font("Segoe UI", 9)
        lblUser.ForeColor = Color.Gray
        lblUser.AutoSize = True
        lblUser.Location = New Point(30, 25)

        ' ── ComboBox ──
        cmbUtilisateurs.Font = New Font("Segoe UI", 10)
        cmbUtilisateurs.Size = New Size(360, 35)
        cmbUtilisateurs.Location = New Point(30, 50)

        ' ── Label nouveau mdp ──
        Dim lblNouv As New Label()
        lblNouv.Text = "Nouveau mot de passe"
        lblNouv.Font = New Font("Segoe UI", 9)
        lblNouv.ForeColor = Color.Gray
        lblNouv.AutoSize = True
        lblNouv.Location = New Point(30, 100)

        ' ── TextBox nouveau mdp ──
        txtNouveauMdp.Font = New Font("Segoe UI", 10)
        txtNouveauMdp.BorderStyle = BorderStyle.FixedSingle
        txtNouveauMdp.Size = New Size(360, 35)
        txtNouveauMdp.Location = New Point(30, 125)
        txtNouveauMdp.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Label confirmer mdp ──
        Dim lblConf As New Label()
        lblConf.Text = "Confirmer le mot de passe"
        lblConf.Font = New Font("Segoe UI", 9)
        lblConf.ForeColor = Color.Gray
        lblConf.AutoSize = True
        lblConf.Location = New Point(30, 175)

        ' ── TextBox confirmer mdp ──
        txtConfirmerMdp.Font = New Font("Segoe UI", 10)
        txtConfirmerMdp.BorderStyle = BorderStyle.FixedSingle
        txtConfirmerMdp.Size = New Size(360, 35)
        txtConfirmerMdp.Location = New Point(30, 200)
        txtConfirmerMdp.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Bouton valider ──
        btnValider.Text = "Valider"
        btnValider.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnValider.Size = New Size(360, 45)
        btnValider.Location = New Point(30, 265)
        btnValider.BackColor = Color.FromArgb(31, 73, 125)
        btnValider.ForeColor = Color.White
        btnValider.FlatStyle = FlatStyle.Flat
        btnValider.FlatAppearance.BorderSize = 0
        btnValider.Cursor = Cursors.Hand

        pnl.Controls.AddRange({lblUser, cmbUtilisateurs, lblNouv, txtNouveauMdp,
                                lblConf, txtConfirmerMdp, btnValider})
        Me.Controls.Add(pnl)
        pnl.BringToFront()

        ' ── Chargement des utilisateurs ──
        Dim requete = "SELECT id, CONCAT(nom, ' ', prenom) AS nomComplet FROM utilisateur ORDER BY nom"
        Dim adapter As New MySqlDataAdapter(requete, ConnexionBDD.GetConnexion())
        Dim table As New DataTable()
        adapter.Fill(table)
        cmbUtilisateurs.DataSource = table
        cmbUtilisateurs.DisplayMember = "nomComplet"
        cmbUtilisateurs.ValueMember = "id"
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If txtNouveauMdp.Text = "" Then
            MessageBox.Show("Veuillez saisir un mot de passe.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
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