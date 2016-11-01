using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class GetChildsById
    {
        public static DataTable GetChildTreeById(int id)
        {
            return DAO.BaseDAO.GetChildTreeById(id);
        }
        public static DataTable GetChildMenuById(int id)
        {
            return DAO.BaseDAO.GetChildMenuById(id);
        }
    }
}
