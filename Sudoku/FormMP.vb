Public Class FormMP
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Module1.Enregistrer()
        Dim reponse As String = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmation")
        If reponse = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ButtonJouer_Click(sender As Object, e As EventArgs) Handles ButtonJouer.Click
        Dim Is_Valide As Boolean = False
        If ComboBox1.Text = "" Then
            LabelNom.ForeColor = Color.Red
            MsgBox("Merci de rentrer un nom valide !", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erreur")
        Else
            Is_Valide = True
        End If
        If Is_Valide = True Then
            LabelNom.ForeColor = Color.Black
            Me.Hide()
            Module1.SupressionScore()
            Module1.Jouer()
            FormPartie.LabelCompteur.Text = FormParam.getTimer() & " secondes"
            FormPartie.LabelNom.Text = ComboBox1.Text
            If FormPartie.getRejouer() = True Then
                FormPartie.InitPartie()
                Module1.SupressionScore()
                Module1.Jouer()
                FormPartie.LabelCompteur.Text = FormParam.getTimer() & " secondes"
                FormPartie.LabelNom.Text = ComboBox1.Text
                FormPartie.InitTimer()
                FormPartie.Timer.Enabled = True
            End If
            FormPartie.Show()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub FormMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.Chargement()
        FormParam.RadioButton1m.Checked = True
        My.Computer.Audio.Play(My.Resources.musique1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Me.Hide()
        Module1.ChargementScore()
        FormScore.Show()
    End Sub

    Private Sub ButtonParam_Click(sender As Object, e As EventArgs) Handles ButtonParam.Click
        Me.Hide()
        FormParam.Show()
    End Sub
End Class