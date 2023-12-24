Imports System.Data.OleDb
Public Class TrainingDetails
    Dim adTV As New OleDbDataAdapter  'DataAdapter object to Fill Dataset
    Dim ds As New DataSet '
    Dim n As Integer 'Number of record in the table
    Dim chrDBCommand As Char 'add eke idan idiriyata
    'Dim dt As New DataTable()
    'Dim i As Integer



    Private Sub Vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()

        Dim cmTV As New OleDbCommand
        cmTV.Connection = con
        cmTV.CommandText = "SELECT * FROM TrainingDetails"
        adTV.SelectCommand = cmTV
        adTV.Fill(ds, "TrainingDetails")
        n = ds.Tables("TrainingDetails").Rows.Count - 1
        con.Close()
        ShowRecords()
        
        Dim tbTrainingDetails As DataTable
        tbTrainingDetails = ds.Tables("TrainingDetails")
        DataGridView1.DataSource = tbTrainingDetails.DefaultView




    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        novalue()
        n = 0
        ShowRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        novalue()
        If n > 0 Then
            n = n - 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        novalue()
        If n < ds.Tables("TrainingDetails").Rows.Count - 1 Then
            n = n + 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        novalue()
        n = ds.Tables("TrainingDetails").Rows.Count - 1
        ShowRecords()
    End Sub
   
    Sub ShowRecords()
        Dim drVehicle As DataRow
        If n >= 0 Then
            drVehicle = ds.Tables("TrainingDetails").Rows(n)

            With drVehicle
                txtTNum.Text = .Item("Reg_NO")
                comVehicleClass.Text = .Item("Vehicle_Class")
                txtVehicleType.Text = .Item("Vehicle_Type")
               
            End With

        End If
    End Sub
  
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        novalue()
        chrDBCommand = "A"
        comVehicleClass.Focus()
        txtVehicleType.Focus()
        clearControls()
        txtTNum.Text = Add.txtTNum.Text
        comVehicleClass.Text = Add.comVehicleClass.Text
        txtVehicleType.Text = Add.ComVehicletype.Text
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        novalue()
        If n >= 0 Then
            chrDBCommand = "E"
            comVehicleClass.Focus()
        End If
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        novalue()
        ShowRecords()

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        novalue()
        If n >= 0 Then
            chrDBCommand = "D"
        End If
        MessageBox.Show("successfull deleted")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        novalue()

        If txtTNum.Text = "" Then
            MessageBox.Show("Please Enter trainee number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTNum.BackColor = Color.Red
        ElseIf Not (txtTNum.TextLength = "4") Or Not IsNumeric(txtTNum.Text) Then
            MessageBox.Show("Use four digits to reprecent Trainee number (Eg:-0017). If it is not clear, go to the trainee details in the main form and get an idea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTNum.BackColor = Color.Red
        End If

        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = adTV
        If chrDBCommand = "A" Then
            If comVehicleClass.Text = "" Or txtVehicleType.Text = "" Then
                MessageBox.Show("please Enter data before saving...")
            Else
                Dim drCus As DataRow
                drCus = ds.Tables("TrainingDetails").NewRow
                With drCus
                    .Item("Reg_NO") = txtTNum.Text
                    .Item("Vehicle_Class") = comVehicleClass.Text
                    .Item("Vehicle_Type") = txtVehicleType.Text

                End With
                ds.Tables("TrainingDetails").Rows.Add(drCus)
                adTV.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1

            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbTrainingDetails As DataTable
            Dim dcPrimarykey(2) As DataColumn
            tbTrainingDetails = ds.Tables("TrainingDetails")
            dcPrimarykey(0) = tbTrainingDetails.Columns("Reg_No")
            dcPrimarykey(1) = tbTrainingDetails.Columns("Vehicle_Class")
            dcPrimarykey(2) = tbTrainingDetails.Columns("Vehicle_Type")
            tbTrainingDetails.PrimaryKey = dcPrimarykey
            Dim drVehicle As DataRow = tbTrainingDetails.Rows.Find(txtVehicleType.Text)
            With drVehicle
                .Item("Reg_NO") = txtTNum.Text
                .Item("Vehicle_Class") = comVehicleClass.Text
                .Item("Vehicle_Type") = txtVehicleType.Text

            End With
            adTV.UpdateCommand = cmBuilder.GetUpdateCommand
        ElseIf chrDBCommand = "D" Then
            ds.Tables("TrainingDetails").Rows(n).Delete()
            adTV.DeleteCommand = cmBuilder.GetDeleteCommand
            n = n - 1

        End If
        con.Open()
        Try
            adTV.Update(ds, "TrainingDetails")
            clearControls()
            ShowRecords()
            MessageBox.Show("successfull saved")
        Catch ex As Exception
            MessageBox.Show("You are trying to save data incorretly...")

        End Try
        con.Close()
    End Sub
    Sub clearControls()
        txtTNum.Clear()


    End Sub


    




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub novalue()
        txtTNum.BackColor = Color.White
    End Sub

    
End Class