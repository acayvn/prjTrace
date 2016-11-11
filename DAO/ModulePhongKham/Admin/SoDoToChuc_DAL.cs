using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO.ModulePhongKham.Admin
{
    public class SoDoToChuc_DAL:BaseDAO
    {
        public DataTable GetAllTreeById(int idTree)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataset(sConnU(), CommandType.StoredProcedure, "spLayNhanhCayIdTree", new SqlParameter("@IdTree", idTree)).Tables[0];
            return dt;
        }
    }
}
