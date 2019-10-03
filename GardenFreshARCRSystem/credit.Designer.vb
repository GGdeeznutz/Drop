<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class credit
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcreditno = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdaddcustomer = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.txtsaleinv = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(531, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Credit no:"
        '
        'txtcreditno
        '
        Me.txtcreditno.Location = New System.Drawing.Point(650, 139)
        Me.txtcreditno.Name = "txtcreditno"
        Me.txtcreditno.Size = New System.Drawing.Size(154, 22)
        Me.txtcreditno.TabIndex = 55
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(87, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(422, 249)
        Me.DataGridView1.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(531, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Date:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(84, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Customer"
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(650, 195)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(175, 22)
        Me.txtcustomer.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Customer Name:"
        '
        'cmdaddcustomer
        '
        Me.cmdaddcustomer.Location = New System.Drawing.Point(682, 305)
        Me.cmdaddcustomer.Name = "cmdaddcustomer"
        Me.cmdaddcustomer.Size = New System.Drawing.Size(86, 35)
        Me.cmdaddcustomer.TabIndex = 74
        Me.cmdaddcustomer.Text = "Proceed"
        Me.cmdaddcustomer.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(154, 22)
        Me.TextBox2.TabIndex = 75
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(650, 241)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 22)
        Me.DateTimePicker1.TabIndex = 78
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(650, 12)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(154, 22)
        Me.txtcustomerid.TabIndex = 79
        '
        'txtsaleinv
        '
        Me.txtsaleinv.Location = New System.Drawing.Point(650, 40)
        Me.txtsaleinv.Name = "txtsaleinv"
        Me.txtsaleinv.Size = New System.Drawing.Size(154, 22)
        Me.txtsaleinv.TabIndex = 80
        '
        'credit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 490)
        Me.Controls.Add(Me.txtsaleinv)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.cmdaddcustomer)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcreditno)
        Me.Name = "credit"
        Me.Text = "Credit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcreditno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdaddcustomer As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents txtsaleinv As System.Windows.Forms.TextBox
End Class
