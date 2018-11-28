Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles Convert_btn.Click

        Dim numConverter As Integer = Integer.Parse(txtConverter.Text)
        BinaryOutput.Text = Convert.ToString(numConverter, 2)
    End Sub
End Class
