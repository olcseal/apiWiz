Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Form1
    Public endpointDict As Dictionary(Of String, String)
    Public metaDict As Dictionary(Of String, String)
    Public responseFromServer As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bypass SSL Cert Validation
        ServicePointManager.ServerCertificateValidationCallback =
                    Function(se As Object,
                             cert As System.Security.Cryptography.X509Certificates.X509Certificate,
                             chain As System.Security.Cryptography.X509Certificates.X509Chain,
                             sslerror As System.Net.Security.SslPolicyErrors) True
        Dim pairHistory As Dictionary(Of String, String) = HistoryToDict()
        For Each item In pairHistory
            cmbHistory.Items.Add(item.Value + " | " + item.Key)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonTry.Click
        cmbLinks.Items.Clear()
        Try
            Dim request As WebRequest = WebRequest.Create(urlTextBox.Text)
            request.Headers.Set("X-Arbux-APIToken", tokenTextBox.Text)
            Dim response As WebResponse = request.GetResponse()
            TextBox2.Text = CType(response, HttpWebResponse).StatusDescription
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            responseFromServer = reader.ReadToEnd()
            Dim baseList = JsonConvert.DeserializeObject(Of Object)(responseFromServer)
            endpointDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("links").ToString)
            metaDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("meta").ToString)
            reader.Close()
            response.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Oops!!")
        End Try
        For Each item In endpointDict
            cmbLinks.Items.Add(item.Key.ToString)
        Next
        lblEndpoints.Visible = True
        cmbLinks.Visible = True
        ToolStripStatusLabel2.Text = "Endpoints loaded!"
        ToolStripStatusLabel3.Text = "api: " + metaDict("api")
        ToolStripStatusLabel3.Visible = True
        ToolStripStatusLabel4.Text = "api ver: " + metaDict("api_version")
        ToolStripStatusLabel4.Visible = True
        ToolStripStatusLabel5.Text = "build: " + metaDict("sp_build_id")
        ToolStripStatusLabel5.Visible = True
        ToolStripStatusLabel6.Text = "sp ver: " + metaDict("sp_version")
        ToolStripStatusLabel6.Visible = True
        Dim currentCallReturn As New frmCallReturn
        currentCallReturn.Text = urlTextBox.Text
        currentCallReturn.SetCallReturn = responseFromServer
        currentCallReturn.Show()
    End Sub

    Private Sub cmbLinks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLinks.SelectedIndexChanged
        urlTextBox.Text = endpointDict(cmbLinks.SelectedItem)
    End Sub

    Private Sub cmbHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHistory.SelectedIndexChanged
        Dim selection = cmbHistory.SelectedItem
        Dim selArray() As String = Split(selection, " | ")
        urlTextBox.Text = selArray(0)
        tokenTextBox.Text = selArray(1)
    End Sub



    '=========
    'FUNCTIONS
    '=========

    'Get historical server/api token pairs from hash.dat file
    'and return a dictionary
    Private Function HistoryToDict()
        Dim serverPair As New Dictionary(Of String, String)
        Dim FILE_NAME As String = "hash.dat"
        If IO.File.Exists(FILE_NAME) Then
            Using sr As New IO.StreamReader(FILE_NAME)
                While Not sr.EndOfStream
                    serverPair.Add(sr.ReadLine, sr.ReadLine)
                End While
            End Using
        Else
            MsgBox("Error loading history items!")
        End If
        Return serverPair
    End Function

End Class
