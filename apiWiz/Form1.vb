Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Form1
    Public endpointDict As Dictionary(Of String, String)
    Public metaDict As Dictionary(Of String, String)
    Public baseResponse As String

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
        Cursor = Cursors.WaitCursor
        cmbLinks.Items.Clear()
        'Try
        '    Dim request As WebRequest = WebRequest.Create(urlTextBox.Text)
        '    request.Headers.Set("X-Arbux-APIToken", tokenTextBox.Text)
        '    Dim response As WebResponse = request.GetResponse()
        '    TextBox2.Text = CType(response, HttpWebResponse).StatusDescription
        '    Dim dataStream As Stream = response.GetResponseStream()
        '    Dim reader As New StreamReader(dataStream)
        '    responseFromServer = reader.ReadToEnd()
        '    Dim baseList = JsonConvert.DeserializeObject(Of Object)(responseFromServer)
        '    'Dim returnJson As JObject = JObject.Parse(responseFromServer)
        '    endpointDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("links").ToString)
        '    'Dim strRelated = returnJson.SelectToken("data.relationships.annotations.data.links.related").ToString
        '    metaDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("meta").ToString)
        '    reader.Close()
        '    response.Close()
        'Catch ex As Exception
        '    Cursor = Cursors.Default
        '    MsgBox(ex.Message, 0, "Oops!!")
        'End Try

        Try
            baseResponse = GetResponse(urlTextBox.Text, tokenTextBox.Text)
            Dim desBaseResponse = JsonConvert.DeserializeObject(Of Object)(baseResponse)
            endpointDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(desBaseResponse("links").ToString)
            metaDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(desBaseResponse("meta").ToString)
        Catch ex As Exception
            Cursor = Cursors.Default
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
        currentCallReturn.SetCallReturn = baseResponse
        currentCallReturn.Show()
        Cursor = Cursors.Default
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

    '==============
    'NON-EVENT SUBS
    '==============

    'Save current server/api token pair dictionary to disk.
    Private Sub DictToFile(history As Dictionary(Of String, String))
        Dim sb As New StringBuilder()

        For Each item In history
            sb.AppendFormat("{0}{1}{2}{3}", item.Key, Environment.NewLine, item.Value, Environment.NewLine)
        Next

        Dim FILE_NAME As String = "hash.dat"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
            objWriter.Write(sb.ToString())
            objWriter.Close()
        Else
            MsgBox("Error writing combobox data.")
        End If
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

    Private Function GetResponse(location As String, token As String)
        Dim request As WebRequest = WebRequest.Create(location)
        request.Headers.Set("X-Arbux-APIToken", token)
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        response.Close()
        Return responseFromServer
    End Function

End Class
