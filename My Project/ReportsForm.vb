Public Class ReportsForm

    Private Sub btnTraineeReport_Click(sender As Object, e As EventArgs) Handles btnTraineeReport.Click
        TraineeReport.Show()
    End Sub

    Private Sub btnTrainingReport_Click(sender As Object, e As EventArgs) Handles btnTrainingReport.Click
        TrainingReport.Show()
    End Sub

    Private Sub btnVehicleReport_Click(sender As Object, e As EventArgs) Handles btnVehicleReport.Click
        VehicleReport.Show()
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class