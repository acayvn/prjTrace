using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl
{
    public class ClassUser
    {
        #region propeties
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _PassWord;

        public string PassWord
        {
            //get { return _PassWord; }
            set { _PassWord = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _QueQuan;

        public string QueQuan
        {
            get { return _QueQuan; }
            set { _QueQuan = value; }
        }
        private DateTime _NamSinh;

        public DateTime NamSinh
        {
            get { return _NamSinh; }
            set 
            {
                if (value > DateTime.Today)
                    _NamSinh = DateTime.Today;
                else _NamSinh = value;
            }
        }
        private int _Tuoi;

        public int Tuoi
        {
            get { return _Tuoi; }
            private set 
            {
                if (_NamSinh > DateTime.Today)
                    _Tuoi = 0;
                else
                    _Tuoi = value;
            }
        }
        #endregion
        public ClassUser(string userName, string HoTen, string SDT, string DiaChi, string Que, string Email, DateTime NamSinh)
        {
            _HoTen = HoTen;
            _SDT = SDT;
            _DiaChi = DiaChi;
            _Email = Email;
            _QueQuan = Que;
            _NamSinh = NamSinh;
        }
        public ClassUser()
        {

        }
        public ClassUser(string userName)
        {
            _UserName = userName;
            
        }
    }
}
