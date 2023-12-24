Public Class TrainingWithCal

    Private Sub TrainingWithCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTMSDataSet.TrainingDetails' table. You can move, or remove it, as needed.
        Me.TrainingDetailsTableAdapter.Fill(Me.DTMSDataSet.TrainingDetails)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class