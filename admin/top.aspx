<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="admin_top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body  style="background-image:url(skin/images/frame/topbg.gif);width:100%;padding:0">
    <form id="form1" runat="server">
        <div style="padding:0">
            <p style="display:flex">
            <span style="flex:6;padding:0;margin:0"><asp:Image ID="Image1" runat="server" src="skin/images/frame/logo.gif"/>

            </span><span style="flex:1"><asp:LinkButton ID="btnLoginOut" runat="server" OnClick="btnLoginOut_Click">注销登录</asp:LinkButton></span>
            </p><p></p>
            
        </div>
    </form>
</body>
</html>
