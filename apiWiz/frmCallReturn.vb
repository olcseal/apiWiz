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
End Class