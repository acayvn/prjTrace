using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl
{
    public abstract class ClassUserBase
    {
         
        public abstract int IdUser { set; get; }
        public abstract string UserName { set; get; }
        public abstract string Email { set; get; }
        public abstract void ReadInfoUserByID(int idUser);
        public abstract void ReadInfoUserByUserName(string userName);
        //public abstract string Address { set; get; }
        //public abstract string FullName { set; get; }
        //public abstract string Phone { set; get; }
        //public abstract DateTime BrithOfYeah { set; get; }
        public ClassUserBase()
        {

        }
    }
}
