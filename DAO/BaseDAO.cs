using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class BaseDAO
    {
        public static string strConn() 
        {
            return @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=HHNI;Integrated Security=True";
        }
        public static string sConnPK()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["strConnPK"].ToString();
        }
        public static string sConnU()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["strConnUser"].ToString();
        }
        /// <summary>
        /// Trả về table chứa các childTree của id Tree
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetChildTreeById(int id)
        {
            return SqlHelper.ExecuteDataset(sConnU(), CommandType.StoredProcedure, "spLayNhanhCayIdTree", new SqlParameter("@IdTree", id)).Tables[0];
        }

        /// <summary>
        /// Trả về table chứa các childMenu của id Menu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetChildMenuById(int id)
        {
            return SqlHelper.ExecuteDataset(sConnU(), CommandType.StoredProcedure, "spLayNhanhCayIdMenu", new SqlParameter("@IdMenu", id)).Tables[0];
        }
    }
}
