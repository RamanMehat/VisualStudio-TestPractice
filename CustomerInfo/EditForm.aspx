<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditForm.aspx.vb" Inherits="CustomerInfo.EditForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Edit Iteams in DB</h1>
            <table style="width:45%" border="1">
                <tr>
                    <td><asp:Label runat="server">Firstname</asp:Label></td>
                    <td><asp:TextBox ID="Fst" runat="server">Enter Firstname</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Lastname</asp:Label></td>
                    <td><asp:TextBox ID="Lst" runat="server">Enter Lastname</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Street Address</asp:Label></td>
                    <td><asp:TextBox ID="Add" runat="server">Enter Street Address</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">City</asp:Label></td>
                    <td><asp:TextBox ID="Town" runat="server">Enter City</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Province</asp:Label></td>
                    <td> <asp:TextBox ID="Pro" runat="server">Enter Province</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Country</asp:Label></td>
                    <td><asp:TextBox ID="Ctry" runat="server">Enter Country</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Postal Code</asp:Label></td>
                    <td><asp:TextBox ID="Post" runat="server">Enter Postal Code</asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="Button99" runat="server" Text="Save"/>
        </div>
        <div>
            <a href="TableForm.aspx">Return to Homepage</a>
        </div>
    </form>
</body>
</html>
