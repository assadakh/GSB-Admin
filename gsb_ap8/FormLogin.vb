Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerConfig()

        ' ── Formulaire plein écran ──
        Me.Text = "GSB-Admin"
        Me.BackColor = Color.FromArgb(31, 73, 125)
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized

        ' ── Panel blanc centré (après maximized pour bon calcul) ──
        Dim pnl As New Panel()
        pnl.Size = New Size(360, 400)
        pnl.BackColor = Color.White
        pnl.Left = (Me.ClientSize.Width - pnl.Width) \ 2
        pnl.Top = (Me.ClientSize.Height - pnl.Height) \ 2

        ' ── Logo / Titre ──
        Dim lblLogo As New Label()
        lblLogo.Text = "GSB"
        lblLogo.Font = New Font("Segoe UI", 36, FontStyle.Bold)
        lblLogo.ForeColor = Color.FromArgb(31, 73, 125)
        lblLogo.AutoSize = True
        lblLogo.Left = (pnl.Width - lblLogo.PreferredWidth) \ 2
        lblLogo.Top = 30

        ' ── Sous-titre ──
        Dim lblSub As New Label()
        lblSub.Text = "Administration"
        lblSub.Font = New Font("Segoe UI", 11)
        lblSub.ForeColor = Color.Gray
        lblSub.AutoSize = True
        lblSub.Left = (pnl.Width - lblSub.PreferredWidth) \ 2
        lblSub.Top = 90

        ' ── Séparateur ──
        Dim sep As New Panel()
        sep.BackColor = Color.FromArgb(31, 73, 125)
        sep.Size = New Size(60, 3)
        sep.Left = (pnl.Width - sep.Width) \ 2
        sep.Top = 125

        ' ── Label mot de passe ──
        Dim lblMdp As New Label()
        lblMdp.Text = "Mot de passe"
        lblMdp.Font = New Font("Segoe UI", 9)
        lblMdp.ForeColor = Color.Gray
        lblMdp.AutoSize = True
        lblMdp.Left = 40
        lblMdp.Top = 160

        ' ── TextBox mot de passe ──
        txtMdp.PasswordChar = "*"c
        txtMdp.Font = New Font("Segoe UI", 11)
        txtMdp.BorderStyle = BorderStyle.FixedSingle
        txtMdp.Size = New Size(280, 35)
        txtMdp.Left = 40
        txtMdp.Top = 185
        txtMdp.BackColor = Color.FromArgb(245, 247, 250)

        ' ── Bouton connexion ──
        btnConnexion.Text = "Se connecter"
        btnConnexion.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnConnexion.Size = New Size(280, 45)
        btnConnexion.Left = 40
        btnConnexion.Top = 255
        btnConnexion.BackColor = Color.FromArgb(31, 73, 125)
        btnConnexion.ForeColor = Color.White
        btnConnexion.FlatStyle = FlatStyle.Flat
        btnConnexion.FlatAppearance.BorderSize = 0
        btnConnexion.Cursor = Cursors.Hand

        ' ── Copyright ──
        Dim lblCopy As New Label()
        lblCopy.Text = "© 2026 Galaxy Swiss Bourdin"
        lblCopy.Font = New Font("Segoe UI", 8)
        lblCopy.ForeColor = Color.Gray
        lblCopy.AutoSize = True
        lblCopy.Left = (pnl.Width - lblCopy.PreferredWidth) \ 2
        lblCopy.Top = 340

        ' ── Ajout des contrôles ──
        pnl.Controls.AddRange({lblLogo, lblSub, sep, lblMdp, txtMdp, btnConnexion, lblCopy})
        Me.Controls.Add(pnl)
        pnl.BringToFront()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        If HashSHA256(txtMdp.Text) = ModuleConfig.AdminPassword Then
            Dim frmPrincipal As New FormPrincipal()
            frmPrincipal.Show()
            Me.Hide()
            txtMdp.Clear()
        Else
            MessageBox.Show("Mot de passe incorrect.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMdp.Clear()
            txtMdp.Focus()
        End If
    End Sub

End Class