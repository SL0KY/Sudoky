Public Class FormParam
    Public Function getTimer()
        If RadioButton1m.Checked = True Then
            Return 60
        End If
        If RadioButton5m.Checked = True Then
            Return 60 * 5
        End If
        If RadioButton10m.Checked = True Then
            Return 60 * 10
        End If
        If RadioButton15m.Checked = True Then
            Return 60 * 15
        End If
        If RadioButton20m.Checked = True Then
            Return 60 * 20
        End If
        Return 60
    End Function

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        FormMP.Show()
    End Sub
End Class