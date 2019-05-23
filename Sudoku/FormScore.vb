Public Class FormScore
    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        Module1.SupressionScore()
        FormMP.Show()
    End Sub

    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxMT.SelectedIndexChanged
        ListBoxNom.SelectedIndex = sender.SelectedIndex
        ListBoxMT.SelectedIndex = sender.SelectedIndex
    End Sub

    Private Sub ButtonStat_Click(sender As Object, e As EventArgs) Handles ButtonStat.Click
        If ComboBoxNom.Text = "" Or Not (ListBoxNom.Items.Contains(ComboBoxNom.Text)) Then
            MsgBox("Veuillez choisir un joueur !", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkCancel, "Erreur")
        Else
            MsgBox("Nom : " & ComboBoxNom.Text & ", " & getInfo(), MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Statistiques")
        End If
    End Sub

    Private Sub ButtonTriAlp_Click(sender As Object, e As EventArgs) Handles ButtonTriAlp.Click
        ListBoxNom.Sorted = True
        ListBoxMT.Sorted = True
    End Sub

    Private Sub ButtonTriScore_Click(sender As Object, e As EventArgs) Handles ButtonTriScore.Click
        ListBoxNom.Sorted = False
        ComboBoxNom.Sorted = False

        Dim a, b, temp As Integer
        Dim n As String
        Dim en_ordre As Boolean = False
        Dim taille As Integer = Module1.getNbJoueur()
        While Not en_ordre
            en_ordre = True
            For i As Integer = 1 To taille - 1
                For j As Integer = -i To -1
                    temp = -j
                    a = ListBoxMT.Items.Item(temp - 1)
                    b = ListBoxMT.Items.Item(temp)
                    If a > b Then
                        ListBoxMT.Items.Item(temp) = a
                        ListBoxMT.Items.Item(temp - 1) = b
                        n = ListBoxNom.Items.Item(temp)
                        ListBoxNom.Items.Item(temp) = ListBoxNom.Items.Item(temp - 1)
                        ListBoxNom.Items.Item(temp - 1) = n
                        ComboBoxNom.Items.Item(temp) = ComboBoxNom.Items.Item(temp - 1)
                        ComboBoxNom.Items.Item(temp - 1) = n
                        en_ordre = False
                    End If
                    taille -= 1
                Next
            Next
        End While

    End Sub
End Class