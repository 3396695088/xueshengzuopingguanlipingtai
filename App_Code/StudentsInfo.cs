using SDM.DAT;
using System.Data;
using System.Text;

namespace SDM.Model
{
    public class StudentsInfo
    {
        public DataSet GetlistByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM (");
            strSql.Append("SELECT ROW_NUMBER() OVER(");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.AdminID desc");
            }
            strSql.Append(")AS Row,T.* from AdminInfo T");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append("WHERE " + strWhere);
            }
            strSql.Append(") TT");
            strSql.AppendFormat(" WHERE TT.Row between{0} and{1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}