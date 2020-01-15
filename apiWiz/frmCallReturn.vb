Public Class frmCallReturn
    Private callReturn As String

    Public WriteOnly Property SetCallReturn As String
        Set(value As String)
            callReturn = value
        End Set
    End Property
    Private Sub frmCallReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbReturn.Text = callReturn
    End Sub

    Private Sub rtbReturn_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtbReturn.LinkClicked
        Form1.urlTextBox.Text = e.LinkText
        Form1.buttonTry.PerformClick()
    End Sub
End Class