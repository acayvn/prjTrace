using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BLL.ModuleOne.ChucNang
{
    public class BLL_DangNhap
    {
        public static int CheckLogIn(string userName, string passWord)
        {
            return new DAO.DangNhap.DangNhap_DAO().KiemTraDangNhap(userName, passWord);
            
        }
    }
}
