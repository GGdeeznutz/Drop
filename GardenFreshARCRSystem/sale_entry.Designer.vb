<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saleentry
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtprodsearch = New System.Windows.Forms.TextBox()
        Me.cmbadd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.txtremoveprod = New System.Windows.Forms.TextBox()
        Me.txtremovequan = New System.Windows.Forms.TextBox()
        Me.cmbremove = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtsalestype = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbconfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprodentrycode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtclassification = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsalesinv = New System.Windows.Forms.TextBox()
        Me.txtsalesntrycode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcredno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(437, 205)
        Me.DataGridView1.TabIndex = 53
        '
        'txtprodsearch
        '
        Me.txtprodsearch.Location = New System.Drawing.Point(34, 41)
        Me.txtprodsearch.Name = "txtprodsearch"
        Me.txtprodsearch.Size = New System.Drawing.Size(233, 22)
        Me.txtprodsearch.TabIndex = 55
        '
        'cmbadd
        '
        Me.cmbadd.Location = New System.Drawing.Point(830, 253)
        Me.cmbadd.Name = "cmbadd"
        Me.cmbadd.Size = New System.Drawing.Size(75, 40)
        Me.cmbadd.TabIndex = 2
        Me.cmbadd.Text = "Add"
        Me.cmbadd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtremoveprod)
        Me.Panel3.Controls.Add(Me.txtremovequan)
        Me.Panel3.Controls.Add(Me.cmbremove)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.txtsalestype)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cmbconfirm)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(34, 327)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 329)
        Me.Panel3.TabIndex = 1
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(830, 58)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(91, 22)
        Me.txtcustomerid.TabIndex = 85
        '
        'txtremoveprod
        '
        Me.txtremoveprod.Location = New System.Drawing.Point(131, 277)
        Me.txtremoveprod.Name = "txtremoveprod"
        Me.txtremoveprod.Size = New System.Drawing.Size(91, 22)
        Me.txtremoveprod.TabIndex = 84
        '
        'txtremovequan
        '
        Me.txtremovequan.Location = New System.Drawing.Point(228, 277)
        Me.txtremovequan.Name = "txtremovequan"
        Me.txtremovequan.Size = New System.Drawing.Size(91, 22)
        Me.txtremovequan.TabIndex = 83
        '
        'cmbremove
        '
        Me.cmbremove.Location = New System.Drawing.Point(794, 21)
        Me.cmbremove.Name = "cmbremove"
        Me.cmbremove.Size = New System.Drawing.Size(75, 42)
        Me.cmbremove.TabIndex = 71
        Me.cmbremove.Text = "Remove "
        Me.cmbremove.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(17, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(771, 222)
        Me.DataGridView2.TabIndex = 0
        '
        'txtsalestype
        '
        Me.txtsalestype.Location = New System.Drawing.Point(325, 277)
        Me.txtsalestype.Name = "txtsalestype"
        Me.txtsalestype.Size = New System.Drawing.Size(91, 22)
        Me.txtsalestype.TabIndex = 82
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(692, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TOTAL:"
        '
        'cmbconfirm
        '
        Me.cmbconfirm.Location = New System.Drawing.Point(747, 277)
        Me.cmbconfirm.Name = "cmbconfirm"
        Me.cmbconfirm.Size = New System.Drawing.Size(75, 40)
        Me.cmbconfirm.TabIndex = 69
        Me.cmbconfirm.Text = "Confirm"
        Me.cmbconfirm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Search:"
        '
        'txtprodentrycode
        '
        Me.txtprodentrycode.Location = New System.Drawing.Point(636, 163)
        Me.txtprodentrycode.Name = "txtprodentrycode"
        Me.txtprodentrycode.Size = New System.Drawing.Size(183, 22)
        Me.txtprodentrycode.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Description:"
        '
        'txtquan
        '
        Me.txtquan.Location = New System.Drawing.Point(636, 262)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(63, 22)
        Me.txtquan.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(513, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Quantity:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(513, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Prod Entry Code:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Sales Entry"
        '
        'txtclassification
        '
        Me.txtclassification.Location = New System.Drawing.Point(636, 226)
        Me.txtclassification.Name = "txtclassification"
        Me.txtclassification.Size = New System.Drawing.Size(183, 22)
        Me.txtclassification.TabIndex = 70
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(649, 1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 22)
        Me.DateTimePicker1.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Product Name:"
        '
        'txtprodname
        '
        Me.txtprodname.Location = New System.Drawing.Point(636, 191)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(183, 22)
        Me.txtprodname.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(513, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Invoice No:"
        '
        'txtsalesinv
        '
        Me.txtsalesinv.Location = New System.Drawing.Point(636, 132)
        Me.txtsalesinv.Name = "txtsalesinv"
        Me.txtsalesinv.Size = New System.Drawing.Size(183, 22)
        Me.txtsalesinv.TabIndex = 73
        '
        'txtsalesntrycode
        '
        Me.txtsalesntrycode.Location = New System.Drawing.Point(636, 93)
        Me.txtsalesntrycode.Name = "txtsalesntrycode"
        Me.txtsalesntrycode.Size = New System.Drawing.Size(183, 22)
        Me.txtsalesntrycode.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(513, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Sales Entry Code"
        '
        'txtcredno
        '
        Me.txtcredno.Location = New System.Drawing.Point(636, 29)
        Me.txtcredno.Name = "txtcredno"
        Me.txtcredno.Size = New System.Drawing.Size(183, 22)
        Me.txtcredno.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Credit no:"
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(636, 61)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(183, 22)
        Me.txtcustomername.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(513, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Customer name:"
        '
        'saleentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 668)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.txtcustomername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcredno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsalesntrycode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsalesinv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.txtclassification)
        Me.Controls.Add(Me.cmbadd)
        Me.Controls.Add(Me.txtprodsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtprodentrycode)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "saleentry"
        Me.Text = "Sales Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprodsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtprodentrycode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtquan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbremove As System.Windows.Forms.Button
    Friend WithEvents cmbadd As System.Windows.Forms.Button
    Friend WithEvents cmbconfirm As System.Windows.Forms.Button
    Friend WithEvents txtclassification As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprodname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsalesinv As System.Windows.Forms.TextBox
    Friend WithEvents txtsalesntrycode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcredno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsalestype As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents txtremoveprod As System.Windows.Forms.TextBox
    Friend WithEvents txtremovequan As System.Windows.Forms.TextBox
End Class
