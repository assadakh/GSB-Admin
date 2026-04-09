Imports MySql.Data.MySqlClient

Public Class FormCreerUtilisateur

    Private Sub FormCreerUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Style formulaire ──
        Me.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Titre ──
        Dim lblTitre As New Label()
        lblTitre.Text = "➕  Créer un utilisateur"
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
        pnl.Size = New Size(500, 560)
        pnl.BackColor = Color.White
        pnl.Location = New Point((Me.ClientSize.Width - pnl.Width) \ 2, 75)
        Me.Controls.Add(pnl)

        ' ── Fonction helper pour créer un bloc label + textbox ──
        Dim posY As Integer = 20

        ' Nom
        AjouterLabel(pnl, "Nom *", 20, posY)
        StylerTextBox(txtNom, pnl, 20, posY + 22)
        posY += 70

        ' Prénom
        AjouterLabel(pnl, "Prénom *", 20, posY)
        StylerTextBox(txtPrenom, pnl, 20, posY + 22)
        posY += 70

        ' Login
        AjouterLabel(pnl, "Identifiant (login) *", 20, posY)
        StylerTextBox(txtLogin, pnl, 20, posY + 22)
        posY += 70

        ' Mot de passe
        AjouterLabel(pnl, "Mot de passe *", 20, posY)
        StylerTextBox(txtMdp, pnl, 20, posY + 22)
        txtMdp.PasswordChar = "*"c
        posY += 70

        ' Adresse + CP + Ville sur une ligne
        AjouterLabel(pnl, "Adresse", 20, posY)
        StylerTextBox(txtAdresse, pnl, 20, posY + 22, 220)
        AjouterLabel(pnl, "CP", 255, posY)
        StylerTextBox(txtCodePostal, pnl, 255, posY + 22, 80)
        AjouterLabel(pnl, "Ville", 350, posY)
        StylerTextBox(txtVille, pnl, 350, posY + 22, 130)
        posY += 70

        ' Date embauche
        AjouterLabel(pnl, "Date d'embauche", 20, posY)
        dtpEmbauche.Font = New Font("Segoe UI", 10)
        dtpEmbauche.Size = New Size(220, 30)
        dtpEmbauche.Location = New Point(20, posY + 22)
        pnl.Controls.Add(dtpEmbauche)

        ' Rôle
        AjouterLabel(pnl, "Rôle *", 260, posY)
        cmbRole.Font = New Font("Segoe UI", 10)
        cmbRole.Size = New Size(200, 30)
        cmbRole.Location = New Point(260, posY + 22)
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Visiteur")
        cmbRole.Items.Add("Comptable")
        cmbRole.SelectedIndex = 0
        pnl.Controls.Add(cmbRole)
        posY += 70

        ' Bouton valider
        btnValider.Text = "Créer l'utilisateur"
        btnValider.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnValider.Size = New Size(460, 45)
        btnValider.Location = New Point(20, posY)
        btnValider.BackColor = Color.FromArgb(31, 73, 125)
        btnValider.ForeColor = Color.White
        btnValider.FlatStyle = FlatStyle.Flat
        btnValider.FlatAppearance.BorderSize = 0
        btnValider.Cursor = Cursors.Hand
        pnl.Controls.Add(btnValider)

        pnl.BringToFront()
    End Sub

    Private Sub AjouterLabel(pnl As Panel, texte As String, x As Integer, y As Integer)
        Dim lbl As New Label()
        lbl.Text = texte
        lbl.Font = New Font("Segoe UI", 9)
        lbl.ForeColor = Color.Gray
        lbl.AutoSize = True
        lbl.Location = New Point(x, y)
        pnl.Controls.Add(lbl)
    End Sub

    Private Sub StylerTextBox(txt As TextBox, pnl As Panel, x As Integer, y As Integer, Optional largeur As Integer = 460)
        txt.Font = New Font("Segoe UI", 10)
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Size = New Size(largeur, 30)
        txt.Location = New Point(x, y)
        txt.BackColor = Color.FromArgb(245, 247, 250)
        pnl.Controls.Add(txt)
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If txtNom.Text = "" OrElse txtPrenom.Text = "" OrElse txtLogin.Text = "" OrElse txtMdp.Text = "" OrElse cmbRole.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires (*).", "Erreur",
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
                Dim cmdV As New MySqlCommand("INSERT INTO visiteur (id) VALUES (@id)", ConnexionBDD.GetConnexion())
                cmdV.Parameters.AddWithValue("@id", txtLogin.Text)
                cmdV.ExecuteNonQuery()
            Else
                Dim cmdC As New MySqlCommand("INSERT INTO comptable (id, nbFichesRefusees) VALUES (@id, 0)", ConnexionBDD.GetConnexion())
                cmdC.Parameters.AddWithValue("@id", txtLogin.Text)
                cmdC.ExecuteNonQuery()
            End If

            MessageBox.Show("Utilisateur créé avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNom.Clear() : txtPrenom.Clear() : txtLogin.Clear()
            txtMdp.Clear() : txtAdresse.Clear() : txtCodePostal.Clear() : txtVille.Clear()

        Catch ex As MySqlException
            MessageBox.Show("Erreur BDD : " & ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class