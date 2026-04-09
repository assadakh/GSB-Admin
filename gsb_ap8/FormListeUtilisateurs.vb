Imports MySql.Data.MySqlClient

Public Class FormListeUtilisateurs

    Private Sub FormListeUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Style formulaire ──
        Me.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Titre ──
        Dim lblTitre As New Label()
        lblTitre.Text = "👥  Liste des utilisateurs"
        lblTitre.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitre.ForeColor = Color.FromArgb(31, 73, 125)
        lblTitre.AutoSize = True
        lblTitre.Location = New Point(20, 20)
        Me.Controls.Add(lblTitre)

        ' ── Séparateur ──
        Dim sep As New Panel()
        sep.BackColor = Color.FromArgb(31, 73, 125)
        sep.Size = New Size(Me.ClientSize.Width - 40, 2)
        sep.Location = New Point(20, 55)
        Me.Controls.Add(sep)

        ' ── Style DataGridView ──
        dgvUtilisateurs.BackgroundColor = Color.White
        dgvUtilisateurs.BorderStyle = BorderStyle.None
        dgvUtilisateurs.Font = New Font("Segoe UI", 10)
        dgvUtilisateurs.RowHeadersVisible = False
        dgvUtilisateurs.EnableHeadersVisualStyles = False
        dgvUtilisateurs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 73, 125)
        dgvUtilisateurs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvUtilisateurs.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvUtilisateurs.ColumnHeadersHeight = 40
        dgvUtilisateurs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 114, 196)
        dgvUtilisateurs.DefaultCellStyle.SelectionForeColor = Color.White
        dgvUtilisateurs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 250)
        dgvUtilisateurs.RowTemplate.Height = 35
        dgvUtilisateurs.Location = New Point(20, 70)
        dgvUtilisateurs.Size = New Size(Me.ClientSize.Width - 40, Me.ClientSize.Height - 130)
        dgvUtilisateurs.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom

        ' ── Style ComboBox filtre ──
        cmbFiltreRole.Font = New Font("Segoe UI", 10)
        cmbFiltreRole.Location = New Point(20, Me.ClientSize.Height - 50)
        cmbFiltreRole.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cmbFiltreRole.Items.Clear()
        cmbFiltreRole.Items.AddRange({"Tous", "Visiteur", "Comptable"})
        cmbFiltreRole.SelectedIndex = 0

        ' ── Style bouton Actualiser ──
        btnActualiser.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnActualiser.BackColor = Color.FromArgb(31, 73, 125)
        btnActualiser.ForeColor = Color.White
        btnActualiser.FlatStyle = FlatStyle.Flat
        btnActualiser.FlatAppearance.BorderSize = 0
        btnActualiser.Size = New Size(120, 35)
        btnActualiser.Location = New Point(180, Me.ClientSize.Height - 53)
        btnActualiser.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnActualiser.Cursor = Cursors.Hand

        ChargerUtilisateurs()
    End Sub

    Private Sub ChargerUtilisateurs()
        Try
            Dim filtre = If(cmbFiltreRole.SelectedItem = "Tous" OrElse cmbFiltreRole.SelectedItem Is Nothing, "", cmbFiltreRole.SelectedItem.ToString())

            Dim requete = "SELECT u.id, u.nom, u.prenom, u.login,
                            IF(c.id IS NOT NULL, 'Comptable', 'Visiteur') AS role
                           FROM utilisateur u
                           LEFT JOIN comptable c ON c.id = u.id"

            If filtre <> "" Then
                If filtre = "Comptable" Then
                    requete &= " WHERE c.id IS NOT NULL"
                Else
                    requete &= " WHERE c.id IS NULL"
                End If
            End If

            requete &= " ORDER BY u.nom"

            Dim adapter As New MySqlDataAdapter(requete, ConnexionBDD.GetConnexion())
            Dim table As New DataTable()
            adapter.Fill(table)
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

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        ChargerUtilisateurs()
    End Sub

End Class