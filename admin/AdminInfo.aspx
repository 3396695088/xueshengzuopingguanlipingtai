<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminInfo.aspx.cs" Inherits="admin_AdminInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>账号管理页面</title>
    <style>
    .item-container {
        display: flex;
        flex-direction: row;
        align-items: center;
    }

    .item-container td{
        display: inline-block; /* 横向排列 */
        vertical-align: middle;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            管理员账号编辑-添加管理员账号<br/>
            输入用户编号：<asp:TextBox ID="txtUserID" runat="server" AutoPostBack="True"></asp:TextBox><br />
            输入账号名称：<asp:TextBox ID="txtUserName" runat="server" AutoPostBack="True"></asp:TextBox><br />
            账号登录密码：<asp:TextBox ID="txtPwd" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:Button ID="btnEdit" runat="server" Text="修改"  OnClick="btnEdit_Click" />
            

            <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" /><br />
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
                        <tr>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">序号</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">管理员编号</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">账号名称</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">登录密码</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">修改</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">删除</div> </td>
                        </tr>
                    
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Container.ItemIndex +1%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("AdminID")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("AdminName")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("AdminPass")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><a href='
                            Admininfo.aspx?id=<%#Eval("AdminID")%>&action=Edit'class="blue">
                            <img alt="Edit" src="../images/edit.gif" border="0px"/></a></div></td>
                                                                  
                        <td bgcolor="#FFFFFF"><div align="center"><a href=
                            'sqlDel.aspx?id=<%#Eval("AdminID")%>&action=DelAdmin'>
                            <img alt="Delete" src="../images/delete.gif" border="0px" /></a></div></td>
                                                                  
                    </tr>

                </ItemTemplate>
                <FooterTemplate></table></FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
