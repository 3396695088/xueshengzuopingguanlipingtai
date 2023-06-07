using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SDM.DAT
{

    public abstract class DbHelperSQL
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings
            ["StudentCnnString"].ConnectionString;
        public static object GetSingle(string SQLString)
        {
            //新建数据库连接
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();//打开数据库
                        object obj = cmd.ExecuteScalar();//返回查询对象，返回obj对象或者null
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }

            }
        }
        public static object GetSingle(string SQLString,params SqlParameter[] cmdParms) 
        {
            using(SqlConnection connection= new SqlConnection(connectionString))
            {
                using(SqlCommand cmd=new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj= cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch(System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }
        private static void PrepareCommand(SqlCommand cmd,SqlConnection conn,SqlTransaction trans,string cmdText, SqlParameter[] cmdParms ) 
        { 
            if(conn.State!=ConnectionState.Open)
                conn.Open();
            cmd.Connection=conn;
            cmd.CommandText=cmdText;
            if(trans!=null)
                cmd.Transaction=trans;
                cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach(SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);

                }
            }
        }
        public static bool Exists(string strSql,params SqlParameter[] cmdParms)
        {
            //调用GetSingle()方法，将查询结果作为对象返回
            object obj = GetSingle(strSql,cmdParms);
            int cmdresult;
            if((Object.Equals(obj,null))||(Object.Equals(obj,System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult=int.Parse(obj.ToString());
            }
            if(cmdresult==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection= new SqlConnection(connectionString)) 
            {
                using(SqlCommand cmd=new SqlCommand(SQLString,connection))
                {
                    try
                    {
                        connection.Open();
                        int rows=cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch(System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
        public static int ExecuteSql(string SQLString,params SqlParameter[] cmdParms)
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                using (SqlCommand cmd=new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows=cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch(System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds= new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command= new SqlDataAdapter(SQLString,connection);
                    command.Fill(ds,"ds");//填充数据
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        public static DataSet Query(string SQLString,params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd=new SqlCommand();
                PrepareCommand(cmd,connection,null, SQLString, cmdParms);
                using(SqlDataAdapter da=new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch(System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }
    }
}
