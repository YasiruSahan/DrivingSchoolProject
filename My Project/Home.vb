Public Class Add


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtTNum.Text = ""
        txtRegDate.Text = ""
        txtNIC.Text = ""
        txtName.Text = ""
        txtDoB.Text = "yyyy/mm/dd"
        txtAge.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        txtTelephone.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtAddress3.Text = ""
        comVehicleClass.Text = ""
        ComVehicletype.Text = ""
    End Sub

    
    Private Sub textTopen_Click(sender As Object, e As EventArgs) Handles textTopen.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Project\DTMS.mdb"
        Dim Trainee As New Trainee
        Trainee.Show()
    End Sub

    Private Sub txtTDopen_Click(sender As Object, e As EventArgs) Handles txtTDopen.Click

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Project\DTMS.mdb"
        Dim TrainingDetails As New TrainingDetails

        TrainingDetails.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ComVehicletype.Text = ""
    End Sub
    Sub clearControls()
        txtTNum.Clear()
        'txtRegDate.Text = ""
        txtNIC.Clear()
        txtName.Clear()
        txtDoB.Text = "MM/DD/YYYY"
        txtAge.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        txtTelephone.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtAddress3.Clear()
        comVehicleClass.Text = ""
        ComVehicletype.Text = ""
    End Sub

    
  
    Private Sub txtRegDate_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub picTProfile_Enter(sender As Object, e As EventArgs) Handles picTProfile.Enter

    End Sub
End Class