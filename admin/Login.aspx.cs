using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class admin_Login : System.Web.UI.Page
{
    public SDM.BLL.AdminInfo bll = new SDM.BLL.AdminInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtUserName.Focus();
        }
    }



    

    protected void BtnReset_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtPassWord.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
        {
            SDM.DAT.ShowInfo.Alert("请输入账号名称！", this.Page);
            txtUserName.Focus();
            return;
        }
        if (string.IsNullOrEmpty(txtPassWord.Text.Trim()))
        {
            SDM.DAT.ShowInfo.Alert("请输入登录密码！", this.Page);
            txtPassWord.Focus();
            return;
        }
        else
        {
            DataTable dt = bll.GetLogin(txtUserName.Text.Trim(), txtPassWord.Text.Trim()).Tables["ds"];
            if (dt.Rows.Count > 0)
            {
                Session["userid"] = dt.Rows[0][0].ToString();
                Session["username"] = dt.Rows[0][1].ToString();
                Response.Redirect("index.aspx");
            }
            else
            {
                SDM.DAT.ShowInfo.Alert("对不起，登录失败，请核对账号和密码！", this.Page);
                txtUserName.Text = "";
                txtPassWord.Text = "";
            }
        }
    }
}