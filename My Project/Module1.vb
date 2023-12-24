Imports System.Data.OleDb

Module Module1
    Public con As New OleDbConnection
    Sub main()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data SourceE:\My Project\DTMS.mdb"
        Dim Trainee As New Trainee
        Trainee.ShowDialog()

        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\model\My Project\DTMS.mdb"
        Dim Vehicle As New Vehicle
        Vehicle.ShowDialog()

        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\model\My Project\DTMS.mdb"
        Dim TrainingDetails As New TrainingDetails
        TrainingDetails.ShowDialog()
    End Sub
End Module
