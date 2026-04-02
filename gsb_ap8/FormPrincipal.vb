Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerConfig()
    End Sub

    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        Dim frm As New FormListeUtilisateurs()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RéiniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéiniToolStripMenuItem.Click
        Dim frm As New FormReinitialisationMdp()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CréerUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnUtilisateurToolStripMenuItem.Click
        Dim frm As New FormCreerUtilisateur()
        frm.MdiParent = Me
        frm.Show()
    End Sub

End Class