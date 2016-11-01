using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClassUserControl;

namespace BLL.Class_User
{
    public class ClassUser_BLL
    {
        public static DataTable GetUserById(int id)
        {
            return DAO.Class_User.ClassUser_DAO.ReadUserById(id);
        }
        public static DataTable GetUserByUserName(string userName)
        {
            return DAO.Class_User.ClassUser_DAO.ReadUserByUserName(userName);
        }
    }
}
