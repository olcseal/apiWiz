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
        Me.btnAddHist = New System.Windows.Forms.Button()
        Me.btnDelHist = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'urlTextBox
        '
        Me.urlTextBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urlTextBox.Location = New System.Drawing.Point(16, 89)
        Me.urlTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.urlTextBox.Name = "urlTextBox"
        Me.urlTextBox.Size = New System.Drawing.Size(477, 20)
        Me.urlTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X-Arbux-APIToken"
        '
        'tokenTextBox
        '
        Me.tokenTextBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokenTextBox.Location = New System.Drawing.Point(16, 137)
        Me.tokenTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.tokenTextBox.Name = "tokenTextBox"
        Me.tokenTextBox.Size = New System.Drawing.Size(477, 20)
        Me.tokenTextBox.TabIndex = 6
        '
        'buttonTry
        '
        Me.buttonTry.Location = New System.Drawing.Point(395, 169)
        Me.buttonTry.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTry.Name = "buttonTry"
        Me.buttonTry.Size = New System.Drawing.Size(100, 28)
        Me.buttonTry.TabIndex = 1
        Me.buttonTry.Text = "Try"
        Me.buttonTry.UseVisualStyleBackColor = True
        '
        'cmbLinks
        '
        Me.cmbLinks.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLinks.FormattingEnabled = True
        Me.cmbLinks.Location = New System.Drawing.Point(16, 230)
        Me.cmbLinks.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLinks.Name = "cmbLinks"
        Me.cmbLinks.Size = New System.Drawing.Size(367, 21)
        Me.cmbLinks.TabIndex = 9
        Me.cmbLinks.Visible = False
        '
        'lblEndpoints
        '
        Me.lblEndpoints.AutoSize = True
        Me.lblEndpoints.Location = New System.Drawing.Point(12, 210)
        Me.lblEndpoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndpoints.Name = "lblEndpoints"
        Me.lblEndpoints.Size = New System.Drawing.Size(127, 16)
        Me.lblEndpoints.TabIndex = 12
        Me.lblEndpoints.Text = "Available endpoints"
        Me.lblEndpoints.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.progBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 286)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(608, 24)
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
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(123, 23)
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
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(123, 23)
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
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(123, 23)
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
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(123, 23)
        Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Visible = False
        '
        'progBar1
        '
        Me.progBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.progBar1.Name = "progBar1"
        Me.progBar1.Size = New System.Drawing.Size(133, 22)
        Me.progBar1.Visible = False
        '
        'cmbHistory
        '
        Me.cmbHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHistory.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHistory.FormattingEnabled = True
        Me.cmbHistory.Location = New System.Drawing.Point(16, 34)
        Me.cmbHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHistory.Name = "cmbHistory"
        Me.cmbHistory.Size = New System.Drawing.Size(567, 21)
        Me.cmbHistory.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Saved Server/Token Pairs"
        '
        'radioGet
        '
        Me.radioGet.AutoSize = True
        Me.radioGet.Location = New System.Drawing.Point(420, 234)
        Me.radioGet.Margin = New System.Windows.Forms.Padding(4)
        Me.radioGet.Name = "radioGet"
        Me.radioGet.Size = New System.Drawing.Size(54, 20)
        Me.radioGet.TabIndex = 16
        Me.radioGet.TabStop = True
        Me.radioGet.Text = "GET"
        Me.radioGet.UseVisualStyleBackColor = True
        '
        'radioPost
        '
        Me.radioPost.AutoSize = True
        Me.radioPost.Location = New System.Drawing.Point(491, 235)
        Me.radioPost.Margin = New System.Windows.Forms.Padding(4)
        Me.radioPost.Name = "radioPost"
        Me.radioPost.Size = New System.Drawing.Size(63, 20)
        Me.radioPost.TabIndex = 17
        Me.radioPost.TabStop = True
        Me.radioPost.Text = "POST"
        Me.radioPost.UseVisualStyleBackColor = True
        '
        'buttonResetBase
        '
        Me.buttonResetBase.Location = New System.Drawing.Point(287, 169)
        Me.buttonResetBase.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonResetBase.Name = "buttonResetBase"
        Me.buttonResetBase.Size = New System.Drawing.Size(100, 28)
        Me.buttonResetBase.TabIndex = 18
        Me.buttonResetBase.Text = "Reset"
        Me.buttonResetBase.UseVisualStyleBackColor = True
        Me.buttonResetBase.Visible = False
        '
        'btnAddHist
        '
        Me.btnAddHist.Location = New System.Drawing.Point(16, 169)
        Me.btnAddHist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddHist.Name = "btnAddHist"
        Me.btnAddHist.Size = New System.Drawing.Size(45, 25)
        Me.btnAddHist.TabIndex = 19
        Me.btnAddHist.Text = "add"
        Me.btnAddHist.UseVisualStyleBackColor = True
        '
        'btnDelHist
        '
        Me.btnDelHist.Location = New System.Drawing.Point(69, 169)
        Me.btnDelHist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelHist.Name = "btnDelHist"
        Me.btnDelHist.Size = New System.Drawing.Size(41, 25)
        Me.btnDelHist.TabIndex = 20
        Me.btnDelHist.Text = "del"
        Me.btnDelHist.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 310)
        Me.Controls.Add(Me.btnDelHist)
        Me.Controls.Add(Me.btnAddHist)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnAddHist As Button
    Friend WithEvents btnDelHist As Button
End Class
