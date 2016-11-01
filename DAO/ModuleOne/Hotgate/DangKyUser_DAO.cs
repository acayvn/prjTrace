using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO.ModuleOne.Hotgate
{
    public class DangKyUser_DAO:BaseDAO
    {
        public void DangKyUserHotgate(string userName, string password, string email)
        {
            SqlHelper.ExecuteNonQuery(sConnU(), CommandType.StoredProcedure, "spUser",
                new SqlParameter("@Activity", "InsertUser"),
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password),
                new SqlParameter("@Email", email));
        }
    }
}
