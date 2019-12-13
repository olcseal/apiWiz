Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bypass SSL Cert Validation
        ServicePointManager.ServerCertificateValidationCallback =
                    Function(se As Object,
                             cert As System.Security.Cryptography.X509Certificates.X509Certificate,
                             chain As System.Security.Cryptography.X509Certificates.X509Chain,
                             sslerror As System.Net.Security.SslPolicyErrors) True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Dim endpointDict As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("links").ToString)
            Dim metaDict As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(baseList("meta").ToString)
            'Dim baseList As spEndpointList = JsonConvert.DeserializeObject(Of spEndpointList)(responseFromServer)
            RichTextBox1.Text = responseFromServer
            lblApi.Text = metaDict("api")
            lblApiVersion.Text = metaDict("api_version")
            lblSpBuild.Text = metaDict("sp_build_id")
            lblSpVersion.Text = metaDict("sp_version")
            apiInfoGbox.Visible = True
            reader.Close()
            response.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Oops!!")
        End Try

    End Sub

End Class
