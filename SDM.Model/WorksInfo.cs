using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Model
{
    [Serializable]
    public partial class WorksInfo
    {
        public WorksInfo() { }
        #region Model
        private int _workid;
        private int _userid;
        private string _workname;
        private string _workcate;
        private string _workdes;
        private string _worktime;
        private string _workurl;
        private string _workpicurl;
        public int WorkID
        {
            set { _workid = value; }
            get { return _workid; }
        }
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        public string WorkName
        {
            set { _workname = value; }
            get { return _workname; }
        }
        public string WorkCate
        {
            set { _workcate = value; }
            get { return _workcate; }
        }
        public string WorkDes
        {
            set { _workdes = value; }
            get { return _workdes; }
        }
        public string WorkTime
        {
            set { _worktime = value; }
            get { return _worktime; }
        }
        public string WorkUrl
        {
            set { _workurl = value; }
            get { return _workurl; }
        }
        public string WorkPicurl
        {
            set { _workpicurl = value; }
            get { return _workpicurl; }
        }
        #endregion Model
    }
}
