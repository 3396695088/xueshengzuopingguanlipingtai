using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PagedList;
using PagedList.Mvc;

public partial class admin_StudentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into StudentInfo(UserId,UserName,UserSex,UserNumber,UserPass) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "')";

        try
        {
            con.Open();
            Response.Write("连接成功");
            cmd.ExecuteNonQuery();
            Response.Write("添加用户成功");
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write("连接失败" + ex.Message);
        }
        finally
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "delete from StudentInfo where UserId='" + TextBox1.Text.Trim() + "';";
        try
        {
            con.Open();
            Response.Write("连接成功");
            cmd.ExecuteNonQuery();

            Response.Write("删除用户成功");

            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write("删除失败" + ex.Message);
        }
        finally
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update StudentInfo set UserPass='" + TextBox5.Text.Trim() + "' where UserId='" + TextBox1.Text.Trim() + "'";
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
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //连接模式查询指定数据
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from StudentInfo where UserId='" + TextBox1.Text.Trim() + "';";
        SqlDataReader sdr = null;
        try
        {
            con.Open();
            sdr = cmd.ExecuteReader();
            /*GridView1.DataSource = sdr;
            GridView1.DataBind();*/
            if (sdr.Read())
            {
                TextBox2.Text = sdr.GetValue(1).ToString();
                TextBox3.Text = sdr.GetValue(2).ToString();
                TextBox4.Text = sdr.GetValue(3).ToString();
                TextBox5.Text = sdr.GetValue(4).ToString();
            }
            else
            {
                Response.Write("指定记录不存在");
            }
        }
        catch (Exception ex)
        {
            Response.Write("查询失败，原因为：" + ex.Message);
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["StudentCnnString"].ConnectionString;
        SqlConnection con = new SqlConnection(cnnStr);
        SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo", con);
        DataTable dt = new DataTable();
        try
        {
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("断开模式查询失败" + ex.Message);
        }
    }
    /*public SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();
    public SDM.Model.StudentsInfo model = new SDM.Model.StudentsInfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        *//*if (!IsPostBack)
        {
            
            LoadData();
        }*//*
    }*/




    /*protected void gdvWishList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex != -1)
        {
            int id = e.Row.RowIndex + 1;
            e.Row.Cells[1].Text = id.ToString();
        }
    }
    public void LoadData()
    {
        gdvWishList.DataSource = bll.GetlistByPage("1=1","UserID DESC", (AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1))+1, AspNetPager1.PageSize * AspNetPager1.CurrentPageIndex);

        gdvWishList.DataKeyNames = new string[] { "UserID" };
        gdvWishList.DataBind();
        AspNetPager1.RecordCount = bll.GetRecordCount("1=1");
    }
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = AspNetPager1.CurrentPageIndex; // 更新当前页码
        LoadData(); // 重新加载数据
    }*/



}