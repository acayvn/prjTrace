using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
