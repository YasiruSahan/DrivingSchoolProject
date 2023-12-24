Public Class TrainingReportMainTrainee

    Private Sub TrainingReportMainTrainee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTMSDataSet.Query1' table. You can move, or remove it, as needed.
        Me.Query1TableAdapter.Fill(Me.DTMSDataSet.Query1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class