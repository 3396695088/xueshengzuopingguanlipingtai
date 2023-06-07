using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_sqlDel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string t = Request.QueryString["id"];
        bool i = int.TryParse(t, out int id);
        if(!IsPostBack)
        {
            string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
            SqlConnection con = new SqlConnection(cnnStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            switch (Request.QueryString["action"].ToString().Trim())
            {
                
                case "DelWorkPerson":
                    cmd.CommandText = "delete from WorksInfo where WorkID='" +id + "'";
                    try
                    {
                        con.Open();
                        int deletecount = cmd.ExecuteNonQuery();
                        if (deletecount >= 1)
                        {
                            Response.Write("删除作品成功");
                            Response.Redirect("WorkPersonList.aspx");
                        }
                        else
                        {
                            Response.Write("删除用户失败，该用户不存在");
                            Response.Redirect("WorkPersonList.aspx");
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    break;
                case"DelAdmin":
                    SDM.BLL.AdminInfo bllAdminInfo=new SDM.BLL.AdminInfo();
                    bllAdminInfo.Delete(id);
                    SDM.DAT.ShowInfo.AlertAndRedirect("删除成功！", "AdminInfo.aspx?action=add", this.Page);
                    break;
                case "DelStudent":
                    
                    cmd.CommandText = "delete from AdminInfo where AdminID='" + id + "'";
                    try
                    {
                        con.Open();
                        int deletecount = cmd.ExecuteNonQuery();
                        if (deletecount >= 1)
                        {
                            Response.Write("删除作品成功");
                            Response.Redirect("AdminInfo.aspx");
                        }
                        else
                        {
                            Response.Write("删除用户失败，该用户不存在");
                            Response.Redirect("AdminInfo.aspx");
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    break;
            }
                    
        }
    }
}