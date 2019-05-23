<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPartie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelCompteur = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LabelMeilleurTemps = New System.Windows.Forms.Label()
        Me.ButtonWin = New System.Windows.Forms.Button()
        Me.LabelMT = New System.Windows.Forms.Label()
        Me.ButtonVerif = New System.Windows.Forms.Button()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(77, 32)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(76, 18)
        Me.LabelNom.TabIndex = 135
        Me.LabelNom.Text = "LabelNom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Nom :"
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.Location = New System.Drawing.Point(466, 500)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAbandon.TabIndex = 137
        Me.ButtonAbandon.Text = "Abandonner"
        Me.ButtonAbandon.UseVisualStyleBackColor = True
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps.Location = New System.Drawing.Point(324, 31)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(111, 18)
        Me.LabelTemps.TabIndex = 138
        Me.LabelTemps.Text = "Temps restant :"
        '
        'LabelCompteur
        '
        Me.LabelCompteur.AutoEllipsis = True
        Me.LabelCompteur.AutoSize = True
        Me.LabelCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompteur.Location = New System.Drawing.Point(434, 31)
        Me.LabelCompteur.Name = "LabelCompteur"
        Me.LabelCompteur.Size = New System.Drawing.Size(89, 18)
        Me.LabelCompteur.TabIndex = 139
        Me.LabelCompteur.Text = "LabelTemps"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'LabelMeilleurTemps
        '
        Me.LabelMeilleurTemps.AutoSize = True
        Me.LabelMeilleurTemps.Location = New System.Drawing.Point(116, 505)
        Me.LabelMeilleurTemps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMeilleurTemps.Name = "LabelMeilleurTemps"
        Me.LabelMeilleurTemps.Size = New System.Drawing.Size(101, 13)
        Me.LabelMeilleurTemps.TabIndex = 140
        Me.LabelMeilleurTemps.Text = "LabelMeilleurTemps"
        '
        'ButtonWin
        '
        Me.ButtonWin.Location = New System.Drawing.Point(385, 500)
        Me.ButtonWin.Name = "ButtonWin"
        Me.ButtonWin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWin.TabIndex = 141
        Me.ButtonWin.Text = "Win"
        Me.ButtonWin.UseVisualStyleBackColor = True
        '
        'LabelMT
        '
        Me.LabelMT.AutoSize = True
        Me.LabelMT.Location = New System.Drawing.Point(3, 505)
        Me.LabelMT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMT.Name = "LabelMT"
        Me.LabelMT.Size = New System.Drawing.Size(107, 13)
        Me.LabelMT.TabIndex = 142
        Me.LabelMT.Text = "Votre meilleur temps :"
        '
        'ButtonVerif
        '
        Me.ButtonVerif.Location = New System.Drawing.Point(302, 500)
        Me.ButtonVerif.Name = "ButtonVerif"
        Me.ButtonVerif.Size = New System.Drawing.Size(75, 23)
        Me.ButtonVerif.TabIndex = 143
        Me.ButtonVerif.Text = "Vérification"
        Me.ButtonVerif.UseVisualStyleBackColor = True
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(221, 500)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPause.TabIndex = 144
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'FormPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 535)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.ButtonVerif)
        Me.Controls.Add(Me.LabelMT)
        Me.Controls.Add(Me.ButtonWin)
        Me.Controls.Add(Me.LabelMeilleurTemps)
        Me.Controls.Add(Me.LabelCompteur)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNom)
        Me.Name = "FormPartie"
        Me.Text = "FormPartie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelCompteur As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LabelMeilleurTemps As Label
    Friend WithEvents ButtonWin As Button
    Friend WithEvents LabelMT As Label
    Friend WithEvents ButtonVerif As Button
    Friend WithEvents ButtonPause As Button
End Class
