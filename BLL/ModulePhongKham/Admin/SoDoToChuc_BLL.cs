using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;

namespace BLL.ModulePhongKham.Admin
{
    public class SoDoToChuc_BLL
    {
        public static DataTable GetAllTreeById(int idTree)
        {
            return new DAO.ModulePhongKham.Admin.SoDoToChuc_DAL().GetAllTreeById(idTree);
        }
    }
}
