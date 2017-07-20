Imports MySql.Data.MySqlClient

Public Class AddForm
    Inherits System.Web.UI.Page
    Private Mycon As String = "Server=localhost;User ID=root;Password=ramanmehat;Database=websiteformdemo"
    Private conn As New MySql.Data.MySqlClient.MySqlConnection
    Private cmd As New MySql.Data.MySqlClient.MySqlCommand
    Private txt As String = ""
    'Private database As String = "websiteformdemo.customerinfo"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conn.ConnectionString = Mycon
        conn.Open()
    End Sub

    Private Sub AddToDB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button.Click
        Dim Read As MySqlDataReader

        Try
            Dim Query As String
            Query = "INSERT INTO websiteformdemo.customerinfo(Firstname,Lastname,StreetAddress,City,Province,Country,PostalCode) VALUES('" & First.Text & "','" & Last.Text & "','" & Street.Text & "','" & City.Text & "','" & Prov.Text & "','" & Country.Text & "','" & PC.Text & "')"
            cmd = New MySqlCommand(Query, conn)
            Read = cmd.ExecuteScalar
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Dispose()
    End Sub
End Class