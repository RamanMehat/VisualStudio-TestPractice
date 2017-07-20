Imports MySql.Data.MySqlClient

Public Class EditForm
    Inherits System.Web.UI.Page

    Private Mycon As String = "Server=localhost;User ID=root;Password=ramanmehat;Database=websiteformdemo"
    Private conn As New MySql.Data.MySqlClient.MySqlConnection
    Private cmd As New MySql.Data.MySqlClient.MySqlCommand
    Private txt As String = ""
    Private database As String = "websiteformdemo.customerinfo"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conn.ConnectionString = Mycon
        conn.Open()
    End Sub

    Private Sub EditDB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button99.Click
        Dim Read As MySqlDataReader

        Try
            Dim Query As String
            Query = "UPDATE database(Firstname,Lastname,StreetAddress,City,Province,Country,PostalCode) VALUES('" & Fst.Text & "','" & Lst.Text & "','" & Add.Text & "','" & Town.Text & "','" & Pro.Text & "','" & Ctry.Text & "','" & Post.Text & "')"
            cmd = New MySqlCommand(Query, conn)
            Read = cmd.ExecuteScalar
            MsgBox("Edited")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Dispose()
    End Sub

End Class