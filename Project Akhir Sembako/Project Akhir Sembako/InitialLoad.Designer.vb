<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialLoad
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.LoadingTxt = New System.Windows.Forms.Label()
        Me.ProgressTxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(75, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TOKO SEMBAKO RASID"
        '
        'PB1
        '
        Me.PB1.Location = New System.Drawing.Point(29, 73)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(401, 28)
        Me.PB1.TabIndex = 4
        '
        'LoadingTxt
        '
        Me.LoadingTxt.AutoSize = True
        Me.LoadingTxt.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LoadingTxt.ForeColor = System.Drawing.Color.Black
        Me.LoadingTxt.Location = New System.Drawing.Point(24, 104)
        Me.LoadingTxt.Name = "LoadingTxt"
        Me.LoadingTxt.Size = New System.Drawing.Size(95, 28)
        Me.LoadingTxt.TabIndex = 5
        Me.LoadingTxt.Text = "Loading..."
        '
        'ProgressTxt
        '
        Me.ProgressTxt.AutoSize = True
        Me.ProgressTxt.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.ProgressTxt.ForeColor = System.Drawing.Color.Black
        Me.ProgressTxt.Location = New System.Drawing.Point(388, 104)
        Me.ProgressTxt.Name = "ProgressTxt"
        Me.ProgressTxt.Size = New System.Drawing.Size(50, 28)
        Me.ProgressTxt.TabIndex = 6
        Me.ProgressTxt.Text = "00%"
        '
        'InitialLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 160)
        Me.Controls.Add(Me.ProgressTxt)
        Me.Controls.Add(Me.LoadingTxt)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InitialLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PB1 As ProgressBar
    Friend WithEvents LoadingTxt As Label
    Friend WithEvents ProgressTxt As Label
End Class
