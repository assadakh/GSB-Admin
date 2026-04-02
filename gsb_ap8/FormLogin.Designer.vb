<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Location = New System.Drawing.Point(377, 333)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(77, 13)
        Me.lblMdp.TabIndex = 0
        Me.lblMdp.Text = "Mot de passe :"
        '
        'txtMdp
        '
        Me.txtMdp.Location = New System.Drawing.Point(496, 330)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(100, 20)
        Me.txtMdp.TabIndex = 1
        '
        'btnConnexion
        '
        Me.btnConnexion.Location = New System.Drawing.Point(651, 333)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(105, 23)
        Me.btnConnexion.TabIndex = 2
        Me.btnConnexion.Text = "Se connecter"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 659)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.txtMdp)
        Me.Controls.Add(Me.lblMdp)
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMdp As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents btnConnexion As Button
End Class
