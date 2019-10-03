<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_customer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcustfname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcustlname = New System.Windows.Forms.TextBox()
        Me.txtcustadd = New System.Windows.Forms.TextBox()
        Me.txtcustcontact = New System.Windows.Forms.TextBox()
        Me.cmbaddcustomer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Firstname:"
        '
        'txtcustfname
        '
        Me.txtcustfname.Location = New System.Drawing.Point(174, 89)
        Me.txtcustfname.Name = "txtcustfname"
        Me.txtcustfname.Size = New System.Drawing.Size(183, 22)
        Me.txtcustfname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lastname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Contact_no"
        '
        'txtcustlname
        '
        Me.txtcustlname.Location = New System.Drawing.Point(174, 138)
        Me.txtcustlname.Name = "txtcustlname"
        Me.txtcustlname.Size = New System.Drawing.Size(183, 22)
        Me.txtcustlname.TabIndex = 9
        '
        'txtcustadd
        '
        Me.txtcustadd.Location = New System.Drawing.Point(174, 184)
        Me.txtcustadd.Name = "txtcustadd"
        Me.txtcustadd.Size = New System.Drawing.Size(244, 22)
        Me.txtcustadd.TabIndex = 10
        '
        'txtcustcontact
        '
        Me.txtcustcontact.Location = New System.Drawing.Point(174, 230)
        Me.txtcustcontact.Name = "txtcustcontact"
        Me.txtcustcontact.Size = New System.Drawing.Size(158, 22)
        Me.txtcustcontact.TabIndex = 12
        '
        'cmbaddcustomer
        '
        Me.cmbaddcustomer.Location = New System.Drawing.Point(211, 300)
        Me.cmbaddcustomer.Name = "cmbaddcustomer"
        Me.cmbaddcustomer.Size = New System.Drawing.Size(86, 35)
        Me.cmbaddcustomer.TabIndex = 13
        Me.cmbaddcustomer.Text = "Register"
        Me.cmbaddcustomer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(443, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(548, 326)
        Me.DataGridView1.TabIndex = 14
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(174, 50)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(183, 22)
        Me.txtcustid.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Customer ID:"
        '
        'add_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 558)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbaddcustomer)
        Me.Controls.Add(Me.txtcustcontact)
        Me.Controls.Add(Me.txtcustadd)
        Me.Controls.Add(Me.txtcustlname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcustfname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_customer"
        Me.Text = "add_customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcustfname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcustlname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustadd As System.Windows.Forms.TextBox
    Friend WithEvents txtcustcontact As System.Windows.Forms.TextBox
    Friend WithEvents cmbaddcustomer As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
