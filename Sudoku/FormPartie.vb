Public Class FormPartie
    Private tempsRestant As Integer
    Dim rejouer As Boolean = False
    Dim Matrice(8, 8) As TextBox
    Dim Matrice1Sol(,) As Integer = {{4, 7, 3, 9, 8, 5, 2, 6, 1}, {5, 1, 6, 3, 2, 4, 8, 7, 9}, {8, 2, 9, 6, 1, 7, 4, 3, 5}, {2, 6, 1, 5, 9, 8, 7, 4, 3}, {7, 3, 5, 1, 4, 2, 6, 9, 8}, {9, 4, 8, 7, 3, 6, 5, 1, 2}, {1, 8, 2, 4, 6, 9, 3, 5, 7}, {3, 5, 4, 2, 7, 1, 9, 8, 6}, {6, 9, 7, 8, 5, 3, 1, 2, 4}}
    Dim Matrice1(,) As Integer = {{4, 0, 0, 0, 0, 0, 0, 0, 0}, {5, 0, 6, 0, 2, 4, 0, 0, 9}, {0, 0, 9, 0, 1, 7, 0, 0, 0}, {0, 0, 0, 0, 0, 8, 7, 4, 0}, {0, 3, 5, 0, 0, 2, 0, 0, 0}, {9, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 2, 0, 0, 9, 0, 0, 0}, {0, 0, 0, 0, 7, 0, 0, 8, 0}, {0, 0, 7, 8, 5, 0, 1, 0, 0}}

    Private Sub FormPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim top As Integer = 120
        Dim left As Integer = 120
        Dim Largeur = 40
        Dim Espacementy, Espacementx
        Espacementy = Espacementx = 0

        LabelNom.Text = FormMP.ComboBox1.Text
        LabelCompteur.Text = FormParam.getTimer() & " secondes"
        Timer.Enabled = True

        For i As Integer = 0 To 8
            If i > 2 And i < 6 Then
                Espacementy = 10
            ElseIf i > 5 Then
                Espacementy = 20
            End If
            For j As Integer = 0 To 8
                If j > 2 And j < 6 Then
                    Espacementx = 10
                ElseIf j > 5 Then
                    Espacementx = 20
                End If
                Dim txt As New System.Windows.Forms.TextBox()
                txt.Location = New Point(left + (j - 1) * Largeur + Espacementx, top + (i - 1) * Largeur + Espacementy)
                Matrice(i, j) = txt
                Matrice(i, j).Multiline = True
                Matrice(i, j).Width = Largeur
                Matrice(i, j).Height = Largeur
                Matrice(i, j).MaxLength = 1
                Matrice(i, j).TextAlign = HorizontalAlignment.Center
                Matrice(i, j).Font = New Font("Microsoft Sans Serif", 20, FontStyle.Regular)
                Matrice(i, j).Name = "txt" & i & j
                AddHandler Matrice(i, j).KeyPress, AddressOf txt_KeyPress
                AddHandler Matrice(i, j).TextChanged, AddressOf VerifChiffre
                Me.Controls.Add(Matrice(i, j))
            Next
            Espacementx = 0
        Next
        InitPartie()
        InitTimer()
        Module1.affichage()
        rejouer = True
    End Sub

    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        Dim reponse As String = MsgBox("Voulez-vous vraiment abandonner la partie ?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Confirmation")
        If reponse = MsgBoxResult.Yes Then
            Me.Hide()
            Timer.Stop()
            Module1.MajAbandon()
            ReinitPartie()
            InitTimer()
            FormMP.Show()

        End If
    End Sub



    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim reponse As String
        If tempsRestant > 2 Then
            tempsRestant -= 1
            LabelCompteur.Text = tempsRestant & " secondes"
        ElseIf tempsRestant = 2 Or tempsRestant = 1 Then
            tempsRestant -= 1
            LabelCompteur.Text = tempsRestant & " seconde"
        Else
            Timer.Stop()
            LabelCompteur.Text = "Fin"
            reponse = MsgBox("Vous avez perdu, le temps est écoulé !", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Fin de partie")
            If reponse = MsgBoxResult.Ok Then
                Me.Hide()
                Module1.Maj()
                ReinitPartie()
                InitTimer()
                FormMP.Show()
            End If
        End If
    End Sub

    Public Function getTemps()
        Return (FormParam.getTimer() - tempsRestant)
    End Function

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbBack Then
            sender.backColor = Color.White
            sender.forecolor = Color.LightGreen
            Exit Sub
        End If
        If Not (IsNumeric(e.KeyChar)) Then e.KeyChar = Chr(0)
    End Sub

    Private Sub VerifChiffre(sender As Object, e As EventArgs)
        Dim cj As Char = sender.Name.ToCharArray()(4)
        Dim ci As Char = sender.Name.ToCharArray()(3)
        Dim cii, cjj As Integer
        For i As Integer = 0 To 80
            If i.ToString = cj Then cjj = i
            If i.ToString = ci Then cii = i
        Next
        If VerifLigne(cii, cjj) = True AndAlso VerifColonne(cii, cjj) = True AndAlso VerifZone(cii, cjj) = True Then
            sender.BackColor = Color.White
            sender.ForeColor = Color.LightGreen
        Else
            sender.backcolor = Color.Red
            sender.Forecolor = Color.Black
        End If
    End Sub

    Private Sub ButtonWin_Click(sender As Object, e As EventArgs) Handles ButtonWin.Click
        Timer.Stop()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Matrice(i, j).Text = Matrice1Sol(i, j)
                Matrice(i, j).Enabled = False
            Next
        Next
        Dim rep As String = MsgBox("Bravo ! Tu as gagné !", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly, "Félicitation")
        If rep = MsgBoxResult.Ok Then
            Me.Hide()
            Module1.Maj()
            ReinitPartie()
            InitTimer()
            FormMP.Show()
        End If
    End Sub



    Private Function VerifLigne(i As Integer, j As Integer)
        Dim chiffre As String = Matrice(i, j).Text
        For ligne As Integer = 0 To 8
            If ligne <> i AndAlso Matrice(ligne, j).Text = chiffre Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function VerifColonne(i As Integer, j As Integer)
        Dim chiffre As String = Matrice(i, j).Text
        For colonne As Integer = 0 To 8
            If colonne <> j AndAlso Matrice(i, colonne).Text = chiffre Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function VerifZone(i As Integer, j As Integer)
        Dim chiffre As String = Matrice(i, j).Text
        Dim itemp As Integer = i
        Dim jtemp As Integer = j
        i -= i Mod 3
        j -= j Mod 3
        For colonne As Integer = 0 To 2
            For ligne As Integer = 0 To 2
                If Matrice(i + ligne, j + colonne).Text.Equals(chiffre) AndAlso (j + colonne <> jtemp AndAlso i + ligne <> itemp) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Sub ReinitPartie()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Matrice(i, j).Clear()
                Matrice(i, j).BackColor = Color.White
                Matrice(i, j).ForeColor = Color.LightGreen
                If Matrice(i, j).Enabled = False Then Matrice(i, j).Enabled = True
            Next
        Next
    End Sub

    Public Sub InitPartie()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If Matrice1(i, j) <> 0 Then
                    Matrice(i, j).Text = Matrice1(i, j)
                    Matrice(i, j).Enabled = False
                End If
            Next
        Next
    End Sub

    Public Function getRejouer()
        Return rejouer
    End Function

    Public Sub InitTimer()
        tempsRestant = FormParam.getTimer()
    End Sub


    Private Sub ButtonVerif_Click(sender As Object, e As EventArgs) Handles ButtonVerif.Click
        Dim win As Boolean = False
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If Matrice(i, j).Equals(Matrice1Sol(i, j)) Then
                    win = True
                End If
            Next
        Next
        If win = True Then
            Timer.Stop()
            Dim rep As String = MsgBox("Bravo ! Tu as gagné !", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly, "Félicitation")
            If rep = MsgBoxResult.Ok Then
                Me.Hide()
                Module1.Maj()
                ReinitPartie()
                InitTimer()
                FormMP.Show()
            End If
        Else
            MsgBox("La grille n'est pas valide, essaye encore !", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly, "Invalide")
        End If
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        Timer.Stop()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Matrice(i, j).Enabled = False
            Next
        Next
        Dim rep As String = MsgBox("Le jeu est en pause appuyer sur 'OK' pour reprendre", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly, "Pause")
        If rep = MsgBoxResult.Ok Then
            For i As Integer = 0 To 8
                For j As Integer = 0 To 8
                    Matrice(i, j).Enabled = True
                    If Matrice1(i, j).ToString = Matrice(i, j).Text Then
                        Matrice(i, j).Enabled = False
                    End If
                Next
            Next
            Timer.Enabled = True
        End If
    End Sub
End Class