<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScore
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
        Me.ButtonStat = New System.Windows.Forms.Button()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.LabelMT = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ListBoxMT = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ButtonTriAlp = New System.Windows.Forms.Button()
        Me.ButtonTriScore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonStat
        '
        Me.ButtonStat.Location = New System.Drawing.Point(300, 314)
        Me.ButtonStat.Name = "ButtonStat"
        Me.ButtonStat.Size = New System.Drawing.Size(180, 23)
        Me.ButtonStat.TabIndex = 21
        Me.ButtonStat.Text = "Afficher les statistiques"
        Me.ButtonStat.UseVisualStyleBackColor = True
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(298, 265)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxNom.TabIndex = 20
        '
        'LabelMT
        '
        Me.LabelMT.AutoSize = True
        Me.LabelMT.Location = New System.Drawing.Point(474, 76)
        Me.LabelMT.Name = "LabelMT"
        Me.LabelMT.Size = New System.Drawing.Size(78, 13)
        Me.LabelMT.TabIndex = 17
        Me.LabelMT.Text = "Meilleur Temps"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(230, 76)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(32, 13)
        Me.LabelNom.TabIndex = 16
        Me.LabelNom.Text = "NOM"
        '
        'ListBoxMT
        '
        Me.ListBoxMT.FormattingEnabled = True
        Me.ListBoxMT.Location = New System.Drawing.Point(415, 99)
        Me.ListBoxMT.Name = "ListBoxMT"
        Me.ListBoxMT.Size = New System.Drawing.Size(197, 108)
        Me.ListBoxMT.TabIndex = 13
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(696, 361)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(70, 24)
        Me.ButtonRetour.TabIndex = 12
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(152, 99)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(197, 108)
        Me.ListBoxNom.TabIndex = 11
        '
        'ButtonTriAlp
        '
        Me.ButtonTriAlp.Location = New System.Drawing.Point(84, 314)
        Me.ButtonTriAlp.Name = "ButtonTriAlp"
        Me.ButtonTriAlp.Size = New System.Drawing.Size(178, 23)
        Me.ButtonTriAlp.TabIndex = 22
        Me.ButtonTriAlp.Text = "Trier par ordre alphabétique"
        Me.ButtonTriAlp.UseVisualStyleBackColor = True
        '
        'ButtonTriScore
        '
        Me.ButtonTriScore.Location = New System.Drawing.Point(519, 314)
        Me.ButtonTriScore.Name = "ButtonTriScore"
        Me.ButtonTriScore.Size = New System.Drawing.Size(180, 23)
        Me.ButtonTriScore.TabIndex = 23
        Me.ButtonTriScore.Text = "Tri par meilleur score"
        Me.ButtonTriScore.UseVisualStyleBackColor = True
        '
        'FormScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 397)
        Me.Controls.Add(Me.ButtonTriScore)
        Me.Controls.Add(Me.ButtonTriAlp)
        Me.Controls.Add(Me.ButtonStat)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabelMT)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ListBoxMT)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Name = "FormScore"
        Me.Text = "FormScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonStat As Button
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents LabelMT As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents ListBoxMT As ListBox
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ButtonTriAlp As Button
    Friend WithEvents ButtonTriScore As Button
End Class
