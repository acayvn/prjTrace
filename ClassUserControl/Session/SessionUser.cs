using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl.Session
{
    public class SessionUser
    {
        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public SessionUser()
        {

        }
        public SessionUser(int id)
        {
            _idUser = id;
        }
        public SessionUser(string userName)
        {
            _UserName = userName;
        }
    }
}
