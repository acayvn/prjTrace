using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace UserAuthorizations
{
    class ClassUser_DAO : BaseDAO
    {
        public bool Them(ClassUser clsUser)
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@Activity", "CreatNew"));
            lst.Add(new SqlParameter("@UserName", clsUser.UserName));
            lst.Add(new SqlParameter("@Password", clsUser.Password));
            lst.Add(new SqlParameter("@TenDayDu", clsUser.FullName));
            lst.Add(new SqlParameter("@Email", clsUser.Email));
            lst.Add(new SqlParameter("@SDT", clsUser.Phone));
            lst.Add(new SqlParameter("@DiaChi", clsUser.Address));
            lst.Add(new SqlParameter("@NamSinh", clsUser.YeahOfBirth));
            lst.Add(new SqlParameter("@GioiTinh", clsUser.Sex));
            int kq = Convert.ToInt32(SqlHelper.ExecuteScalar(sConn, CommandType.StoredProcedure, "spUsers",
                lst.ToArray()));
            return kq == 1 ? true : false;
        }
        /// <summary>
        /// Sửa: clsUser.FullName, clsUser.Email, clsUser.Phone, clsUser.Address, clsUser.YeahOfBirth, clsUser.Sex
        /// </summary>
        /// <param name="clsUser"></param>
        public void Sua(ClassUser clsUser)
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@Activity", "UpdateById"));
            lst.Add(new SqlParameter("@TenDayDu", clsUser.FullName));
            lst.Add(new SqlParameter("@Email", clsUser.Email));
            lst.Add(new SqlParameter("@SDT", clsUser.Phone));
            lst.Add(new SqlParameter("@DiaChi", clsUser.Address));
            lst.Add(new SqlParameter("@NamSinh", clsUser.YeahOfBirth));
            lst.Add(new SqlParameter("@GioiTinh", clsUser.Sex));
            lst.Add(new SqlParameter("@Id", clsUser.Id));
            SqlHelper.ExecuteNonQuery(sConn, CommandType.StoredProcedure, "spUsers",
                lst.ToArray());
        }
        /// <summary>
        /// Xoa theo clsUser.Id
        /// </summary>
        /// <param name="clsUser"></param>
        public void Xoa(ClassUser clsUser)
        {
            SqlHelper.ExecuteNonQuery(sConn, CommandType.StoredProcedure, "spUsers",
                new SqlParameter("@Activity", "DeleteById"),
                new SqlParameter("@IdUser", clsUser.Id));
        }

        public ClassUser GetUserById(int idUser)
        {
            return new ClassUser();
        }

        public DataTable GetUserByChucNang(int idChucNang)
        {
            return new DataTable();
        }

        public List<ClassUser> GetListUserByChucNang(int idChucNang)
        {
            List<ClassUser> lst = new List<ClassUser>();
            return lst;
        }

        public DataTable GetUserByUserName(string userName)
        {
            return new DataTable();
        }

    }
}
