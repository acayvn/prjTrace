using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAuthorizations
{
    class BaseDAO
    {
        public static string strConn()
        {
            return @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=DB_User;Integrated Security=True";
        }
    }
}
