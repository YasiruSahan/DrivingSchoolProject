Imports System.Data.OleDb
Public Class Trainee
    Dim adTrainee As New OleDbDataAdapter  'DataAdapter object to Fill Dataset
    Dim ds As New DataSet '
    Dim n As Integer 'Number of record in the table
    Dim chrDBCommand As Char 'add eke idan idiriyata



    Private Sub Trainee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmTrainee As New OleDbCommand
        cmTrainee.Connection = con
        cmTrainee.CommandText = "SELECT * FROM Trainee"
        adTrainee.SelectCommand = cmTrainee
        adTrainee.Fill(ds, "Trainee")
        n = ds.Tables("Trainee").Rows.Count - 1
        con.Close()
        ShowRecords()

    End Sub

    Sub ShowRecords()
        Dim drTrainee As DataRow
        If n >= 0 Then
            drTrainee = ds.Tables("Trainee").Rows(n)

            With drTrainee
                txtTNum.Text = .Item("Reg_No")
                txtRegDate.Text = .Item("Reg_Date")
                txtNIC.Text = .Item("NIC")
                txtName.Text = .Item("Name")
                txtDoB.Text = .Item("DoB")
                txtAge.Text = .Item("Age")
                radMale.Checked = (.Item("Gender") = "Male")
                radFemale.Checked = (.Item("Gender") = "Female")
                txtTelephone.Text = .Item("Telephone_No")
                txtAddress1.Text = .Item("Addressline_1")
                txtAddress2.Text = .Item("Addressline_2")
                txtAddress3.Text = .Item("Addressline_3")
            End With

        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        novalueChange()
        n = 0
        ShowRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        novalueChange()
        If n > 0 Then
            n = n - 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        novalueChange()
        If n < ds.Tables("Trainee").Rows.Count - 1 Then
            n = n + 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        novalueChange()
        n = ds.Tables("Trainee").Rows.Count - 1
        ShowRecords()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
         chrDBCommand = "A"
        txtTNum.Focus()
        clearControls()


    End Sub
    Private Sub novalue()
        If txtTNum.Text = "" Then
            MessageBox.Show("Please Enter trainee number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTNum.BackColor = Color.Red
        ElseIf Not (txtTNum.TextLength = "4") Or Not IsNumeric(txtTNum.Text) Then
            MessageBox.Show("Use four digits to reprecent Trainee number (Eg:-0017). If it is not clear, go to the trainee details in the main form and get an idea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTNum.BackColor = Color.Red
        End If


        If txtNIC.Text = "" Then
            MessageBox.Show("NIC Number incorrect", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNIC.BackColor = Color.Red
        ElseIf Not (txtNIC.TextLength = "12" Or txtNIC.TextLength = "10") Then
            MessageBox.Show("Please Enter NIC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNIC.BackColor = Color.Red

        End If


        'If Not txtTelephone.Text.Length = "10" Then
        '    MessageBox.Show("Telephone Number incorrect", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtTelephone.BackColor = Color.Red

        'ElseIf Not txtTelephone.Text.Substring(0, 1) = "0" Then
        '    MessageBox.Show("Telephone Number incorrect", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtTelephone.BackColor = Color.Red
        'ElseIf Not IsNumeric(txtTelephone.Text) Then
        '    MessageBox.Show("Telephone Number incorrect", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtTelephone.BackColor = Color.Red
        'ElseIf txtTelephone.Text = "" Then
        '    MessageBox.Show("Please Enter Trainee Phone Number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtTelephone.BackColor = Color.Red

        'End If

        If txtNIC.Text = "" And txtTNum.Text = "" And txtName.Text = "" And txtDoB.Text = "" And txtAge.Text = "" _
            And txtTelephone.Text = "" And txtRegDate.Text = "" And txtAddress1.Text = "" And txtAddress2.Text = "" _
            And txtAddress3.Text = "" Then
        Else

            If txtRegDate.Text = "" Then
                MessageBox.Show("Please Enter Registion Date", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRegDate.BackColor = Color.Red
            End If

            If txtName.Text = "" Or IsNumeric(txtName.Text) Then
                MessageBox.Show("Please Enter Trainee Name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtName.BackColor = Color.Red
            End If
            If txtDoB.Text = "" Then
                MessageBox.Show("Please Enter Date of birth", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDoB.BackColor = Color.Red
            End If
            If txtAge.Text = "" Or Not IsNumeric(txtAge.Text) Or Not (txtAge.TextLength = "2") Then
                MessageBox.Show("Please Enter trainee Age correctly", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAge.BackColor = Color.Red
            End If


            If txtTelephone.Text = "" Then
                MessageBox.Show("Please Enter Trainee Phone Number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTelephone.BackColor = Color.Red
            ElseIf Not txtTelephone.Text.Length = "10" Then
                MessageBox.Show("Telephone Number Not in range", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTelephone.BackColor = Color.Red

            ElseIf Not txtTelephone.Text.Substring(0, 1) = "0" Then
                MessageBox.Show("Telephone Number Frist Digit Not Zero", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTelephone.BackColor = Color.Red
            ElseIf Not IsNumeric(txtTelephone.Text) Then
                MessageBox.Show("Telephone Number is Not Numeric", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTelephone.BackColor = Color.Red


            End If

            If txtAddress1.Text = "" Then
                MessageBox.Show("Please Enter trainee Address", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAddress1.BackColor = Color.Red

            End If
            If txtAddress2.Text = "" Then
                txtAddress2.BackColor = Color.Red
            End If

            If txtAddress3.Text = "" Then
                txtAddress3.BackColor = Color.Red
            End If
        End If


    End Sub
    Private Sub novalueChange()
        'If txtTNum.Text = "" Then
        '    txtTNum.BackColor = Color.White
        'End If
        'If txtRegDate.Text = "" Then
        '    txtRegDate.BackColor = Color.White
        'End If
        'If txtNIC.Text = "" Then
        '    txtNIC.BackColor = Color.White
        'End If
        'If txtName.Text = "" Then
        '    txtName.BackColor = Color.White
        'End If
        'If txtDoB.Text = "" Then
        '    txtDoB.BackColor = Color.White
        'End If
        'If txtAge.Text = "" Then
        '    txtAge.BackColor = Color.White
        'End If
        'If txtTelephone.Text = "" Then
        '    txtTelephone.BackColor = Color.White

        'End If
        'If txtAddress1.Text = "" Then
        '    txtAddress1.BackColor = Color.White

        'End If
        'If txtAddress2.Text = "" Then
        '    txtAddress2.BackColor = Color.White

        'End If
        'If txtAddress3.Text = "" Then
        '    txtAddress3.BackColor = Color.White

        'End If
        txtTNum.BackColor = Color.White
        txtRegDate.BackColor = Color.White
        txtNIC.BackColor = Color.White
        txtName.BackColor = Color.White
        txtDoB.BackColor = Color.White
        txtAge.BackColor = Color.White
        txtTelephone.BackColor = Color.White
        txtAddress1.BackColor = Color.White
        txtAddress2.BackColor = Color.White
        txtAddress3.BackColor = Color.White
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        novalueChange()
        If n >= 0 Then
            chrDBCommand = "E"
            txtTNum.Focus()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        novalueChange()
        If n >= 0 Then
            chrDBCommand = "D"
        End If
        MessageBox.Show("successfull deleted")
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        'novalueChange()
        novalue()
        Dim chrGender As String
        If radMale.Checked = True Then
            chrGender = "Male"
        Else
            chrGender = "Female"
        End If
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = adTrainee
        If chrDBCommand = "A" Or chrDBCommand = "G" Then
            If txtNIC.Text = "" Or txtTNum.Text = "" Or txtName.Text = "" Or txtDoB.Text = "" Or txtAge.Text = "" _
            Or txtTelephone.Text = "" Or txtRegDate.Text = "" Or txtAddress1.Text = "" Or txtAddress2.Text = "" _
            Or txtAddress3.Text = "" Then


                MessageBox.Show("please Enter data before saving...")
            Else
                Dim drCus As DataRow
                drCus = ds.Tables("Trainee").NewRow
                With drCus
                    .Item("Reg_No") = txtTNum.Text
                    .Item("Reg_Date") = txtRegDate.Text
                    .Item("NIC") = txtNIC.Text
                    .Item("Name") = txtName.Text
                    .Item("DoB") = txtDoB.Text
                    .Item("Age") = txtAge.Text
                    .Item("Gender") = chrGender
                    .Item("Telephone_No") = txtTelephone.Text
                    .Item("Addressline_1") = txtAddress1.Text
                    .Item("Addressline_2") = txtAddress2.Text
                    .Item("Addressline_3") = txtAddress3.Text
                End With
                ds.Tables("Trainee").Rows.Add(drCus)
                adTrainee.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1


            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbTrainee As DataTable
            Dim dcPrimarykey(0) As DataColumn
            tbTrainee = ds.Tables("Trainee")
            dcPrimarykey(0) = tbTrainee.Columns("Reg_No")
            tbTrainee.PrimaryKey = dcPrimarykey
            Dim drTrainee As DataRow = tbTrainee.Rows.Find(txtTNum.Text)
            With drTrainee
                '.Item("Reg_No") = txtTNum.Text
                .Item("Reg_Date") = txtRegDate.Text
                .Item("NIC") = txtNIC.Text
                .Item("Name") = txtName.Text
                .Item("DoB") = txtDoB.Text
                .Item("Age") = txtAge.Text
                .Item("Gender") = chrGender
                .Item("Telephone_No") = txtTelephone.Text
                .Item("Addressline_1") = txtAddress1.Text
                .Item("Addressline_2") = txtAddress2.Text
                .Item("Addressline_3") = txtAddress3.Text
            End With
            adTrainee.UpdateCommand = cmBuilder.GetUpdateCommand
            'MessageBox.Show("successfull saved")
        ElseIf chrDBCommand = "D" Then

            ds.Tables("Trainee").Rows(n).Delete()
            adTrainee.DeleteCommand = cmBuilder.GetDeleteCommand
            n = n - 1
            'MessageBox.Show("successfull saved")
        End If
        con.Open()
        Try
            adTrainee.Update(ds, "Trainee")
            clearControls()
            ShowRecords()
            MessageBox.Show("successfull saved")
        Catch ex As Exception
            MessageBox.Show("You are trying to save data incorretly...")

        End Try

        con.Close()

    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        novalueChange()
        ShowRecords()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
    Sub clearControls()
        txtTNum.Clear()
        'txtRegDate.Clear()
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
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        novalueChange()
        Dim access As String
        access = "select * from Trainee where Reg_No=" & TraineeSearch.strTraineeNum & " "
        Dim tbCustomer As DataTable
        Dim dcPrimarykey(0) As DataColumn
        tbCustomer = ds.Tables("Trainee")
        dcPrimarykey(0) = tbCustomer.Columns("Reg_No")
        tbCustomer.PrimaryKey = dcPrimarykey

        Dim Traineefind As New TraineeSearch
        Dim strTNo As String

        Traineefind.ShowDialog()

        strTNo = Traineefind.strTraineeNum

        If Not strTNo Is Nothing Then
            Dim drTrainee As DataRow = tbCustomer.Rows.Find(strTNo)
            If Not drTrainee Is Nothing Then
                With drTrainee
                    txtTNum.Text = .Item("Reg_No")
                    txtRegDate.Text = .Item("Reg_Date")
                    txtNIC.Text = .Item("NIC")
                    txtName.Text = .Item("Name")
                    txtDoB.Text = .Item("Dob")
                    txtAge.Text = .Item("Age")
                    radMale.Checked = (.Item("Gender") = "Male")
                    radFemale.Checked = (.Item("Gender") = "Female")
                    txtTelephone.Text = .Item("Telephone_No")
                    txtAddress1.Text = .Item("Addressline_1")
                    txtAddress2.Text = .Item("Addressline_2")
                    txtAddress3.Text = .Item("Addressline_3")

                End With
            Else
                MessageBox.Show("Trainee not Found...!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub


    'Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
    '    Trainee.Show()
    'End Sub

    Private Sub btnGData_Click_1(sender As Object, e As EventArgs) Handles btnGData.Click
        chrDBCommand = "G"
        txtTNum.Focus()
        clearControls()
        Dim chrGender As String
        If Add.radMale.Checked = True Then
            chrGender = "Male"
        Else
            chrGender = "Female"
        End If

        txtTNum.Text = Add.txtTNum.Text
        txtRegDate.Text = Add.txtRegDate.Text
        txtNIC.Text = Add.txtNIC.Text
        txtName.Text = Add.txtName.Text
        txtDoB.Text = Add.txtDoB.Text
        txtAge.Text = Add.txtAge.Text
        radMale.Checked = chrGender = "Male"
        radFemale.Checked = chrGender = "Female"
        txtTelephone.Text = Add.txtTelephone.Text
        txtAddress1.Text = Add.txtAddress1.Text
        txtAddress2.Text = Add.txtAddress2.Text
        txtAddress3.Text = Add.txtAddress3.Text

        novalue()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        novalueChange()
        TraineeReport.Show()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub picTProfile_Enter(sender As Object, e As EventArgs) Handles picTProfile.Enter

    End Sub

    
End Class