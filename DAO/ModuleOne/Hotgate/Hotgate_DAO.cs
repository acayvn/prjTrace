using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO.ModuleOne
{
    public class Hotgate_DAO : BaseDAO
    {
        public DataTable LoadModules()
        {
            return SqlHelper.ExecuteDataset(sConnPK(), CommandType.StoredProcedure, "spHotgate", new SqlParameter("@Activity", "GetAllMoDules")).Tables[0];
        }
        public DataTable LoadMenus()
        {
            return SqlHelper.ExecuteDataset(sConnPK(), CommandType.StoredProcedure, "spHotgate", new SqlParameter("@Activity", "GetAllMoDules")).Tables[0];
        }
    }
}
