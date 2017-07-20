<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddForm.aspx.vb" Inherits="CustomerInfo.AddForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add New Iteam to DB</h1>
            <table style="width:45%" border="1">
                <tr>
                    <td><asp:Label runat="server">Firstname</asp:Label></td>
                    <td><asp:TextBox ID="First" runat="server">Enter Firstname</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Lastname</asp:Label></td>
                    <td><asp:TextBox ID="Last" runat="server">Enter Lastname</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Street Address</asp:Label></td>
                    <td><asp:TextBox ID="Street" runat="server">Enter Street Address</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">City</asp:Label></td>
                    <td><asp:TextBox ID="City" runat="server">Enter City</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Province</asp:Label></td>
                    <td> <asp:TextBox ID="Prov" runat="server">Enter Province</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Country</asp:Label></td>
                    <td><asp:TextBox ID="Country" runat="server">Enter Country</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Postal Code</asp:Label></td>
                    <td><asp:TextBox ID="PC" runat="server">Enter Postal Code</asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="Button" runat="server" Text="Add to DB"/>
        </div>
        <div>
            <a href="TableForm.aspx">Return to Homepage</a>
        </div>
        <div>
            <a href="#">Add Another Row</a>
        </div>
    </form>
</body>
</html>
