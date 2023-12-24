<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingReport
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
        Me.components = New System.ComponentModel.Container()
        Me.TrainingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTMSDataSet = New My_Project.DTMSDataSet()
        Me.TrainingDetailsTableAdapter = New My_Project.DTMSDataSetTableAdapters.TrainingDetailsTableAdapter()
        Me.RP1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TrainingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrainingDetailsBindingSource
        '
        Me.TrainingDetailsBindingSource.DataMember = "TrainingDetails"
        Me.TrainingDetailsBindingSource.DataSource = Me.DTMSDataSet
        '
        'DTMSDataSet
        '
        Me.DTMSDataSet.DataSetName = "DTMSDataSet"
        Me.DTMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainingDetailsTableAdapter
        '
        Me.TrainingDetailsTableAdapter.ClearBeforeFill = True
        '
        'RP1
        '
        Me.RP1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RP1.Location = New System.Drawing.Point(143, 12)
        Me.RP1.Name = "RP1"
        Me.RP1.Size = New System.Drawing.Size(599, 453)
        Me.RP1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(6, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 47)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Training Report With Calculatoin"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(6, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 48)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Training Report"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(34, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TrainingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(754, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RP1)
        Me.Name = "TrainingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrainingReport"
        CType(Me.TrainingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrainingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTMSDataSet As My_Project.DTMSDataSet
    Friend WithEvents TrainingDetailsTableAdapter As My_Project.DTMSDataSetTableAdapters.TrainingDetailsTableAdapter
    Friend WithEvents RP1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
