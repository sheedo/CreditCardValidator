<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                   <asp:Label ID="lblCardNumber" runat="server" Text="Credit Card# : "></asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:Label ID="lblResult" runat="server" Text="Result : "></asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="txtResult" runat="server" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnProcess" runat="server" Text="Process" Width="217px" OnClick="btnProcessClick"/>
                </td>
            </tr>
        </table>       
    </div>
    </form>
</body>
</html>
