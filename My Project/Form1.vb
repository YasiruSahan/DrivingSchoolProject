Imports My_Project.Module1
Public Class Form1

    Private Sub btnRegistation_Click(sender As Object, e As EventArgs) Handles btnRegistation.Click

        Switchpanel3(Add)
    End Sub

    Sub Switchpanel3(ByVal Panel As Form)

        Panel3.Controls.Clear()
        Panel.TopLevel = False
        Panel3.Controls.Add(Panel)

        Panel.Show()

    End Sub


    Private Sub btnTrainee_Click(sender As Object, e As EventArgs) Handles btnTrainee.Click
        Add.clearControls()

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Project\DTMS.mdb"
        Dim Trainee As New Trainee
        'Trainee.ShowDialog()
        Switchpanel3(Trainee)

    End Sub

    Private Sub btnVehicle_Click(sender As Object, e As EventArgs) Handles btnVehicle.Click
        Add.clearControls()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Project\DTMS.mdb"
        Dim Vehicle As New Vehicle
        'Vehicle.ShowDialog()
        Switchpanel3(Vehicle)

    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOthers.Click

    End Sub


    Private Sub btnTDetails_Click(sender As Object, e As EventArgs) Handles btnTDetails.Click

        Add.clearControls()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Project\DTMS.mdb"
        Dim TrainingDetails As New TrainingDetails

        Switchpanel3(TrainingDetails)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Switchpanel3(ReportsForm)
    End Sub
End Class
