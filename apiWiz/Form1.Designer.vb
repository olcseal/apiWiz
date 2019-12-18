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
        Me.urlTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tokenTextBox = New System.Windows.Forms.TextBox()
        Me.buttonTry = New System.Windows.Forms.Button()
        Me.cmbLinks = New System.Windows.Forms.ComboBox()
        Me.lblEndpoints = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmbHistory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radioGet = New System.Windows.Forms.RadioButton()
        Me.radioPost = New System.Windows.Forms.RadioButton()
        Me.buttonResetBase = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(394, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'urlTextBox
        '
        Me.urlTextBox.Location = New System.Drawing.Point(12, 72)
        Me.urlTextBox.Name = "urlTextBox"
        Me.urlTextBox.Size = New System.Drawing.Size(359, 20)
        Me.urlTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X-Arbux-APIToken"
        '
        'tokenTextBox
        '
        Me.tokenTextBox.Location = New System.Drawing.Point(12, 111)
        Me.tokenTextBox.Name = "tokenTextBox"
        Me.tokenTextBox.Size = New System.Drawing.Size(359, 20)
        Me.tokenTextBox.TabIndex = 6
        '
        'buttonTry
        '
        Me.buttonTry.Location = New System.Drawing.Point(296, 137)
        Me.buttonTry.Name = "buttonTry"
        Me.buttonTry.Size = New System.Drawing.Size(75, 23)
        Me.buttonTry.TabIndex = 1
        Me.buttonTry.Text = "Try"
        Me.buttonTry.UseVisualStyleBackColor = True
        '
        'cmbLinks
        '
        Me.cmbLinks.FormattingEnabled = True
        Me.cmbLinks.Location = New System.Drawing.Point(12, 187)
        Me.cmbLinks.Name = "cmbLinks"
        Me.cmbLinks.Size = New System.Drawing.Size(276, 21)
        Me.cmbLinks.TabIndex = 9
        Me.cmbLinks.Visible = False
        '
        'lblEndpoints
        '
        Me.lblEndpoints.AutoSize = True
        Me.lblEndpoints.Location = New System.Drawing.Point(9, 171)
        Me.lblEndpoints.Name = "lblEndpoints"
        Me.lblEndpoints.Size = New System.Drawing.Size(99, 13)
        Me.lblEndpoints.TabIndex = 12
        Me.lblEndpoints.Text = "Available endpoints"
        Me.lblEndpoints.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.progBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 255)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(456, 24)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(30, 19)
        Me.ToolStripStatusLabel2.Text = "idle"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(123, 19)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(123, 19)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Visible = False
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(123, 19)
        Me.ToolStripStatusLabel5.Text = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Visible = False
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(123, 19)
        Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Visible = False
        '
        'progBar1
        '
        Me.progBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.progBar1.Name = "progBar1"
        Me.progBar1.Size = New System.Drawing.Size(100, 18)
        Me.progBar1.Visible = False
        '
        'cmbHistory
        '
        Me.cmbHistory.FormattingEnabled = True
        Me.cmbHistory.Location = New System.Drawing.Point(12, 28)
        Me.cmbHistory.Name = "cmbHistory"
        Me.cmbHistory.Size = New System.Drawing.Size(426, 21)
        Me.cmbHistory.TabIndex = 14
        Me.cmbHistory.Text = "Select to view previously used server pairs..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Saved Server/Token Pairs"
        '
        'radioGet
        '
        Me.radioGet.AutoSize = True
        Me.radioGet.Location = New System.Drawing.Point(315, 190)
        Me.radioGet.Name = "radioGet"
        Me.radioGet.Size = New System.Drawing.Size(47, 17)
        Me.radioGet.TabIndex = 16
        Me.radioGet.TabStop = True
        Me.radioGet.Text = "GET"
        Me.radioGet.UseVisualStyleBackColor = True
        '
        'radioPost
        '
        Me.radioPost.AutoSize = True
        Me.radioPost.Location = New System.Drawing.Point(368, 191)
        Me.radioPost.Name = "radioPost"
        Me.radioPost.Size = New System.Drawing.Size(54, 17)
        Me.radioPost.TabIndex = 17
        Me.radioPost.TabStop = True
        Me.radioPost.Text = "POST"
        Me.radioPost.UseVisualStyleBackColor = True
        '
        'buttonResetBase
        '
        Me.buttonResetBase.Location = New System.Drawing.Point(215, 137)
        Me.buttonResetBase.Name = "buttonResetBase"
        Me.buttonResetBase.Size = New System.Drawing.Size(75, 23)
        Me.buttonResetBase.TabIndex = 18
        Me.buttonResetBase.Text = "Reset"
        Me.buttonResetBase.UseVisualStyleBackColor = True
        Me.buttonResetBase.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 279)
        Me.Controls.Add(Me.buttonResetBase)
        Me.Controls.Add(Me.radioPost)
        Me.Controls.Add(Me.radioGet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbHistory)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblEndpoints)
        Me.Controls.Add(Me.cmbLinks)
        Me.Controls.Add(Me.buttonTry)
        Me.Controls.Add(Me.tokenTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.urlTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents urlTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tokenTextBox As TextBox
    Friend WithEvents buttonTry As Button
    Friend WithEvents cmbLinks As ComboBox
    Friend WithEvents lblEndpoints As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents progBar1 As ToolStripProgressBar
    Friend WithEvents cmbHistory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents radioGet As RadioButton
    Friend WithEvents radioPost As RadioButton
    Friend WithEvents buttonResetBase As Button
End Class
