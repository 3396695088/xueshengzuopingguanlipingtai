using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Model
{
    [Serializable]
    public partial class StudentInfo
    {
        public StudentInfo() { }
        #region Model
        private int _userid;
        private string _username;
        private string _usersex;
        private string _usernumber;
        private string _userpass;
        private string _userxy;
        private string _userzy;
        private string _userbj;
        private string _useraddtime;
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        public string UserSex
        {
            set { _usersex = value; }
            get { return _usersex; }
        }
        public string UserNumber
        {
            set { _usernumber = value; }
            get { return _usernumber; }
        }
        public string UserPass
        {
            set { _userpass = value; }
            get { return _userpass; }
        }
        public string UserXy
        {
            set { _userxy = value; }
            get { return _userxy; }
        }
        public string UserZy
        {
            set { _userzy = value; }
            get { return _userzy; }
        }
        public string UserBj
        {
            set { _userbj = value; }
            get { return _userbj; }
        }
        public string UserAddtime
        {
            set { _useraddtime = value; }
            get { return _useraddtime; }
        }
        #endregion Model


    }
}
