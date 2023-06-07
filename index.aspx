<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生科技作品展示平台</title>
</head>
<body style="background-color:#CEEDCC;font-size:12px;">
    <form id="form1" runat="server">
        <div align="center">
            <img src="images/tp.gif" border="0" usemap="#Map"/>
            <map name="Map" id="Map">
                <area shape="rect" coords="448,186,633,244" href="admin/login.aspx" alt="管理员登录" />
                <area shape="rect" coords="450,248,631,297" href="stu/login.aspx" alt="学生登录" />
            </map>
        </div>
    </form>
</body>
</html>
