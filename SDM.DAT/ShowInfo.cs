using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.UI;

namespace SDM.DAT
{
    public class ShowInfo
    {
        public ShowInfo() { }
        public static void Alert(string message,Page page)
        {
            string js = @"<Script language='JavaScript'>alert('" + message + "');</Script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "alert"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", js);
            }
        }

        public static void AlertAndRedirect(string message, string url, Page page)
        {
            // 生成客户端脚本
            string script = $"<script>alert('{message}');window.location.href='{url}';</script>";

            // 注册脚本到页面
            if (page != null && !page.ClientScript.IsStartupScriptRegistered("alertRedirectScript"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alertRedirectScript", script);
            }
        }

    }
}
