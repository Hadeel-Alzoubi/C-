<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="From.aspx.cs" Inherits="NewForm.From" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Choose an option:"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Option 3" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
<%--            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />--%>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go to Page 2" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
