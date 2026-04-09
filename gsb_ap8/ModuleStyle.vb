Module ModuleStyle

    ' ── Palette de couleurs ──
    Public ReadOnly CouleurPrimaire As Color = Color.FromArgb(31, 73, 125)    ' Bleu foncé
    Public ReadOnly CouleurSecondaire As Color = Color.FromArgb(68, 114, 196) ' Bleu moyen
    Public ReadOnly CouleurFond As Color = Color.FromArgb(245, 247, 250)      ' Gris très clair
    Public ReadOnly CouleurTexte As Color = Color.FromArgb(30, 30, 30)        ' Quasi noir
    Public ReadOnly CouleurBouton As Color = Color.FromArgb(31, 73, 125)      ' Bleu foncé
    Public ReadOnly CouleurBoutonTexte As Color = Color.White

    ' ── Police ──
    Public ReadOnly PoliceNormale As New Font("Segoe UI", 10)
    Public ReadOnly PoliceTitre As New Font("Segoe UI", 14, FontStyle.Bold)
    Public ReadOnly PoliceBouton As New Font("Segoe UI", 10, FontStyle.Bold)

    ' ── Appliquer le style à un formulaire ──
    Public Sub AppliquerStyleFormulaire(frm As Form)
        frm.BackColor = CouleurFond
        frm.Font = PoliceNormale
        frm.ForeColor = CouleurTexte
    End Sub

    ' ── Appliquer le style à un bouton ──
    Public Sub AppliquerStyleBouton(btn As Button)
        btn.BackColor = CouleurBouton
        btn.ForeColor = CouleurBoutonTexte
        btn.Font = PoliceBouton
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Height = 35
    End Sub

    ' ── Appliquer le style à un TextBox ──
    Public Sub AppliquerStyleTextBox(txt As TextBox)
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Font = PoliceNormale
        txt.BackColor = Color.White
        txt.Height = 30
    End Sub

    ' ── Appliquer le style à un Label titre ──
    Public Sub AppliquerStyleTitre(lbl As Label)
        lbl.Font = PoliceTitre
        lbl.ForeColor = CouleurPrimaire
    End Sub

    ' ── Appliquer le style au DataGridView ──
    Public Sub AppliquerStyleDataGridView(dgv As DataGridView)
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.DefaultCellStyle.Font = PoliceNormale
        dgv.DefaultCellStyle.SelectionBackColor = CouleurSecondaire
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.BackColor = CouleurPrimaire
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = PoliceBouton
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 250)
    End Sub

End Module