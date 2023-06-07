using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Model
{
    [Serializable]
    public partial class WorkTuanDui
    {
        public WorkTuanDui() { }
        #region Model
        private int _workid;
        private string _tdmc;
        private int _userid_1;
        private string _userid_1_des;
        private int  _userid_2;
        private string _userid_2_des;
        private int _userid_3;
        private string _userid_3_des;
        private string _workname;
        private string _workcate;
        private string _workdes;
        private string _worktime;
        private string _workurl;
        private string _workpicurl;
        public int WoorkID
        {
            set { _workid = value; }
            get { return _workid; }
        }
        public string Tdmc
        {
            set { _tdmc = value; }
            get { return _tdmc; }
        }
        public int UserID_1
        {
            set { _userid_1 = value; }
            get { return _userid_1; }
        }
        public string UserID_1_des
        {
            set { _userid_1_des = value;}
            get { return _userid_1_des; }
        }
        public int UserID_2
        {
            set { _userid_2 = value; }
            get { return _userid_2; }
        }
        public string UserID_2_des
        {
            set { _userid_2_des = value;}
            get { return _userid_2_des; }
        }
        public int UserID_3
        {
            set { _userid_3 = value; }
            get { return _userid_3; }
        }
        public string UserID_3_des
        {
            set { _userid_3_des = value;}
            get { return _userid_3_des; }
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
