Public Class FormAccueil

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerStyleFormulaire(Me)
        Me.ControlBox = False  ' pas de bouton fermer sur l'accueil
        CreerInterface()
    End Sub

    Private Sub CreerInterface()
        ' Titre
        Dim lblTitre As New Label()
        lblTitre.Text = "GSB-Admin"
        lblTitre.Font = New Font("Segoe UI", 32, FontStyle.Bold)
        lblTitre.ForeColor = ModuleStyle.CouleurPrimaire
        lblTitre.AutoSize = True
        lblTitre.Left = (Me.ClientSize.Width - lblTitre.PreferredWidth) \ 2
        lblTitre.Top = 80

        ' Sous-titre
        Dim lblSub As New Label()
        lblSub.Text = "Gestion des utilisateurs — Laboratoire Galaxy Swiss Bourdin"
        lblSub.Font = New Font("Segoe UI", 11)
        lblSub.ForeColor = Color.Gray
        lblSub.AutoSize = True
        lblSub.Left = (Me.ClientSize.Width - lblSub.PreferredWidth) \ 2
        lblSub.Top = 140

        ' Ligne de séparation
        Dim sep As New Panel()
        sep.BackColor = ModuleStyle.CouleurSecondaire
        sep.Height = 2
        sep.Width = 400
        sep.Left = (Me.ClientSize.Width - sep.Width) \ 2
        sep.Top = 185

        ' Boutons
        Dim btnListe As New Button()
        btnListe.Text = "👥  Liste des utilisateurs"
        btnListe.Size = New Size(230, 90)
        btnListe.Tag = "liste"
        AppliquerStyleBoutonAccueil(btnListe)

        Dim btnReinit As New Button()
        btnReinit.Text = "🔑  Réinitialiser" & vbCrLf & "un mot de passe"
        btnReinit.Size = New Size(230, 90)
        btnReinit.Tag = "reinit"
        AppliquerStyleBoutonAccueil(btnReinit)

        Dim btnCreer As New Button()
        btnCreer.Text = "➕  Créer un utilisateur"
        btnCreer.Size = New Size(230, 90)
        btnCreer.Tag = "creer"
        AppliquerStyleBoutonAccueil(btnCreer)

        ' Centrer les 3 boutons
        Dim totalW = btnListe.Width * 3 + 40
        Dim startX = (Me.ClientSize.Width - totalW) \ 2
        btnListe.Left = startX
        btnReinit.Left = startX + btnListe.Width + 20
        btnCreer.Left = startX + btnListe.Width * 2 + 40
        btnListe.Top = 230
        btnReinit.Top = 230
        btnCreer.Top = 230

        Me.Controls.AddRange({lblTitre, lblSub, sep, btnListe, btnReinit, btnCreer})
    End Sub

    Private Sub AppliquerStyleBoutonAccueil(btn As Button)
        btn.BackColor = ModuleStyle.CouleurPrimaire
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        AddHandler btn.Click, AddressOf BoutonClick
    End Sub

    Private Sub BoutonClick(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        Dim parent = CType(Me.MdiParent, FormPrincipal)
        Select Case btn.Tag
            Case "liste"
                parent.OuvrirFormulaire(New FormListeUtilisateurs())
            Case "reinit"
                parent.OuvrirFormulaire(New FormReinitialisationMdp())
            Case "creer"
                parent.OuvrirFormulaire(New FormCreerUtilisateur())
        End Select
    End Sub

End Class