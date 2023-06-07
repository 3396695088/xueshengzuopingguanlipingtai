using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Model
{
    [Serializable]
    public partial class AdminInfo
    {
        public AdminInfo() { }
        #region Model
        private int _adminid;
        private string _adminname;
        private string _adminpass;
        public int AdminID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        public string AdminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        public string AdminPass
        {
            set { _adminpass = value; }
            get { return _adminpass; }
        }
        #endregion Model




    }
}
