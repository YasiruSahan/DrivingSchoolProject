Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String
        Dim Password As String

        Username = "Admin"
        Password = "12345"
        If Username = txtUser.Text And Password = txtPassword.Text Then
            MessageBox.Show("Login successful")
            Form1.Show()
        Else
            MessageBox.Show("Sorry Try Again")
            Form1.Hide()
        End If
        txtUser.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class