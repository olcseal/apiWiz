﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.rtbReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbReturn.Location = New System.Drawing.Point(0, 0)
        Me.rtbReturn.Name = "rtbReturn"
        Me.rtbReturn.Size = New System.Drawing.Size(800, 450)
        Me.rtbReturn.TabIndex = 0
        Me.rtbReturn.Text = "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmCallReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtbReturn)
        Me.Name = "frmCallReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call return"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbReturn As RichTextBox
End Class
