Imports MySql.Data.MySqlClient

Public Class Table
    Inherits System.Web.UI.Page

    Private Mycon As String = "Server=localhost;User ID=root;Password=ramanmehat;Database=websiteformdemo"
    Private conn As New MySql.Data.MySqlClient.MySqlConnection
    Private cmd As New MySql.Data.MySqlClient.MySqlCommand
    Private txt As String = ""
    Private database As String = "websiteformdemo.customerinfo"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conn.ConnectionString = Mycon
        conn.Open()
        txt = "Select * from " & database
        cmd = New MySqlCommand(txt, conn)
        MySqlData(cmd.ExecuteReader)
        conn.Close()
    End Sub

    Protected Sub MySqlData(data As MySqlDataReader)
        cmd = New MySqlCommand("Select * From websiteformdemo.customerinfo", conn)
        Dim SB As New StringBuilder
        Dim LC As LiteralControl
        SB.Append("<Table style='width:100%' border='1'>")
        SB.Append("<tr>")
        SB.Append("<th>UserID</th><th>Firstname</th><th>Lastname</th><th>Street Address</th><th>City</th><th>Province</th><th>Country</th><th>Postal Code</th><th>Edit</th>")
        SB.Append("<tr>")

        If data.HasRows Then
            Do While data.Read
                For i As Integer = 0 To (data.FieldCount - 1)
                    SB.Append("<td>" & data(i) & "</td>")
                Next
                SB.Append("<td><a href='EditForm.aspx'>Edit</td>")
                SB.Append("</tr>")

            Loop
            LC = New LiteralControl(SB.ToString())
            Table.Controls.Add(LC)
            Return
        End If
        MsgBox("Something Went Wrong")
    End Sub

    Private Sub UpdateDB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn.Open()
        Dim Read As MySqlDataReader

        Try
            Dim Query As String
            Query = "UPDATE websiteformdemo.customerinfo SET " & Header.Text & " = '" & NewData.Text & "' WHERE UserID = '" & EditID.Text & "'"
            cmd = New MySqlCommand(Query, conn)
            Read = cmd.ExecuteScalar
            MsgBox("Edited")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Dispose()
        conn.Close()
    End Sub

    Private Sub DeleteFromoDB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Open()
        Dim Read As MySqlDataReader

        Try
            Dim Query As String
            Query = "DELETE FROM websiteformdemo.customerinfo WHERE UserID = '" & Delete.Text & "'"
            cmd = New MySqlCommand(Query, conn)
            Read = cmd.ExecuteScalar
            MsgBox("Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Dispose()
        conn.Close()
    End Sub
End Class