<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTraineeReport = New System.Windows.Forms.Button()
        Me.btnTrainingReport = New System.Windows.Forms.Button()
        Me.btnVehicleReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTraineeReport
        '
        Me.btnTraineeReport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnTraineeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraineeReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTraineeReport.Location = New System.Drawing.Point(276, 152)
        Me.btnTraineeReport.Name = "btnTraineeReport"
        Me.btnTraineeReport.Size = New System.Drawing.Size(200, 43)
        Me.btnTraineeReport.TabIndex = 0
        Me.btnTraineeReport.Text = "Trainee Report"
        Me.btnTraineeReport.UseVisualStyleBackColor = False
        '
        'btnTrainingReport
        '
        Me.btnTrainingReport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnTrainingReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainingReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTrainingReport.Location = New System.Drawing.Point(276, 210)
        Me.btnTrainingReport.Name = "btnTrainingReport"
        Me.btnTrainingReport.Size = New System.Drawing.Size(200, 43)
        Me.btnTrainingReport.TabIndex = 1
        Me.btnTrainingReport.Text = "Training Report"
        Me.btnTrainingReport.UseVisualStyleBackColor = False
        '
        'btnVehicleReport
        '
        Me.btnVehicleReport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnVehicleReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVehicleReport.Location = New System.Drawing.Point(276, 262)
        Me.btnVehicleReport.Name = "btnVehicleReport"
        Me.btnVehicleReport.Size = New System.Drawing.Size(200, 43)
        Me.btnVehicleReport.TabIndex = 2
        Me.btnVehicleReport.Text = "Vehicle Report"
        Me.btnVehicleReport.UseVisualStyleBackColor = False
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(770, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVehicleReport)
        Me.Controls.Add(Me.btnTrainingReport)
        Me.Controls.Add(Me.btnTraineeReport)
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTraineeReport As System.Windows.Forms.Button
    Friend WithEvents btnTrainingReport As System.Windows.Forms.Button
    Friend WithEvents btnVehicleReport As System.Windows.Forms.Button
End Class
