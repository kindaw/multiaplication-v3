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
        Me.But_1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nud_1 = New System.Windows.Forms.NumericUpDown()
        Me.Nud_2 = New System.Windows.Forms.NumericUpDown()
        Me.Nud_3 = New System.Windows.Forms.NumericUpDown()
        Me.Nud_4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Nud_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'But_1
        '
        Me.But_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.But_1.Location = New System.Drawing.Point(12, 284)
        Me.But_1.Name = "But_1"
        Me.But_1.Size = New System.Drawing.Size(128, 48)
        Me.But_1.TabIndex = 3
        Me.But_1.Text = "คำนวน"
        Me.But_1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "โปรแกรมแสดงตารางสูตรคูณ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "สูตรคูณแม่"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เรื่มต้น"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "สิ้นสุด"
        '
        'Nud_1
        '
        Me.Nud_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_1.Location = New System.Drawing.Point(170, 58)
        Me.Nud_1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Nud_1.Name = "Nud_1"
        Me.Nud_1.Size = New System.Drawing.Size(113, 31)
        Me.Nud_1.TabIndex = 8
        Me.Nud_1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Nud_2
        '
        Me.Nud_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Nud_2.Location = New System.Drawing.Point(170, 161)
        Me.Nud_2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Nud_2.Name = "Nud_2"
        Me.Nud_2.Size = New System.Drawing.Size(113, 32)
        Me.Nud_2.TabIndex = 9
        Me.Nud_2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Nud_3
        '
        Me.Nud_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Nud_3.Location = New System.Drawing.Point(170, 213)
        Me.Nud_3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Nud_3.Name = "Nud_3"
        Me.Nud_3.Size = New System.Drawing.Size(113, 32)
        Me.Nud_3.TabIndex = 10
        Me.Nud_3.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Nud_4
        '
        Me.Nud_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Nud_4.Location = New System.Drawing.Point(170, 112)
        Me.Nud_4.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Nud_4.Name = "Nud_4"
        Me.Nud_4.Size = New System.Drawing.Size(113, 32)
        Me.Nud_4.TabIndex = 11
        Me.Nud_4.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 33)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "สูตรคูณสิ้นสุด"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 356)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nud_4)
        Me.Controls.Add(Me.Nud_3)
        Me.Controls.Add(Me.Nud_2)
        Me.Controls.Add(Me.Nud_1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.But_1)
        Me.Name = "Form1"
        Me.Text = "Multiplication"
        CType(Me.Nud_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents But_1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Nud_1 As NumericUpDown
    Friend WithEvents Nud_2 As NumericUpDown
    Friend WithEvents Nud_3 As NumericUpDown
    Friend WithEvents Nud_4 As NumericUpDown
    Friend WithEvents Label5 As Label
End Class
