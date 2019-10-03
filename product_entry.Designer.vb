<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product_entry
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
        Me.txtprodentryquantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprodentryprodname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbprodclass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprodentrycode = New System.Windows.Forms.TextBox()
        Me.txtprodcode = New System.Windows.Forms.TextBox()
        Me.cmbprodentryreg = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprodentryquantity
        '
        Me.txtprodentryquantity.Location = New System.Drawing.Point(436, 253)
        Me.txtprodentryquantity.Name = "txtprodentryquantity"
        Me.txtprodentryquantity.Size = New System.Drawing.Size(91, 22)
        Me.txtprodentryquantity.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Quantity:"
        '
        'txtprodentryprodname
        '
        Me.txtprodentryprodname.Location = New System.Drawing.Point(436, 166)
        Me.txtprodentryprodname.Name = "txtprodentryprodname"
        Me.txtprodentryprodname.Size = New System.Drawing.Size(183, 22)
        Me.txtprodentryprodname.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Product Name:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(436, 301)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 22)
        Me.DateTimePicker1.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(280, 299)
        Me.DataGridView1.TabIndex = 34
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(708, 84)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(306, 299)
        Me.DataGridView2.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Products"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(705, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Finished Products"
        '
        'cmbprodclass
        '
        Me.cmbprodclass.FormattingEnabled = True
        Me.cmbprodclass.Location = New System.Drawing.Point(436, 212)
        Me.cmbprodclass.Name = "cmbprodclass"
        Me.cmbprodclass.Size = New System.Drawing.Size(169, 24)
        Me.cmbprodclass.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Classification:"
        '
        'txtprodentrycode
        '
        Me.txtprodentrycode.Location = New System.Drawing.Point(436, 122)
        Me.txtprodentrycode.Name = "txtprodentrycode"
        Me.txtprodentrycode.Size = New System.Drawing.Size(183, 22)
        Me.txtprodentrycode.TabIndex = 40
        '
        'txtprodcode
        '
        Me.txtprodcode.Location = New System.Drawing.Point(436, 84)
        Me.txtprodcode.Name = "txtprodcode"
        Me.txtprodcode.Size = New System.Drawing.Size(183, 22)
        Me.txtprodcode.TabIndex = 41
        '
        'cmbprodentryreg
        '
        Me.cmbprodentryreg.Location = New System.Drawing.Point(470, 360)
        Me.cmbprodentryreg.Name = "cmbprodentryreg"
        Me.cmbprodentryreg.Size = New System.Drawing.Size(86, 35)
        Me.cmbprodentryreg.TabIndex = 42
        Me.cmbprodentryreg.Text = "Register"
        Me.cmbprodentryreg.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Product Entry Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Product Code:"
        '
        'product_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 571)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbprodentryreg)
        Me.Controls.Add(Me.txtprodcode)
        Me.Controls.Add(Me.txtprodentrycode)
        Me.Controls.Add(Me.cmbprodclass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtprodentryquantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtprodentryprodname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "product_entry"
        Me.Text = "-"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprodentryprodname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprodentryquantity As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbprodclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprodentrycode As System.Windows.Forms.TextBox
    Friend WithEvents txtprodcode As System.Windows.Forms.TextBox
    Friend WithEvents cmbprodentryreg As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
