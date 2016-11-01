using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BLL.ModuleOne.Hotgate
{
    public class DangKyUser_BLL
    {
        public static void DangKyUserHotgate(string userName, string pass, string email)
        {
            new DAO.ModuleOne.Hotgate.DangKyUser_DAO().DangKyUserHotgate(userName, pass, email);
        }
    }
}
