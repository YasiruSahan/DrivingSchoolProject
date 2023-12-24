Imports System.Data.OleDb
Public Class Vehicle
    Dim adVehicle As New OleDbDataAdapter  'DataAdapter object to Fill Dataset
    Dim ds As New DataSet '
    Dim n As Integer 'Number of record in the table
    Dim chrDBCommand As Char 'add eke idan idiriyata
    

    Private Sub Vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmVehicle As New OleDbCommand
        cmVehicle.Connection = con
        cmVehicle.CommandText = "SELECT * FROM Vehicle"
        adVehicle.SelectCommand = cmVehicle
        adVehicle.Fill(ds, "Vehicle")
        n = ds.Tables("Vehicle").Rows.Count - 1
        con.Close()
        ShowRecords()

        Dim tbVehicle As DataTable
        tbVehicle = ds.Tables("Vehicle")
        DataGridView1.DataSource = tbVehicle.DefaultView



    End Sub
    Sub ShowRecords()
        Dim drVehicle As DataRow
        If n >= 0 Then
            drVehicle = ds.Tables("Vehicle").Rows(n)

            With drVehicle
                comVehicleClass.Text = .Item("Vehicle_Class")
                txtVehicleType.Text = .Item("Vehicle_Type")
                txtVName.Text = .Item("Vehicle_Name")
                comvehicleOwner.Text = .Item("Vehicle_Owner")
                txtTrainer.Text = .Item("Trainer")
            End With

        End If
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        n = 0
        ShowRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If n > 0 Then
            n = n - 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If n < ds.Tables("Vehicle").Rows.Count - 1 Then
            n = n + 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        n = ds.Tables("Vehicle").Rows.Count - 1
        ShowRecords()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        chrDBCommand = "A"
        comVehicleClass.Focus()
        txtVehicleType.Focus()
        clearControls()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If n >= 0 Then
            chrDBCommand = "E"
            comVehicleClass.Focus()
        End If
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        ShowRecords()

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If n >= 0 Then
            chrDBCommand = "D"
        End If
        MessageBox.Show("successfull deleted")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = adVehicle
        If chrDBCommand = "A" Then
            If comVehicleClass.Text = "" Or txtVehicleType.Text = "" Then
                MessageBox.Show("please Enter data before saving...")
            Else
                Dim drCus As DataRow
                drCus = ds.Tables("Trainee").NewRow
                With drCus
                    .Item("Vehicle_Class") = comVehicleClass.Text
                    .Item("Vehicle_Type") = txtVehicleType.Text
                    .Item("Vehicle_Name") = txtVName.Text
                    .Item("Vehicle_Owner") = comvehicleOwner.Text
                    .Item("Trainer") = txtTrainer.Text
                End With
                ds.Tables("Vehicle").Rows.Add(drCus)
                adVehicle.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1
                MessageBox.Show("successfull saved")
            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbVehicle As DataTable
            Dim dcPrimarykey(0) As DataColumn
            tbVehicle = ds.Tables("Vehicle")
            dcPrimarykey(0) = tbVehicle.Columns("Vehicle_Type")
            tbVehicle.PrimaryKey = dcPrimarykey
            Dim drVehicle As DataRow = tbVehicle.Rows.Find(txtVehicleType.Text)
            With drVehicle
                '.Item("Vehicle_Class") = comVehicleClass.Text
                '.Item("Vehicle_Type") = txtVehicleType.Text
                .Item("Vehicle_Name") = txtVName.Text
                .Item("Vehicle_Owner") = comvehicleOwner.Text
                .Item("Trainer") = txtTrainer.Text
            End With
            adVehicle.UpdateCommand = cmBuilder.GetUpdateCommand
        ElseIf chrDBCommand = "D" Then
            ds.Tables("Vehicle").Rows(n).Delete()
            adVehicle.DeleteCommand = cmBuilder.GetDeleteCommand
            n = n - 1

        End If
        con.Open()
        Try
            adVehicle.Update(ds, "Vehicle")
            clearControls()
            ShowRecords()
        Catch ex As Exception
            MessageBox.Show("You are trying to save data incorretly...")

        End Try
        con.Close()
    End Sub
   Sub clearControls()
        
        txtVehicleType.Clear()
        txtVName.Clear()
        'comvehicleOwner.clear
        txtTrainer.Clear()
    End Sub

    
   
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class