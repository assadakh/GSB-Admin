<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListeUtilisateurs
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
        Me.dgvUtilisateurs = New System.Windows.Forms.DataGridView()
        Me.lblUtilisateurs = New System.Windows.Forms.Label()
        Me.cmbFiltreRole = New System.Windows.Forms.ComboBox()
        Me.btnActualiser = New System.Windows.Forms.Button()
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUtilisateurs
        '
        Me.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUtilisateurs.Location = New System.Drawing.Point(122, 85)
        Me.dgvUtilisateurs.Name = "dgvUtilisateurs"
        Me.dgvUtilisateurs.ReadOnly = True
        Me.dgvUtilisateurs.Size = New System.Drawing.Size(1087, 465)
        Me.dgvUtilisateurs.TabIndex = 0
        '
        'lblUtilisateurs
        '
        Me.lblUtilisateurs.AutoSize = True
        Me.lblUtilisateurs.Location = New System.Drawing.Point(12, 9)
        Me.lblUtilisateurs.Name = "lblUtilisateurs"
        Me.lblUtilisateurs.Size = New System.Drawing.Size(101, 13)
        Me.lblUtilisateurs.TabIndex = 1
        Me.lblUtilisateurs.Text = "Liste des utilisateurs"
        '
        'cmbFiltreRole
        '
        Me.cmbFiltreRole.FormattingEnabled = True
        Me.cmbFiltreRole.Location = New System.Drawing.Point(122, 43)
        Me.cmbFiltreRole.Name = "cmbFiltreRole"
        Me.cmbFiltreRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltreRole.TabIndex = 2
        '
        'btnActualiser
        '
        Me.btnActualiser.Location = New System.Drawing.Point(286, 43)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(75, 23)
        Me.btnActualiser.TabIndex = 3
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = True
        '
        'FormListeUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 578)
        Me.Controls.Add(Me.btnActualiser)
        Me.Controls.Add(Me.cmbFiltreRole)
        Me.Controls.Add(Me.lblUtilisateurs)
        Me.Controls.Add(Me.dgvUtilisateurs)
        Me.Name = "FormListeUtilisateurs"
        Me.Text = "FormListeUtilisateurs"
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUtilisateurs As DataGridView
    Friend WithEvents lblUtilisateurs As Label
    Friend WithEvents cmbFiltreRole As ComboBox
    Friend WithEvents btnActualiser As Button
End Class
