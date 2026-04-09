Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Formulaire ──
        Me.Text = "GSB-Admin"
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(245, 247, 250)
        MenuStrip1.BackColor = Color.FromArgb(31, 73, 125)
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 10)

        ' ── Barre latérale gauche ──
        Dim sidebar As New Panel()
        sidebar.Width = 220
        sidebar.Dock = DockStyle.Left
        sidebar.BackColor = Color.FromArgb(31, 73, 125)

        ' ── Logo dans la sidebar ──
        Dim lblLogo As New Label()
        lblLogo.Text = "GSB"
        lblLogo.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        lblLogo.ForeColor = Color.White
        lblLogo.AutoSize = True
        lblLogo.Left = (sidebar.Width - lblLogo.PreferredWidth) \ 2
        lblLogo.Top = 20

        Dim lblSub As New Label()
        lblSub.Text = "Administration"
        lblSub.Font = New Font("Segoe UI", 9)
        lblSub.ForeColor = Color.FromArgb(180, 200, 230)
        lblSub.AutoSize = True
        lblSub.Left = (sidebar.Width - lblSub.PreferredWidth) \ 2
        lblSub.Top = 75

        ' ── Séparateur ──
        Dim sep As New Panel()
        sep.BackColor = Color.FromArgb(68, 114, 196)
        sep.Size = New Size(180, 1)
        sep.Left = 20
        sep.Top = 105

        ' ── Boutons sidebar ──
        Dim btnListe As New Button()
        btnListe.Text = "👥   Liste des utilisateurs"
        btnListe.Size = New Size(220, 50)
        btnListe.Left = 0
        btnListe.Top = 130
        btnListe.Tag = "liste"
        AppliquerStyleSidebar(btnListe)

        Dim btnReinit As New Button()
        btnReinit.Text = "🔑   Réinitialiser un mot de passe"
        btnReinit.Size = New Size(220, 50)
        btnReinit.Left = 0
        btnReinit.Top = 190
        btnReinit.Tag = "reinit"
        AppliquerStyleSidebar(btnReinit)

        Dim btnCreer As New Button()
        btnCreer.Text = "➕   Créer un utilisateur"
        btnCreer.Size = New Size(220, 50)
        btnCreer.Left = 0
        btnCreer.Top = 250
        btnCreer.Tag = "creer"
        AppliquerStyleSidebar(btnCreer)

        ' ── Bouton déconnexion ──
        Dim btnDeconnexion As New Button()
        btnDeconnexion.Text = "🚪   Se déconnecter"
        btnDeconnexion.Size = New Size(220, 50)
        btnDeconnexion.Left = 0
        btnDeconnexion.Top = 330
        btnDeconnexion.BackColor = Color.FromArgb(180, 30, 30)  ' rouge foncé
        btnDeconnexion.ForeColor = Color.White
        btnDeconnexion.Font = New Font("Segoe UI", 10)
        btnDeconnexion.FlatStyle = FlatStyle.Flat
        btnDeconnexion.FlatAppearance.BorderSize = 0
        btnDeconnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnDeconnexion.TextAlign = ContentAlignment.MiddleLeft
        btnDeconnexion.Padding = New Padding(15, 0, 0, 0)
        btnDeconnexion.Cursor = Cursors.Hand
        AddHandler btnDeconnexion.Click, AddressOf BoutonDeconnexion_Click

        sidebar.Controls.Add(btnDeconnexion)

        ' ── Version en bas de sidebar ──
        Dim lblVersion As New Label()
        lblVersion.Text = "© 2026 GSB"
        lblVersion.Font = New Font("Segoe UI", 8)
        lblVersion.ForeColor = Color.FromArgb(150, 180, 220)
        lblVersion.AutoSize = True
        lblVersion.Left = (sidebar.Width - lblVersion.PreferredWidth) \ 2
        lblVersion.Dock = DockStyle.Bottom

        sidebar.Controls.AddRange({lblLogo, lblSub, sep, btnListe, btnReinit, btnCreer, lblVersion})
        Me.Controls.Add(sidebar)
        sidebar.BringToFront()

        ' ── Ouvrir la liste des utilisateurs par défaut ──
        Dim frmListe As New FormListeUtilisateurs()
        frmListe.MdiParent = Me
        frmListe.WindowState = FormWindowState.Maximized
        frmListe.Show()
    End Sub

    Private Sub AppliquerStyleSidebar(btn As Button)
        btn.BackColor = Color.FromArgb(31, 73, 125)
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 10)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 114, 196)
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(15, 0, 0, 0)
        btn.Cursor = Cursors.Hand
        AddHandler btn.Click, AddressOf BoutonSidebar_Click
    End Sub

    Private Sub BoutonSidebar_Click(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        Dim frm As Form

        Select Case btn.Tag
            Case "liste"
                frm = New FormListeUtilisateurs()
            Case "reinit"
                frm = New FormReinitialisationMdp()
            Case Else
                frm = New FormCreerUtilisateur()
        End Select

        ' Fermer les formulaires enfants déjà ouverts
        For Each enfant As Form In Me.MdiChildren
            enfant.Close()
        Next

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    ' Bouton de déconnexion 
    Private Sub BoutonDeconnexion_Click(sender As Object, e As EventArgs)
        Dim confirmation = MessageBox.Show(
        "Voulez-vous vraiment vous déconnecter ?",
        "Déconnexion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Fermer tous les formulaires enfants
            For Each enfant As Form In Me.MdiChildren
                enfant.Close()
            Next
            ' Réafficher le formulaire de connexion
            Dim frmLogin As New FormLogin()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    ' ── Actions du menu strip (conservé) ──
    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        Dim frm As New FormListeUtilisateurs()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub RéiniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéiniToolStripMenuItem.Click
        Dim frm As New FormReinitialisationMdp()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub CréerUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnUtilisateurToolStripMenuItem.Click
        Dim frm As New FormCreerUtilisateur()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

End Class