<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_product
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
        Me.txtprodprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdprodreg = New System.Windows.Forms.Button()
        Me.txtprodid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprodprice
        '
        Me.txtprodprice.Location = New System.Drawing.Point(160, 153)
        Me.txtprodprice.Name = "txtprodprice"
        Me.txtprodprice.Size = New System.Drawing.Size(91, 22)
        Me.txtprodprice.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Price:"
        '
        'txtprodname
        '
        Me.txtprodname.Location = New System.Drawing.Point(160, 98)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(159, 22)
        Me.txtprodname.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product Name:"
        '
        'cmdprodreg
        '
        Me.cmdprodreg.Location = New System.Drawing.Point(179, 222)
        Me.cmdprodreg.Name = "cmdprodreg"
        Me.cmdprodreg.Size = New System.Drawing.Size(86, 35)
        Me.cmdprodreg.TabIndex = 22
        Me.cmdprodreg.Text = "Register"
        Me.cmdprodreg.UseVisualStyleBackColor = True
        '
        'txtprodid
        '
        Me.txtprodid.Location = New System.Drawing.Point(160, 55)
        Me.txtprodid.Name = "txtprodid"
        Me.txtprodid.Size = New System.Drawing.Size(159, 22)
        Me.txtprodid.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(495, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(366, 280)
        Me.DataGridView1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Product Code:"
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 362)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtprodid)
        Me.Controls.Add(Me.cmdprodreg)
        Me.Controls.Add(Me.txtprodprice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_product"
        Me.Text = "Add Product"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtprodprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprodname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdprodreg As System.Windows.Forms.Button
    Friend WithEvents txtprodid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
