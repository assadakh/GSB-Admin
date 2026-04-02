Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerConfig()
    End Sub

    'Boutton
    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        ' Vérification du mot de passe entré comparé à celui de dans le .ini
        If HashSHA256(txtMdp.Text) = ModuleConfig.AdminPassword Then
            'Dim frmPrincipal As New FormPrincipal()
            'frmPrincipal.Show()
            'Me.Hide()
            MessageBox.Show("Le mot de passe est bon")
            txtMdp.Clear()
            txtMdp.Focus()
        Else
            MessageBox.Show("Mot de passe incorrect.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMdp.Clear()
            txtMdp.Focus()
        End If
    End Sub
End Class
