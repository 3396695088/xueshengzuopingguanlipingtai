using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AdminInfo : System.Web.UI.Page
{
    public SDM.BLL.AdminInfo bll=new SDM.BLL.AdminInfo();
    public SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string AdminID = txtUserID.Text.Trim(); // 从数据源获取AdminID的方法，请根据实际情况修改

            // 为btnEdit按钮设置动态链接
            btnEdit.PostBackUrl = string.Format("Admininfo.aspx?id={0}&action=Edit", AdminID);
            string action = Request.QueryString["action"];
            if (action != null)
            {

                switch (Request.QueryString["action"].ToString().Trim())
                {
                    case "Add":
                        btnEdit.Visible = false;
                        btnAdd.Visible = true;
                        break;
                    case "Edit":
                        btnEdit.Visible = true;
                        btnAdd.Visible = false;
                        int id = int.Parse(Request.QueryString["id"]);
                        model = bll.GetModel(id);
                        txtUserName.Text = model.AdminName.ToString();
                        txtPwd.Text = model.AdminPass.ToString();
                        break;
            }
            bind();
            }
            else
            {
                Response.Write("action为空");
            }
        }
    }
    protected void bind()//将管理员信息绑定到Repeater控件上
    {
        Repeater1.DataSource = bll.GetAllList();
        Repeater1.DataBind();
        
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update AdminInfo set AdminPass='" + txtPwd.Text.Trim() + "' where AdminName='" + txtUserName.Text.Trim() + "'";
        try
        {
            con.Open();
            int updatecount = cmd.ExecuteNonQuery();
            if (updatecount >= 1)
                Response.Write("修改密码成功");
            else
                Response.Write("修改密码失败，该用户不存在");
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write("修改失败" + ex.Message);
        }
        finally
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        /*try
        {
            model = CreateModel();
            model.AdminID = int.Parse(Request.QueryString["id"].ToString());
            bll.Update(model);
            SDM.DAT.ShowInfo.Alert("操作成功！", this.Page);
            bind();
        }
        catch (Exception ex)
        {
            Response.Write("程序错误："+ex.Message);
        }*/
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtUserID.Text==""|| txtUserName.Text == "" || txtPwd.Text == "")
        {
            SDM.DAT.ShowInfo.Alert("编号、账号和密码不能为空！",this.Page);
            return;
        }
        else
        {
            bll.Add(CreateModel());
            SDM.DAT.ShowInfo.Alert("操作成功！", this.Page);
            bind();
        }
    }
    protected SDM.Model.AdminInfo CreateModel()
    {
        model.AdminID = int.Parse(txtUserID.Text.Trim());
        model.AdminName = txtUserName.Text.Trim();
        model.AdminPass= txtPwd.Text.Trim();
        
        return model;
    }
}