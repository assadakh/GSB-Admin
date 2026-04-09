<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreerUtilisateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.dtpEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(87, 32)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Text = "Nom"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(87, 86)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 1
        Me.txtPrenom.Text = "Prénom"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(87, 147)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 2
        Me.txtLogin.Text = "Identifiant"
        '
        'txtMdp
        '
        Me.txtMdp.Location = New System.Drawing.Point(87, 207)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(100, 20)
        Me.txtMdp.TabIndex = 3
        Me.txtMdp.Text = "Mot de passe"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(87, 257)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 4
        Me.txtAdresse.Text = "Adresse"
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(87, 303)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePostal.TabIndex = 5
        Me.txtCodePostal.Text = "Code Postal"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(87, 343)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 6
        Me.txtVille.Text = "Ville"
        '
        'dtpEmbauche
        '
        Me.dtpEmbauche.Location = New System.Drawing.Point(87, 406)
        Me.dtpEmbauche.Name = "dtpEmbauche"
        Me.dtpEmbauche.Size = New System.Drawing.Size(200, 20)
        Me.dtpEmbauche.TabIndex = 7
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(87, 467)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbRole.TabIndex = 8
        Me.cmbRole.Text = "Rôle"
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(87, 525)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 9
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'FormCreerUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 608)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.dtpEmbauche)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtMdp)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "FormCreerUtilisateur"
        Me.Text = "FormCreerUtilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents dtpEmbauche As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnValider As Button
End Class
