using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ClassUserControl;
using BLL;

namespace WebForm
{
    public class ClassUser:ClassUserBase
    {
       
        public override void ReadInfoUserByID(int idUser)
        {
            DataTable dt = BLL.Class_User.ClassUser_BLL.GetUserById(idUser);
            if (dt.Rows.Count>0)
            {
                _IdUser = idUser;
                _UserName = dt.Rows[0]["UserName"].ToString();
                _Phone = dt.Rows[0]["Phone"].ToString();
                _FullName = dt.Rows[0]["FullName"].ToString();
                _Email = dt.Rows[0]["Email"].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0]["BrithOfYeah"].ToString()))
                {
                    _BrithOfYeah = Convert.ToDateTime(dt.Rows[0]["BrithOfYeah"].ToString());
                }                
                _Address = dt.Rows[0]["Address"].ToString();                
            }
            
            
            
        }
        public override void ReadInfoUserByUserName(string userName)
        {
            DataTable dt = BLL.Class_User.ClassUser_BLL.GetUserByUserName(userName);
            if (dt.Rows.Count > 0)
            {
                _IdUser = Convert.ToInt32( dt.Rows[0]["IdUser"].ToString() );
                _UserName = dt.Rows[0]["UserName"].ToString();
                _Phone = dt.Rows[0]["Phone"].ToString();
                _FullName = dt.Rows[0]["FullName"].ToString();
                _Email = dt.Rows[0]["Email"].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0]["BrithOfYeah"].ToString()))
                {
                    _BrithOfYeah = Convert.ToDateTime(dt.Rows[0]["BrithOfYeah"].ToString());
                }
                _Address = dt.Rows[0]["Address"].ToString();
            }
        }

        private int _IdUser;
        public override int IdUser
        {
            get
            {
                return _IdUser;
            }
            set
            {
                _IdUser = value;
            }
        }
        private string _UserName;
        public override string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        private string _Email;
        public override string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        private string _Address;
        public  string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        private string _FullName;
        public  string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }
        private string _Phone;
        public  string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        private DateTime _BrithOfYeah;
        public  DateTime BrithOfYeah
        {
            get
            {
                return _BrithOfYeah;
            }
            set
            {
                if (value > DateTime.Today)
                    _BrithOfYeah = DateTime.Today;
                else
                    _BrithOfYeah = value;
            }
        }
        private int _Tuoi;

        public int Tuoi
        {
            get { return _Tuoi; }
            private set { _Tuoi = DateTime.Today.Year - _BrithOfYeah.Year; }
        }
    }
}