<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReinitialisationMdp
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
        Me.cmbUtilisateurs = New System.Windows.Forms.ComboBox()
        Me.txtNouveauMdp = New System.Windows.Forms.TextBox()
        Me.txtConfirmerMdp = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbUtilisateurs
        '
        Me.cmbUtilisateurs.FormattingEnabled = True
        Me.cmbUtilisateurs.Location = New System.Drawing.Point(90, 96)
        Me.cmbUtilisateurs.Name = "cmbUtilisateurs"
        Me.cmbUtilisateurs.Size = New System.Drawing.Size(121, 21)
        Me.cmbUtilisateurs.TabIndex = 3
        '
        'txtNouveauMdp
        '
        Me.txtNouveauMdp.Location = New System.Drawing.Point(97, 188)
        Me.txtNouveauMdp.Name = "txtNouveauMdp"
        Me.txtNouveauMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNouveauMdp.Size = New System.Drawing.Size(100, 20)
        Me.txtNouveauMdp.TabIndex = 4
        '
        'txtConfirmerMdp
        '
        Me.txtConfirmerMdp.Location = New System.Drawing.Point(97, 293)
        Me.txtConfirmerMdp.Name = "txtConfirmerMdp"
        Me.txtConfirmerMdp.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmerMdp.TabIndex = 5
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(122, 360)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 6
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'FormReinitialisationMdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 450)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtConfirmerMdp)
        Me.Controls.Add(Me.txtNouveauMdp)
        Me.Controls.Add(Me.cmbUtilisateurs)
        Me.Name = "FormReinitialisationMdp"
        Me.Text = "FormReinitialisationMdp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUtilisateurs As ComboBox
    Friend WithEvents txtNouveauMdp As TextBox
    Friend WithEvents txtConfirmerMdp As TextBox
    Friend WithEvents btnValider As Button
End Class
