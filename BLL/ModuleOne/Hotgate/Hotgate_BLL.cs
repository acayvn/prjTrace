using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL.ModuleOne.Hotgate
{
    public class Hotgate_BLL
    {
        public static DataTable LoadModules()
        {
            return new DAO.ModuleOne.Hotgate_DAO().LoadModules();
        }
    }
}
