﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SWEEP
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SweepEnable = New System.Windows.Forms.Button()
        Me.SweepSteps = New System.Windows.Forms.TextBox()
        Me.SweepStop = New System.Windows.Forms.TextBox()
        Me.SweepStart = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(31, 24)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(501, 257)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Steps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Stop:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Start:"
        '
        'SweepEnable
        '
        Me.SweepEnable.Location = New System.Drawing.Point(406, 410)
        Me.SweepEnable.Name = "SweepEnable"
        Me.SweepEnable.Size = New System.Drawing.Size(145, 35)
        Me.SweepEnable.TabIndex = 155
        Me.SweepEnable.Text = "Sweep"
        Me.SweepEnable.UseVisualStyleBackColor = True
        '
        'SweepSteps
        '
        Me.SweepSteps.Location = New System.Drawing.Point(168, 408)
        Me.SweepSteps.Name = "SweepSteps"
        Me.SweepSteps.Size = New System.Drawing.Size(100, 20)
        Me.SweepSteps.TabIndex = 154
        Me.SweepSteps.Text = "25"
        '
        'SweepStop
        '
        Me.SweepStop.Location = New System.Drawing.Point(168, 388)
        Me.SweepStop.Name = "SweepStop"
        Me.SweepStop.Size = New System.Drawing.Size(100, 20)
        Me.SweepStop.TabIndex = 153
        Me.SweepStop.Text = "25000"
        '
        'SweepStart
        '
        Me.SweepStart.Location = New System.Drawing.Point(168, 368)
        Me.SweepStart.Name = "SweepStart"
        Me.SweepStart.Size = New System.Drawing.Size(100, 20)
        Me.SweepStart.TabIndex = 152
        Me.SweepStart.Text = "10"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(610, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 159
        '
        'F_SWEEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 481)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SweepEnable)
        Me.Controls.Add(Me.SweepSteps)
        Me.Controls.Add(Me.SweepStop)
        Me.Controls.Add(Me.SweepStart)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "F_SWEEP"
        Me.Text = "F_SWEEP"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SweepEnable As Button
    Friend WithEvents SweepSteps As TextBox
    Friend WithEvents SweepStop As TextBox
    Friend WithEvents SweepStart As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
