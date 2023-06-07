<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorkPersonList.aspx.cs" Inherits="admin_WorkPersonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>个人作品管理</p>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
                        <tr>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">序号</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">作品名称</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">作品分类</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">上传时间</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">视频播放源</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">上传人</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">修改</div> </td>
                            <td bgcolor="#EEEED1"><div align="center" class="STYLE6">删除</div> </td>
                        </tr>
                    
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Container.ItemIndex +1%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkName")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkCate")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkTime")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkUrl")%></div></td>
                        <td bgcolor="#FFFFFF"><div align="center"><%#Eval("UserID")%></div></td>
                        
                        <td bgcolor="#FFFFFF"><div align="center"><a href='
                            WorkPersonList.aspx?id=<%#Eval("WorkID")%>&action=Edit'class="blue">
                            <img alt="Edit" src="../images/edit.gif" border="0px"/></a></div></td>
                                                                  
                        <td bgcolor="#FFFFFF"><div align="center"><a href=
                            'sqlDel.aspx?id=<%#Eval("WorkID")%>&action=DelWorkPerson'>
                            <img alt="Delete" src="../images/delete.gif" border="0px" /></a></div></td>
                                                                  
                    </tr>

                </ItemTemplate>
                <FooterTemplate></table></FooterTemplate>
            </asp:Repeater>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:StudentCnnString %>" SelectCommand="SELECT [WorkID], [UserID], [WorkName], [WorkCate], [WorkTime], [WorkUrl] FROM [WorksInfo]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
