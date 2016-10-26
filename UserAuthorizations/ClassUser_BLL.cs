using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UserAuthorizations
{
    public class ClassUser_BLL
    {
        public static bool Them(ClassUser clsUser)
        {
            return new ClassUser_DAO().Them(clsUser);
        }
        public static void Sua(ClassUser clsUser)
        {
            new ClassUser_DAO().Sua(clsUser);
        }
        public static void Xoa(ClassUser clsUser)
        {
            new ClassUser_DAO().Xoa(clsUser);
        }
        public static ClassUser GetUserById(int idUser)
        {
            return new ClassUser_DAO().GetUserById(idUser);
        }
        public static DataTable GetUserByChucNang(int idChucNang)
        {
            return new ClassUser_DAO().GetUserByChucNang(idChucNang);
        }
        public static List<ClassUser> GetListUserByChucNang(int idChucNang)
        {
            return new ClassUser_DAO().GetListUserByChucNang(idChucNang);
        }
        public static DataTable GetUserByUserName(string userName)
        {
            return new ClassUser_DAO().GetUserByUserName(userName);
        }
    }
}
