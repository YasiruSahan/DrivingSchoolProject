Public Class TraineeReport

    Private Sub TraineeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTMSDataSet.Trainee' table. You can move, or remove it, as needed.
        Me.TraineeTableAdapter.Fill(Me.DTMSDataSet.Trainee)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class