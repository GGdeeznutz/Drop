<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_classification
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
        Me.txtclassdesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdaddclass = New System.Windows.Forms.Button()
        Me.txtclasscode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtclassdesc
        '
        Me.txtclassdesc.Location = New System.Drawing.Point(156, 163)
        Me.txtclassdesc.Name = "txtclassdesc"
        Me.txtclassdesc.Size = New System.Drawing.Size(135, 22)
        Me.txtclassdesc.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter Water Volume:"
        '
        'cmdaddclass
        '
        Me.cmdaddclass.Location = New System.Drawing.Point(167, 227)
        Me.cmdaddclass.Name = "cmdaddclass"
        Me.cmdaddclass.Size = New System.Drawing.Size(86, 35)
        Me.cmdaddclass.TabIndex = 23
        Me.cmdaddclass.Text = "Register"
        Me.cmdaddclass.UseVisualStyleBackColor = True
        '
        'txtclasscode
        '
        Me.txtclasscode.Location = New System.Drawing.Point(156, 115)
        Me.txtclasscode.Name = "txtclasscode"
        Me.txtclasscode.Size = New System.Drawing.Size(135, 22)
        Me.txtclasscode.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(333, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(507, 301)
        Me.DataGridView1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Classification Code:"
        '
        'add_classification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 418)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtclasscode)
        Me.Controls.Add(Me.cmdaddclass)
        Me.Controls.Add(Me.txtclassdesc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_classification"
        Me.Text = "add_classification"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtclassdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdaddclass As System.Windows.Forms.Button
    Friend WithEvents txtclasscode As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
