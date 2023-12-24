Public Class VehicleReport

    Private Sub VehicleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTMSDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.DTMSDataSet.Vehicle)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class