using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO.Class_User
{
    public class ClassUser_DAO:BaseDAO
    {
        public static DataTable ReadUserById(int idUser)
        {
            return SqlHelper.ExecuteDataset(sConnU(), CommandType.StoredProcedure, "spGetUser", new SqlParameter("@Activity", "GetByID"),
                new SqlParameter("@IdUser", idUser)).Tables[0];
        }
        public static DataTable ReadUserByUserName(string userName)
        {
            return SqlHelper.ExecuteDataset(sConnU(), CommandType.StoredProcedure, "spGetUser", new SqlParameter("@Activity", "GetByUserName"),
                new SqlParameter("@UserName", userName)).Tables[0];
        }
    }
}
