Imports System.IO
Imports System.IO.File

Module Module1
    Dim ListeNom As New ArrayList
    Dim ListeMT As New ArrayList
    Dim ListeNP As New ArrayList
    Dim ListeCP As New ArrayList

    Public Sub ChargementScore()
        For i As Integer = 0 To ListeNom.Count - 1
            FormScore.ListBoxNom.Items.Add(ListeNom(i))
            FormScore.ListBoxMT.Items.Add(ListeMT(i))
            If Not FormScore.ComboBoxNom.Items.Contains(ListeNom(i)) Then
                FormScore.ComboBoxNom.Items.Add(ListeNom(i))
            End If
        Next
    End Sub

    Public Sub SupressionScore()
        For i As Integer = 0 To ListeNom.Count - 1
            FormScore.ListBoxNom.Items.Remove(ListeNom(i))
            FormScore.ListBoxMT.Items.Remove(ListeMT(i))
        Next
    End Sub

    Public Sub Chargement()
        Dim sr As New StreamReader(".\Resources\Joueur.txt")
        Dim Ligne, Ligne2, Ligne3, Ligne4 As String
        If Exists(".\Resources\Joueur.txt") Then
            While sr.Peek() >= 0
                Ligne = sr.ReadLine
                ListeNom.Add(Ligne)
                Ligne2 = sr.ReadLine
                ListeMT.Add(Ligne2)
                Ligne3 = sr.ReadLine
                ListeNP.Add(Ligne3)
                Ligne4 = sr.ReadLine
                ListeCP.Add(Ligne4)
            End While
        Else
            Dim rep As String = MsgBox("Fichier de lecture des joueurs introuvable !", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly)
            If rep = MsgBoxResult.Ok Then End
        End If

        sr.Close()

        For i As Integer = 0 To ListeNom.Count - 1
            FormMP.ComboBox1.Items.Add(ListeNom(i))
        Next
    End Sub

    Public Sub Jouer()
        If Not (ListeNom.Contains(FormMP.ComboBox1.Text)) Then
            ListeNom.Add(FormMP.ComboBox1.Text)
            ListeMT.Add(0)
            ListeNP.Add(1)
            ListeCP.Add(0)
        Else
            For i As Integer = 0 To ListeNom.Count - 1
                If ListeNom(i) = FormMP.ComboBox1.Text Then
                    ListeNP(i) = ListeNP(i) + 1
                End If
            Next
        End If
    End Sub

    Public Sub Maj()
        For i As Integer = 0 To ListeNom.Count - 1
            If ListeNom(i) = FormPartie.LabelNom.Text Then
                If FormPartie.getTemps() < ListeMT(i) Or ListeMT(i) = 0 Then
                    ListeMT(i) = FormPartie.getTemps()
                End If
                ListeCP(i) = ListeCP(i) + FormPartie.getTemps()
            End If
        Next
    End Sub

    Public Sub MajAbandon()
        For i As Integer = 0 To ListeNom.Count - 1
            If ListeNom(i) = FormPartie.LabelNom.Text Then
                ListeCP(i) = ListeCP(i) + FormPartie.getTemps()
            End If
        Next
    End Sub

    Public Sub Enregistrer()
        Dim sw As New StreamWriter(".\Resources\Joueur.txt")
        If Exists(".\Resources\Joueur.txt") Then
            For i As Integer = 0 To ListeNom.Count - 1
                sw.WriteLine(ListeNom(i))
                sw.WriteLine(ListeMT(i))
                sw.WriteLine(ListeNP(i))
                sw.WriteLine(ListeCP(i))
            Next
        Else
            Dim rep As String = MsgBox("Fichier de lecture des joueurs introuvable !", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.OkOnly)
            If rep = MsgBoxResult.Ok Then End
        End If

        sw.Close()
    End Sub

    Public Function getInfo()
        Dim s As String = ""
        For i As Integer = 0 To ListeNom.Count - 1
            If ListeNom(i) = FormScore.ComboBoxNom.text Then
                s = "Meilleur temps : " & ListeMT(i) & " seconde(s), Nombre de partie jouée(s) :  " & ListeNP(i) & ", Cumul du temps joué : " & ListeCP(i) & " secondes."
            End If
        Next
        Return s
    End Function

    Public Sub affichage()
        For i As Integer = 0 To ListeNom.Count - 1
            If ListeNom(i) = FormPartie.LabelNom.Text Then
                If ListeMT(i) < 2 Then
                    FormPartie.LabelMeilleurTemps.Text = ListeMT(i) & " seconde"
                Else
                    FormPartie.LabelMeilleurTemps.Text = ListeMT(i) & " secondes"
                End If
            End If
        Next
    End Sub

    Public Function getNbJoueur()
        Return ListeNom.Count
    End Function

End Module
