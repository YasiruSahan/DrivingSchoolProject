Public Class TrainingDetailsSearch

    Public strTraineeNum As String
    Public strVehicleType As String
    Private Sub TraineeSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        ComVehicletype.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        
        strTraineeNum = txtSearch.Text
        strVehicleType = ComVehicletype.Text
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    
End Class