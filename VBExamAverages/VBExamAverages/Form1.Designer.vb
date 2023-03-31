<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Location = New System.Drawing.Point(137, 93)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(50, 16)
        Me.lblScore1.TabIndex = 0
        Me.lblScore1.Text = "Score1"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Location = New System.Drawing.Point(137, 153)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(53, 16)
        Me.lblScore2.TabIndex = 1
        Me.lblScore2.Text = "Score 2"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Location = New System.Drawing.Point(137, 220)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(53, 16)
        Me.lblScore3.TabIndex = 2
        Me.lblScore3.Text = "Score 3"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(137, 280)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(59, 16)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(394, 93)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(100, 22)
        Me.txtScore1.TabIndex = 4
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(394, 153)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 22)
        Me.txtScore2.TabIndex = 5
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(394, 217)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 22)
        Me.txtScore3.TabIndex = 6
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(441, 280)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(0, 16)
        Me.lblAvg.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(94, 352)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 56)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Average"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(303, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 56)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(501, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 56)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "AVERAGE SCORE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents lblAvg As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
