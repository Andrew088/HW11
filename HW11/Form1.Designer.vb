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
        Me.Convert_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConverter = New System.Windows.Forms.TextBox()
        Me.BinaryOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Convert_btn
        '
        Me.Convert_btn.Location = New System.Drawing.Point(319, 335)
        Me.Convert_btn.Name = "Convert_btn"
        Me.Convert_btn.Size = New System.Drawing.Size(161, 55)
        Me.Convert_btn.TabIndex = 0
        Me.Convert_btn.Text = "Convert"
        Me.Convert_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "C4CS Decimal Converter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Andrew Wang (wangandr)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtConverter
        '
        Me.txtConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtConverter.Location = New System.Drawing.Point(37, 210)
        Me.txtConverter.Name = "txtConverter"
        Me.txtConverter.Size = New System.Drawing.Size(328, 41)
        Me.txtConverter.TabIndex = 2
        '
        'BinaryOutput
        '
        Me.BinaryOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.BinaryOutput.Location = New System.Drawing.Point(421, 210)
        Me.BinaryOutput.Name = "BinaryOutput"
        Me.BinaryOutput.Size = New System.Drawing.Size(328, 41)
        Me.BinaryOutput.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Decimal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(425, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Binary"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 530)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BinaryOutput)
        Me.Controls.Add(Me.txtConverter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Convert_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Convert_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConverter As TextBox
    Friend WithEvents BinaryOutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
