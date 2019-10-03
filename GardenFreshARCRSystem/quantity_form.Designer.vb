<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quantity_form
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
        Me.btn_execute_process = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_quantity = New System.Windows.Forms.TextBox()
        Me.bn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_execute_process
        '
        Me.btn_execute_process.Location = New System.Drawing.Point(57, 81)
        Me.btn_execute_process.Name = "btn_execute_process"
        Me.btn_execute_process.Size = New System.Drawing.Size(75, 23)
        Me.btn_execute_process.TabIndex = 0
        Me.btn_execute_process.Text = "Go"
        Me.btn_execute_process.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantity:"
        '
        'tb_quantity
        '
        Me.tb_quantity.Location = New System.Drawing.Point(127, 45)
        Me.tb_quantity.Name = "tb_quantity"
        Me.tb_quantity.Size = New System.Drawing.Size(100, 20)
        Me.tb_quantity.TabIndex = 2
        Me.tb_quantity.Text = "0"
        Me.tb_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bn_cancel
        '
        Me.bn_cancel.Location = New System.Drawing.Point(152, 81)
        Me.bn_cancel.Name = "bn_cancel"
        Me.bn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.bn_cancel.TabIndex = 3
        Me.bn_cancel.Text = "Cancel"
        Me.bn_cancel.UseVisualStyleBackColor = True
        '
        'quantity_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 125)
        Me.ControlBox = False
        Me.Controls.Add(Me.bn_cancel)
        Me.Controls.Add(Me.tb_quantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_execute_process)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "quantity_form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "quantity_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_execute_process As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_quantity As TextBox
    Friend WithEvents bn_cancel As Button
End Class
