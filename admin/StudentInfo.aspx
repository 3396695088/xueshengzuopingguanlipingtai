<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="admin_StudentInfo" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <span >学生信息管理</span>
                <span style="font-size:15px">——添加学生信息</span>
            </p>
            
            <div>
            学生编号：<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox><br />
            姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            性别：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            学号：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            密码：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="新增学生" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="删除" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="编辑" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="查询" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="查询所有学生" OnClick="Button5_Click" /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        </div>

    </form>
</body>
</html>
