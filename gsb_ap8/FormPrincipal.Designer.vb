<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerUnUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilisateursToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1361, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UtilisateursToolStripMenuItem
        '
        Me.UtilisateursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesUtilisateursToolStripMenuItem, Me.RéiniToolStripMenuItem, Me.CréerUnUtilisateurToolStripMenuItem})
        Me.UtilisateursToolStripMenuItem.Name = "UtilisateursToolStripMenuItem"
        Me.UtilisateursToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.UtilisateursToolStripMenuItem.Text = "Utilisateurs"
        '
        'ListeDesUtilisateursToolStripMenuItem
        '
        Me.ListeDesUtilisateursToolStripMenuItem.Name = "ListeDesUtilisateursToolStripMenuItem"
        Me.ListeDesUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ListeDesUtilisateursToolStripMenuItem.Text = "Liste des utilisateurs"
        '
        'RéiniToolStripMenuItem
        '
        Me.RéiniToolStripMenuItem.Name = "RéiniToolStripMenuItem"
        Me.RéiniToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.RéiniToolStripMenuItem.Text = "Réinitialiser un mot de passe"
        '
        'CréerUnUtilisateurToolStripMenuItem
        '
        Me.CréerUnUtilisateurToolStripMenuItem.Name = "CréerUnUtilisateurToolStripMenuItem"
        Me.CréerUnUtilisateurToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CréerUnUtilisateurToolStripMenuItem.Text = "Créer un utilisateur"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1361, 584)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UtilisateursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesUtilisateursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RéiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerUnUtilisateurToolStripMenuItem As ToolStripMenuItem
End Class
