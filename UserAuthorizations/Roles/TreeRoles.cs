using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace UserAuthorizations.Roles
{
    public class TreeRoles:BaseDAO
    {
        public bool IsLoginValid(string userName, int IdTree)
        {
            DataTable dt = SqlHelper.ExecuteDataset(sConn, CommandType.StoredProcedure, "spAuthorityUserOnTree", new SqlParameter("@Activity", "IsValidUserOnTree"), new SqlParameter("@IdTree", IdTree), new SqlParameter("@UserName", userName)).Tables[0];
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["IdAuthority"].ToString() == "0")
                {
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }
         
        
    }
}
