﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraineeReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TraineeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTMSDataSet = New My_Project.DTMSDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TraineeTableAdapter = New My_Project.DTMSDataSetTableAdapters.TraineeTableAdapter()
        CType(Me.TraineeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TraineeBindingSource
        '
        Me.TraineeBindingSource.DataMember = "Trainee"
        Me.TraineeBindingSource.DataSource = Me.DTMSDataSet
        '
        'DTMSDataSet
        '
        Me.DTMSDataSet.DataSetName = "DTMSDataSet"
        Me.DTMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TraineeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "My_Project.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(754, 477)
        Me.ReportViewer1.TabIndex = 0
        '
        'TraineeTableAdapter
        '
        Me.TraineeTableAdapter.ClearBeforeFill = True
        '
        'TraineeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 477)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TraineeReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TraineeReport"
        CType(Me.TraineeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TraineeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTMSDataSet As My_Project.DTMSDataSet
    Friend WithEvents TraineeTableAdapter As My_Project.DTMSDataSetTableAdapters.TraineeTableAdapter
End Class
