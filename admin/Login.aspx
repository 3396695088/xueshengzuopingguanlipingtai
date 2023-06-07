<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            账号：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            密码：<asp:TextBox ID="txtPassWord" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click"/>
            <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="BtnReset_Click" />
        </div>
    </form>
</body>
</html>
