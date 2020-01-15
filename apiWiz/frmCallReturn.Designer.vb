<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCallReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rtbReturn = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbReturn
        '
        Me.rtbReturn.BackColor = System.Drawing.SystemColors.Window
        Me.rtbReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbReturn.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReturn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rtbReturn.Location = New System.Drawing.Point(0, 0)
        Me.rtbReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbReturn.Name = "rtbReturn"
        Me.rtbReturn.ReadOnly = True
        Me.rtbReturn.Size = New System.Drawing.Size(1067, 554)
        Me.rtbReturn.TabIndex = 0
        Me.rtbReturn.Text = "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmCallReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.rtbReturn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCallReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call return"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbReturn As RichTextBox
End Class
