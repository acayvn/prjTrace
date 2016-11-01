using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace WebForm
{
    public partial class DangKyTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }
        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            
            lblResult.InnerText = "";
            if (!KiemTraKeyUserName(txtTenDangNhap.Value) || string.IsNullOrEmpty(txtTenDangNhap.Value))
            {
                valiUserName.InnerText = "Tài khoản này đã tồn tại";
                valiUserName.Focus();
                return;
            }
            else
            {
                valiUserName.InnerText = "";
            }
            if (!KiemTraKeyEmail(txtEmail.Value) || string.IsNullOrEmpty(txtEmail.Value ))
            {
                valiEmail.InnerText = "Email này đã tồn tại";
                valiEmail.Focus();
                return;
            }
            else
            {
                valiEmail.InnerText = "";
            }
            if (txtMatKhau.Value.Length < 6)
            {
                valiPass1.InnerText = "Độ dài mật khẩu ít nhất 6 ký tự";
                return;
            }
            else
            {
                valiPass1.InnerText = "";
            }
            if (txtReMatKhau.Value.Length < 6)
            {
                valiPass2.InnerText = "Độ dài mật khẩu ít nhất 6 ký tự";
                return;
            }
            if (txtMatKhau.Value != txtReMatKhau.Value)
            {
                valiPass2.InnerText = "Mật khẩu nhắc lại không giống nhau";
                return;
            }
            else
            {
                valiPass2.InnerText = "";
            }
            BLL.ModuleOne.Hotgate.DangKyUser_BLL.DangKyUserHotgate(txtTenDangNhap.Value, MaHoaMD5(txtMatKhau.Value.ToString()), txtEmail.Value);
            txtEmail.Value = "";
            txtTenDangNhap.Value = "";
            lblResult.InnerText = "Đăng ký thành công";

        }

        public static bool KiemTraKeyUserName(string key)
        {
            return BLL.ModuleOne.Hotgate.Hotgate_BLL.CheckDangKyUser(key) == 0 ? true : false;
        }
        public static bool KiemTraKeyEmail(string key)
        {
            return BLL.ModuleOne.Hotgate.Hotgate_BLL.CheckDangKyEmail(key) == 0 ? true : false;
        }
        private static string MaHoaMD5(string password)
        {
            UTF32Encoding utf32 = new UTF32Encoding();
            string keyMaHoa = string.Format("{0}", password); 
            byte[] bytes = utf32.GetBytes(keyMaHoa);
            SHA1 md = new SHA1CryptoServiceProvider();
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] kq = md.ComputeHash(bytes);
            byte[] kq2 = md5.ComputeHash(kq);
            return Convert.ToBase64String(kq2);
        }

    }
}