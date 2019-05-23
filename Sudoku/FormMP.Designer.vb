<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMP))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonJouer = New System.Windows.Forms.Button()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ButtonParam = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(175, 232)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(90, 23)
        Me.ButtonQuitter.TabIndex = 1
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonJouer
        '
        Me.ButtonJouer.Location = New System.Drawing.Point(69, 189)
        Me.ButtonJouer.Name = "ButtonJouer"
        Me.ButtonJouer.Size = New System.Drawing.Size(90, 23)
        Me.ButtonJouer.TabIndex = 2
        Me.ButtonJouer.Text = "Jouer"
        Me.ButtonJouer.UseVisualStyleBackColor = True
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(175, 189)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(90, 23)
        Me.ButtonScore.TabIndex = 3
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(108, 129)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(91, 13)
        Me.LabelNom.TabIndex = 4
        Me.LabelNom.Text = "Entrer votre nom :"
        '
        'ButtonParam
        '
        Me.ButtonParam.Location = New System.Drawing.Point(69, 232)
        Me.ButtonParam.Name = "ButtonParam"
        Me.ButtonParam.Size = New System.Drawing.Size(90, 23)
        Me.ButtonParam.TabIndex = 6
        Me.ButtonParam.Text = "Paramètres"
        Me.ButtonParam.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 97)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 291)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonParam)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ButtonJouer)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FormMP"
        Me.Text = "Menu principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonJouer As Button
    Friend WithEvents ButtonScore As Button
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonParam As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
