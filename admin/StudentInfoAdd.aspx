<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfoAdd.aspx.cs" Inherits="admin_StudentInfoAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .leibie{
            font-size:15px;
            align-content:center;
            flex:1;
            align-items:center;

        }
        .caozuo{
            flex:2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="padding:2px;border:1px solid black">
                <p>
                    <span>添加学生信息-</span>
                    <span style="font-size:10px">学生信息管理</span>
                </p>
            </div>
            <div style="border:1px solid red">
                <p>学生信息编辑</p>
                <p style="display:flex">
                    <span class="leibie">学生姓名</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">性别</span>
                    <span class="caozuo">
                        <asp:DropDownList ID="DDLSex" runat="server">
                            <asp:ListItem Selected="True">男</asp:ListItem>
                            <asp:ListItem>女</asp:ListItem>
                        </asp:DropDownList></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">学号</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserNumber" runat="server"></asp:TextBox>
                        <asp:Button ID="btnCheck" runat="server" Text="检查是否重复" />
                    </span>
                </p>
                <p style="display:flex">
                    <span class="leibie">登录密码</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserPass" Text="123456" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">所属学院（系别）</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserXy" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">所学专业</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserZy" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">所属班级</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserBj" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie">当前系统时间：</span>
                    <span class="caozuo">
                        <asp:TextBox ID="txtUserAddTime" runat="server"></asp:TextBox></span>
                </p>
                <p style="display:flex">
                    <span class="leibie"></span>
                    <span class="caozuo">
                        <asp:Button ID="btnOk" runat="server" Text="添加" style="margin-right:30px"/>
                        <asp:Button ID="btnEdit" runat="server" Text="修改" />
                    </span>
                </p>
            </div>
            <div>
                <p>说明：为了系统便于统一管理，请按照学校相关规定，对学院名称、专业名称、班级名称统一编排</p>
                <p style="font-size:10px">系统默认学生登录密码：123456。学生登录系统后，请自行修改默认登录密码！</p>
            </div>
        </div>
    </form>
</body>
</html>
