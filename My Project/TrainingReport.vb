Public Class TrainingReport
    Sub Switchpanel(ByVal Panel As Form)

        RP1.Controls.Clear()
        Panel.TopLevel = False
        RP1.Controls.Add(Panel)

        Panel.Show()

    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Switchpanel(TrainingReportMainTrainee)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(TrainingWithCal)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class