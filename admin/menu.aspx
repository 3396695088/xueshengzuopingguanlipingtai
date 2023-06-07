<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="admin_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="skin/css/menu.css" rel="stylesheet"/>
        <link href="skin/css/base.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="99%" height="100%" border="0" cellsapacing="0" cellpadding="0">
                <tr>
                    <td style="padding-left:3px;padding-top:8px" valign="top">
                        <dl class="bitem">
                            <dt onclick='showHide("items1_1")'><b>系统参数</b></dt>
                            <dd style='display:block' class='sitem' id='items1_1' >
                                <ul class="sitemu">
                                    <li>
                                        <div class="items">
                                            <div class="fllct">
                                                <a href='admininfo.aspx?action=Add' target='main'>系统账号管理</a>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </dd>

                        </dl>
                        <dl class="bitem">
                            <dt onclick='showHide("items4_1")'><b>学生信息管理</b></dt>
                            <dd style='display:block'class='sitem'id='items4_1'>
                                <ul class='sitemu'>
                                    <li><a href='StudentInfo.aspx' target='main'>学生列表</a> </li>
                                    <li>
                                        <a href='StudentInfoAdd.aspx?action=Add'target='main'>添加学生信息</a>
                                    </li>
                                </ul>
                            </dd>
                        </dl>
                        <dl class="bitem">
                            <dt onclick='showHide("items4_8")'><b>个人作品管理</b></dt>
                            <dd style='display:block'class='sitem'id='items4_8'>
                                <ul class='sitemu'>
                                    <li><a href='WorkPersonList.aspx' target='main'>作品列表</a> </li>
                                    
                                </ul>
                            </dd>
                        </dl>
                        <dl class="bitem">
                            <dt onclick='showHide("items4_6")'><b>团队作品管理</b></dt>
                            <dd style='display:block'class='sitem'id='items4_6'>
                                <ul class='sitemu'>
                                    <li><a href='WorkTuanDuiList.aspx' target='main'>作品列表</a> </li>
                                    
                                </ul>
                            </dd>
                        </dl>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
