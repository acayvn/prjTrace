using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace UserAuthorizations
{
    public class ClassToken : BaseDAO
    {

        #region properties

        private int _IdToken;
        private string _NameToken;
        private string _NameTree;
        private string _UserName;
        private int _IdUser;
        private int _IdTree;

        

        

        public string NameTree
        {
            get
            {
                return _NameTree;
            }

            set
            {
                _NameTree = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

        public int IdUser
        {
            get
            {
                return _IdUser;
            }

            set
            {
                _IdUser = value;
            }
        }

        public int IdTree
        {
            get
            {
                return _IdTree;
            }

            set
            {
                _IdTree = value;
            }
        }
        #endregion

        public DataTable GetAppsByLoginID()
        {
            return SqlHelper.ExecuteDataset(sConn, CommandType.StoredProcedure, "spGetAppsHotgate").Tables[0];
        }

        private string ValueThisModule
        {
            get
            {
                return new CXMLConfig("config.xml").XmlReadValue("AppRoot", "value");
            }
        }

        public ClassToken()
        {

        }

        public string CreateLoginToken(int idTree, string userName)
        {
            string token;
            token = GenerateToken();
            SqlHelper.ExecuteNonQuery(sConn, CommandType.StoredProcedure, "spTokens",
                new SqlParameter("@Activity", "CreateLoginToken_1"),
                new SqlParameter("@NameToken", token),
                new SqlParameter("@UserName", userName),
                new SqlParameter("@IdTree", idTree));
            return token;
        }
        public string CreateLoginToken(string nameTree, string nameUser, int idUser, int idTree)
        {
            string token;
            token = GenerateToken();
            SqlHelper.ExecuteNonQuery(sConn, CommandType.StoredProcedure, "spTokens",
                new SqlParameter("@Activity", "CreateLoginToken"),
                new SqlParameter("@NameToken", token),
                new SqlParameter("@NameTree", nameTree),
                new SqlParameter("@UserName", nameUser),
                new SqlParameter("@IdUser", idUser),
                new SqlParameter("@IdTree", idTree));
            return token;

        }

        private string GenerateToken()
        {
            return System.Guid.NewGuid().ToString();
        }
        public ClassToken VerifyLoginToken(string token)
        {
            ClassToken clsToken = new ClassToken();
            DataTable dt = SqlHelper.ExecuteDataset(sConn, CommandType.StoredProcedure, "spTokens", new SqlParameter("@Activity", "VerifyLoginToken")).Tables[0];
            if (dt.Rows.Count>0)
            {
                clsToken.IdUser = Convert.ToInt32( dt.Rows[0]["IdUser"].ToString());
                clsToken.NameTree = dt.Rows[0]["NameTree"].ToString();
                clsToken.IdTree = Convert.ToInt32(dt.Rows[0]["IdTree"].ToString());
                clsToken.UserName = dt.Rows[0]["UserName"].ToString();
                DeleteToken(Convert.ToInt32(dt.Rows[0]["IdToken"].ToString()));

            }
            return clsToken;
            
        }

        public void DeleteToken(int idToken)
        {
            SqlHelper.ExecuteNonQuery(sConn, CommandType.TableDirect, "spTokens",
                new SqlParameter("@Activity", "DeleteToken"),
                new SqlParameter("@IdToken", idToken));
        }
    }
}
