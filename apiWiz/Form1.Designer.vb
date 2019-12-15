<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.urlTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tokenTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.apiInfoGbox = New System.Windows.Forms.GroupBox()
        Me.lblSpVersion = New System.Windows.Forms.Label()
        Me.lblSpBuild = New System.Windows.Forms.Label()
        Me.lblApiVersion = New System.Windows.Forms.Label()
        Me.lblApi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLinks = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.apiInfoGbox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(776, 460)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'urlTextBox
        '
        Me.urlTextBox.Location = New System.Drawing.Point(12, 28)
        Me.urlTextBox.Name = "urlTextBox"
        Me.urlTextBox.Size = New System.Drawing.Size(270, 20)
        Me.urlTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X-Arbux-APIToken"
        '
        'tokenTextBox
        '
        Me.tokenTextBox.Location = New System.Drawing.Point(12, 67)
        Me.tokenTextBox.Name = "tokenTextBox"
        Me.tokenTextBox.Size = New System.Drawing.Size(270, 20)
        Me.tokenTextBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Try"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'apiInfoGbox
        '
        Me.apiInfoGbox.Controls.Add(Me.lblSpVersion)
        Me.apiInfoGbox.Controls.Add(Me.lblSpBuild)
        Me.apiInfoGbox.Controls.Add(Me.lblApiVersion)
        Me.apiInfoGbox.Controls.Add(Me.lblApi)
        Me.apiInfoGbox.Controls.Add(Me.Label6)
        Me.apiInfoGbox.Controls.Add(Me.Label5)
        Me.apiInfoGbox.Controls.Add(Me.Label4)
        Me.apiInfoGbox.Controls.Add(Me.Label3)
        Me.apiInfoGbox.Location = New System.Drawing.Point(625, 12)
        Me.apiInfoGbox.Name = "apiInfoGbox"
        Me.apiInfoGbox.Size = New System.Drawing.Size(163, 101)
        Me.apiInfoGbox.TabIndex = 8
        Me.apiInfoGbox.TabStop = False
        Me.apiInfoGbox.Text = "API Info"
        Me.apiInfoGbox.Visible = False
        '
        'lblSpVersion
        '
        Me.lblSpVersion.AutoSize = True
        Me.lblSpVersion.Location = New System.Drawing.Point(79, 74)
        Me.lblSpVersion.Name = "lblSpVersion"
        Me.lblSpVersion.Size = New System.Drawing.Size(24, 13)
        Me.lblSpVersion.TabIndex = 7
        Me.lblSpVersion.Text = "text"
        '
        'lblSpBuild
        '
        Me.lblSpBuild.AutoSize = True
        Me.lblSpBuild.Location = New System.Drawing.Point(79, 57)
        Me.lblSpBuild.Name = "lblSpBuild"
        Me.lblSpBuild.Size = New System.Drawing.Size(24, 13)
        Me.lblSpBuild.TabIndex = 6
        Me.lblSpBuild.Text = "text"
        '
        'lblApiVersion
        '
        Me.lblApiVersion.AutoSize = True
        Me.lblApiVersion.Location = New System.Drawing.Point(79, 40)
        Me.lblApiVersion.Name = "lblApiVersion"
        Me.lblApiVersion.Size = New System.Drawing.Size(24, 13)
        Me.lblApiVersion.TabIndex = 5
        Me.lblApiVersion.Text = "text"
        '
        'lblApi
        '
        Me.lblApi.AutoSize = True
        Me.lblApi.Location = New System.Drawing.Point(78, 23)
        Me.lblApi.Name = "lblApi"
        Me.lblApi.Size = New System.Drawing.Size(24, 13)
        Me.lblApi.TabIndex = 4
        Me.lblApi.Text = "text"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "sp version:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "sp build:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "api version:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "api:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLinks
        '
        Me.cmbLinks.FormattingEnabled = True
        Me.cmbLinks.Location = New System.Drawing.Point(302, 28)
        Me.cmbLinks.Name = "cmbLinks"
        Me.cmbLinks.Size = New System.Drawing.Size(276, 21)
        Me.cmbLinks.TabIndex = 9
        Me.cmbLinks.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 460)
        Me.Panel1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 599)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbLinks)
        Me.Controls.Add(Me.apiInfoGbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tokenTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.urlTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.apiInfoGbox.ResumeLayout(False)
        Me.apiInfoGbox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents urlTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tokenTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents apiInfoGbox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSpVersion As Label
    Friend WithEvents lblSpBuild As Label
    Friend WithEvents lblApiVersion As Label
    Friend WithEvents lblApi As Label
    Friend WithEvents cmbLinks As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
