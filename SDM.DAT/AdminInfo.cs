using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;

namespace SDM.DAT
{
    public partial class AdminInfo
    {
        public AdminInfo()
        { }
        #region BasicMethod
        public bool Exists(int AdminID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AdminInfo");
            strSql.Append(" where AdminID=@AdminID");
            SqlParameter[] parameters = { new SqlParameter("@AdminID", SqlDbType.Int, 4) };
            parameters[0].Value = AdminID;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public int Add(SDM.Model.AdminInfo model)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into AdminInfo(");
            strSql.Append("AdminName,AdminPass,AdminID)");
            strSql.Append(" values(");
            strSql.Append("@AdminName,@AdminPass,@AdminID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters =
            {
                new SqlParameter("@AdminName",SqlDbType.VarChar,50),
                new SqlParameter("@AdminPass",SqlDbType.VarChar,50),
                new SqlParameter("@AdminID", SqlDbType.Int, 4)
            };
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.AdminPass;
            parameters[2].Value = model.AdminID;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
                return Convert.ToInt32(obj);
        }
        public bool Update(SDM.Model.AdminInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AdminInfo set ");
            strSql.Append("AdminName=@AdminName,");
            strSql.Append("AdminPass=@AdminPass");
            strSql.Append(" where AdminID=@AdminID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@AdminName",SqlDbType.VarChar,50),
                new SqlParameter("@AdminPass", SqlDbType.VarChar, 50),
                new SqlParameter("@AdminID", SqlDbType.Int, 4)
            };
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.AdminPass;
            parameters[2].Value = model.AdminID;
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int AdminID)
        {
            StringBuilder strSql= new StringBuilder();
            strSql.Append("delete from AdminInfo");
            strSql.Append(" where AdminID=@AdminID");
            SqlParameter[] parameters = { new SqlParameter("@AdminID", SqlDbType.Int, 4) };
            parameters[0].Value = AdminID;
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteList(string AdminIDlist)
        {
            StringBuilder strSql= new StringBuilder();
            strSql.Append("delete from AdminInfo");
            strSql.Append(" where AdminID in (" + AdminIDlist + ")");
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
            if(rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public SDM.Model.AdminInfo GetModel(int AdminID)
        {
            //新建一个可变序列对象
            StringBuilder strSql = new StringBuilder();
            //调用strSal对象的Append0方法，逐步加入SOL语句
            strSql.Append("select top 1 AdminID,AdminName,AdminPass from AdminInfo");
            strSql.Append(" where AdminID=@AdminID");// 将传入参数转化成SOL语句中的参数形式，并存储到数组parameters中
            SqlParameter[] parameters = { new SqlParameter("@AdminID", SqlDbType.Int,4) };
            parameters[0].Value = AdminID;
            //新建一个管理员对象，用于存放结果并返回
            SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();//调用DbHelperSQL类中的Query0方法，得到结果集ds
            DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            if (ds.Tables[0].Rows.Count > 0)//如果ds不为空，则返回ds中第一行第一列的数据
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }                                       
        }*/
        public SDM.Model.AdminInfo GetModel(int AdminID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 AdminID,AdminName,AdminPass from AdminInfo");
            strSql.Append(" where AdminID=@AdminID");
            SqlParameter[] parameters = { new SqlParameter("@AdminID", SqlDbType.Int, 4) };
            parameters[0].Value = AdminID;

            SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public SDM.Model.AdminInfo DataRowToModel(DataRow row)
        {
            //新建管理员对象实体
            SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
            if (row != null) {

                if (row["AdminID"] != null && row["AdminID"].ToString() != "") {

                    //对管理员对象实体进行赋值
                    model.AdminID = int.Parse(row["AdminID"].ToString());
                }
                if (row["AdminName"] != null) { 
                    model.AdminName = row["AdminName"].ToString();
                }
                if (row["AdminPass"] != null) {
                    model.AdminPass = row["AdminPass"].ToString();
                }
            }
            return model;//返回管理员对象
        }
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("select AdminID,AdminName,AdminPass ");
            strSql.Append(" FROM AdminInfo");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            //调用DbHelperSQL类中的Query0方法，返回结果集
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            //调用strSql对象的Append0方法，逐步加入SQL语句
            strSql.Append("select ");
            if (Top > 0) {
                strSql.Append("top" + Top.ToString());
            }
            strSql.Append("AdminID,AdminName,AdminPass");
            strSql.Append(" FROM AdminInfo "); 
            if (strWhere.Trim()!= "")
            {
                strSql.Append("where " + strWhere);
            }
                
            strSql.Append(" order by " + filedOrder);//调用DbHelperSQL类中的Query0方法，返回结果集
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql=new StringBuilder();
            //调用strSql对象的Append0方法，逐步加入SQL语句
            strSql.Append("select count(1) FROM AdminInfo");
            if (strWhere.Trim() != "") {
                strSql.Append(" where" + strWhere);
            }
            //调用DbHelperSOL类中的GetSingle0)方法，object 对象的形式返回结果
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null) {
                return 0;//如果obj对象为null，则返回0，说明没有符合条件的记录
            }
            else
            {
                //如果obj对象不为null，则将obi转化为int型数据，并返回
                return Convert.ToInt32(obj);
            }

        }
        public DataSet GetLogin(string strName,string strPass)
        {
            StringBuilder strsql = new StringBuilder();
            //调用strSql对象的Append0方法，逐步加入SQL语句
            strsql.Append("select * from AdminInfo");
            strsql.Append(" where ");
            strsql.Append("AdminName=@strname and AdminPass=@strpass");
            //将传入参数转化成SQL语句中的参数形式，并存储到数组parameters中
            SqlParameter[] parameter = {new SqlParameter ("@strname",strName ),
                new SqlParameter("@strpass", strPass)
            };
            return DbHelperSQL.Query(strsql.ToString(), parameter);
        }
        #endregion BasicMethod
        #region ExtensionMethod

        #endregion ExtensionMethod
    }
}
