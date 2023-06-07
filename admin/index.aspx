<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="admin_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="body.css" rel="stylesheet" />
    <title>学生科技作品展示平台</title>
</head>
<frameset rows="60,*"cols="*" frameborder="no" border="0"framespacing="0">
    <frame src="top.aspx"name="topFrame"scrolling="no">
        <frameset cols="180,*"name="btFrame" frameborder="NO" border="0"framespacing="0">
            <frame src="menu.aspx"noresize name="menu"scrolling="yes">
                <frame src="main.aspx"noresize name="main"scrolling="yes">
            </frameset>
        </frameset>
    <noframes>
<bodyclass="noframebody">您的浏览器不支持框架!</body>
    <noframes>
</html>
