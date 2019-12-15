Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Form1
    Public endpointDict As Dictionary(Of String, String)
    Public metaDict As Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bypass SSL Cert Validation
        ServicePointManager.ServerCertificateValidationCallback =
                    Function(se As Object,
                             cert As System.Security.Cryptography.X509Certificates.X509Certificate,
                             chain As System.Security.Cryptography.X509Certificates.X509Chain,
                             sslerror As System.Net.Security.SslPolicyErrors) True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmbLinks.Items.Clear()
        Try
            Dim request As WebRequest =
            WebRequest.Create(urlTextBox.Text)
            request.Headers.Set("X-Arbux-APIToken", tokenTextBox.Text)
            Dim response As WebResponse = request.GetResponse()
            TextBox2.Text = CType(response, HttpWebResponse).StatusDescription
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim baseList = JsonConvert.DeserializeObject(Of Object)(responseFromServer)
            endpointDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("links").ToString)
            metaDict = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("meta").ToString)
            'RichTextBox1.Text = responseFromServer
            reader.Close()
            response.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Oops!!")
        End Try
        For Each item In endpointDict
            cmbLinks.Items.Add(item.Key.ToString)
        Next
        cmbLinks.Visible = True
        RichTextBox1.Text = "Endpoints loaded!"
        lblApi.Text = metaDict("api")
        lblApiVersion.Text = metaDict("api_version")
        lblSpBuild.Text = metaDict("sp_build_id")
        lblSpVersion.Text = metaDict("sp_version")
        apiInfoGbox.Visible = True
    End Sub

End Class
