using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sql : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);
        if (!IsPostBack) { 
        // 根据传入的action 值判断需要进行的操作
            switch (Request.QueryString["action"].ToString().Trim()) {
                case "DelStudent":
                //删除学生账号
                    SDM.BLL.StudentInfo bllStudent = new SDM.BLL.StudentInfo();
                    bllStudent.Delete(id);
                    SDM.DAT.ShowInfo.AlertAndRedirect("删除成功!","StudentInfo.aspx", this.Page);
                    break;
                case "DelAdmin"://删除管理员账号
                        SDM.BLL.AdminInfo bllAdminInfo = new SDM.BLL.AdminInfo();
                        bllAdminInfo.Delete(id);
                        SDM.DAT.ShowInfo.AlertAndRedirect("删除成功!","AdminInfo.aspx?action=add",this.Page);
                        break;
                case "DelWorkPerson"://删除个人作品
                    SDM.BLL.WorksInfo bllWorksInfo = new SDM.BLL.WorksInfo();
                    bllWorksInfo.Delete(id);
                        SDM.DAT.ShowInfo.AlertAndRedirect("删除成功!","WorkPersonList.aspx",

                        this.Page); 
                    break;
                case "DelWorkTuanDui":
                    SDM.BLL.WorkTuanDui bllTuanDui = new SDM.BLL.WorkTuanDui();
                    bllTuanDui.Delete(id);
                    SDM.DAT.ShowInfo.AlertAndRedirect("删除成功!","WorkTuanDuiList.aspx",this.Page);
                    break;
            }
            }
        }
}