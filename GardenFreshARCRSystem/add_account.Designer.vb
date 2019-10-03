<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_account
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
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdaccreg = New System.Windows.Forms.Button()
        Me.txtacccode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(178, 186)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(160, 22)
        Me.txtpass.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(178, 137)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(160, 22)
        Me.txtuser.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username:"
        '
        'cmblevel
        '
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"Admin", "Staffr"})
        Me.cmblevel.Location = New System.Drawing.Point(178, 239)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(121, 24)
        Me.cmblevel.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Level:"
        '
        'cmdaccreg
        '
        Me.cmdaccreg.Location = New System.Drawing.Point(178, 301)
        Me.cmdaccreg.Name = "cmdaccreg"
        Me.cmdaccreg.Size = New System.Drawing.Size(86, 35)
        Me.cmdaccreg.TabIndex = 16
        Me.cmdaccreg.Text = "Register"
        Me.cmdaccreg.UseVisualStyleBackColor = True
        '
        'txtacccode
        '
        Me.txtacccode.Location = New System.Drawing.Point(178, 74)
        Me.txtacccode.Name = "txtacccode"
        Me.txtacccode.Size = New System.Drawing.Size(160, 22)
        Me.txtacccode.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(367, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(416, 298)
        Me.DataGridView1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Account Code:"
        '
        'add_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 409)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtacccode)
        Me.Controls.Add(Me.cmdaccreg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmblevel)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_account"
        Me.Text = "add_account"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmblevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdaccreg As System.Windows.Forms.Button
    Friend WithEvents txtacccode As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
