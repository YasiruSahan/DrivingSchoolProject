Public Class TraineeSearch
    Public strTraineeNum As String
    Private Sub TraineeSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        strTraineeNum = txtSearch.Text
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class