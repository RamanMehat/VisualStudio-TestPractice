<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TableForm.aspx.vb" Inherits="CustomerInfo.Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Homepage</h1>
            <asp:PlaceHolder ID="table" runat="server"></asp:PlaceHolder>
        </div> 
        <div>
            <table>
                <tr>
                    <td><a href="AddForm.aspx">Add Row</a></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Delete Row</asp:Label></td>
                    <td><asp:TextBox ID="Delete" runat="server">Enter UserID</asp:TextBox></td>
                    <td><asp:Button ID="Button2" runat="server" Text="Delete Row"/></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Edit Row</asp:Label></td>
                    <td><asp:TextBox ID="EditID" runat="server">Enter UserID</asp:TextBox></td>
                    <td><asp:TextBox ID="Header" runat="server">Enter Edit Field</asp:TextBox></td>
                    <td><asp:TextBox ID="NewData" runat="server">Enter New Data</asp:TextBox></td>
                    <td><asp:Button ID="Button3" runat="server" Text="Edit Row"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>