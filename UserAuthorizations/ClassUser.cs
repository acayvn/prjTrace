using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAuthorizations
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
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _FullName;

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private DateTime _YeahOfBirth;

        public DateTime YeahOfBirth
        {
            get { return _YeahOfBirth; }
            set 
            {
                if (value > DateTime.Today)
                    _YeahOfBirth = DateTime.Today;
                else
                    _YeahOfBirth = value;
            }
        }
        //private int _Age;

        public int Age
        {
            get
            {
                if (_YeahOfBirth > DateTime.Today)
                {
                    return 0;
                }
                else
                    return _YeahOfBirth.Year - DateTime.Today.Year;
            }
            
        }
        private bool _Sex;
        /// <summary>
        /// Giới tính: true -> Man; false -> Woman
        /// </summary>
        public bool Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        private bool _Locked;
        /// <summary>
        /// Trạng thái khóa của user
        /// </summary>
        public bool Locked
        {
            get { return _Locked; }
            set { _Locked = value; }
        }
        #endregion
        public ClassUser()
        {

        }
        public ClassUser(int id,string userName, string passWord, string email, string hoten, string sdt, string diachi, DateTime ngaysinh)
        {
            _Id = id;
            _UserName = userName;
            _Password = passWord;
            _Email = email;
            _FullName = hoten;
            _Phone = sdt;
            _Address = diachi;
            _YeahOfBirth = ngaysinh;
        }

    }
}
