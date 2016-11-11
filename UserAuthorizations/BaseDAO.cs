using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserAuthorizations
{
    public class BaseDAO
    {
        public string sConn
        {
            get
            { return System.Configuration.ConfigurationManager.ConnectionStrings["strConnUser"].ToString();
            }
        }
    }
}
