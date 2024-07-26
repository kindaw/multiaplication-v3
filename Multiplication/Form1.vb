Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles But_1.Click
        Dim setter, multi, result, start, endp, go As Integer
        Dim msMulti As String
        setter = Val(Nud_1.Text)
        start = Val(Nud_2.Text)
        multi = Val(Nud_3.Text)
        endp = Val(Nud_4.Text)
        go = 1

        msMulti = String.Empty

        For ii = setter To endp Step go
            For i = start To multi Step go
                result = ii * i
                msMulti &= ii & vbTab & " x " & vbTab & i & vbTab & " = " & vbTab & result & vbCrLf

            Next
            MessageBox.Show(msMulti)
            msMulti = ""
        Next


    End Sub

End Class
