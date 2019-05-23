<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParam
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton20m = New System.Windows.Forms.RadioButton()
        Me.RadioButton5m = New System.Windows.Forms.RadioButton()
        Me.RadioButton10m = New System.Windows.Forms.RadioButton()
        Me.RadioButton15m = New System.Windows.Forms.RadioButton()
        Me.RadioButton1m = New System.Windows.Forms.RadioButton()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personalisation de partie"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton20m)
        Me.Panel1.Controls.Add(Me.RadioButton5m)
        Me.Panel1.Controls.Add(Me.RadioButton10m)
        Me.Panel1.Controls.Add(Me.RadioButton15m)
        Me.Panel1.Controls.Add(Me.RadioButton1m)
        Me.Panel1.Controls.Add(Me.LabelTemps)
        Me.Panel1.Location = New System.Drawing.Point(22, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 216)
        Me.Panel1.TabIndex = 1
        '
        'RadioButton20m
        '
        Me.RadioButton20m.AutoSize = True
        Me.RadioButton20m.Location = New System.Drawing.Point(22, 33)
        Me.RadioButton20m.Name = "RadioButton20m"
        Me.RadioButton20m.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton20m.TabIndex = 5
        Me.RadioButton20m.TabStop = True
        Me.RadioButton20m.Text = "20 minutes (Très facile)"
        Me.RadioButton20m.UseVisualStyleBackColor = True
        '
        'RadioButton5m
        '
        Me.RadioButton5m.AutoSize = True
        Me.RadioButton5m.Location = New System.Drawing.Point(22, 146)
        Me.RadioButton5m.Name = "RadioButton5m"
        Me.RadioButton5m.Size = New System.Drawing.Size(113, 17)
        Me.RadioButton5m.TabIndex = 4
        Me.RadioButton5m.TabStop = True
        Me.RadioButton5m.Text = "5 minutes (Difficile)"
        Me.RadioButton5m.UseVisualStyleBackColor = True
        '
        'RadioButton10m
        '
        Me.RadioButton10m.AutoSize = True
        Me.RadioButton10m.Location = New System.Drawing.Point(22, 108)
        Me.RadioButton10m.Name = "RadioButton10m"
        Me.RadioButton10m.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton10m.TabIndex = 3
        Me.RadioButton10m.TabStop = True
        Me.RadioButton10m.Text = "10 minutes (Intermédiaire)"
        Me.RadioButton10m.UseVisualStyleBackColor = True
        '
        'RadioButton15m
        '
        Me.RadioButton15m.AutoSize = True
        Me.RadioButton15m.Location = New System.Drawing.Point(22, 70)
        Me.RadioButton15m.Name = "RadioButton15m"
        Me.RadioButton15m.Size = New System.Drawing.Size(113, 17)
        Me.RadioButton15m.TabIndex = 2
        Me.RadioButton15m.TabStop = True
        Me.RadioButton15m.Text = "15 minutes (Facile)"
        Me.RadioButton15m.UseVisualStyleBackColor = True
        '
        'RadioButton1m
        '
        Me.RadioButton1m.AutoSize = True
        Me.RadioButton1m.Location = New System.Drawing.Point(22, 180)
        Me.RadioButton1m.Name = "RadioButton1m"
        Me.RadioButton1m.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton1m.TabIndex = 1
        Me.RadioButton1m.TabStop = True
        Me.RadioButton1m.Text = "1 minute (Très difficile)"
        Me.RadioButton1m.UseVisualStyleBackColor = True
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(4, 4)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(77, 13)
        Me.LabelTemps.TabIndex = 0
        Me.LabelTemps.Text = "Temps de jeu :"
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(384, 415)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetour.TabIndex = 2
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'FormParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 450)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormParam"
        Me.Text = "Paramètres"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton20m As RadioButton
    Friend WithEvents RadioButton5m As RadioButton
    Friend WithEvents RadioButton10m As RadioButton
    Friend WithEvents RadioButton15m As RadioButton
    Friend WithEvents RadioButton1m As RadioButton
    Friend WithEvents LabelTemps As Label
    Friend WithEvents ButtonRetour As Button
End Class
