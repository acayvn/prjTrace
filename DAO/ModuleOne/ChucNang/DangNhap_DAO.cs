using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;


namespace DAO.DangNhap
{
    public class DangNhap_DAO:BaseDAO
    {
        public int KiemTraDangNhap(string userName, string password)
        {
            int kq = Convert.ToInt32(SqlHelper.ExecuteScalar(sConnU(), CommandType.StoredProcedure, "spDangNhap", new SqlParameter("@Activity", "DangNhap"), new SqlParameter("@UserName", userName), new SqlParameter("@PassWord", password)));            
            return kq;
        }
    }
}
