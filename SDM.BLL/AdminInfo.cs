using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SDM.BLL
{
    public partial class AdminInfo
    {
        private readonly SDM.DAT.AdminInfo dal = new SDM.DAT.AdminInfo();
        public AdminInfo() { }
        #region BasicMethod
        public bool Exists(int AdminID)
        {
            return dal.Exists(AdminID);
        }
        public int Add(SDM.Model.AdminInfo Model)
        {
            return dal.Add(Model);
        }
        public bool Update(SDM.Model.AdminInfo Model)
        {
            return dal.Update(Model);
        }
        public bool Delete(int AdminID)
        {
            return dal.Delete(AdminID);
        }
        public SDM.Model.AdminInfo GetModel(int AdminID) 
        {
            return dal.GetModel(AdminID);
        }
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        public DataSet GetList(int Top,string strWhere,string filedOrder) 
        { 
            return dal.GetList(Top,strWhere,filedOrder);
        }
        public DataSet GetAllList()
        {
            return GetList("");
        }
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        #endregion BasicMethod
        #region ExtensionMethod
        public DataSet GetLogin(string strName,string strPass)
        {
            return dal.GetLogin(strName,strPass);
        }

        #endregion ExtensionMethod
    }
}
