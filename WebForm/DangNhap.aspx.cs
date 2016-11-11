using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using ClassUserControl;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

using System.Web.Security;

namespace WebForm
{
    public partial class DangNhap : System.Web.UI.Page
    {
        
        int idTree = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["ValueTreeModuleOne"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string pa1 = MaHoaMD5("123");
                
            }
        }
        private static string MaHoaMD5(string password)
        {
            UTF32Encoding utf32 = new UTF32Encoding();
            string keyMaHoa = string.Format("{0}",password);
            byte[] bytes = utf32.GetBytes(keyMaHoa);            
            SHA1 md = new SHA1CryptoServiceProvider();
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] kq = md.ComputeHash(bytes);
            byte[] kq2 = md5.ComputeHash(kq);
            return Convert.ToBase64String(kq2);
        }
        private void Clear()
        {
            txtPass.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
        }
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            int trangThai = BLL.ModuleOne.ChucNang.BLL_DangNhap.CheckLogIn(txtTenDangNhap.Text, MaHoaMD5 (txtPass.Text));
            switch (trangThai)
            {
                case 1:
                    ClassUser clsUser = new ClassUser() { UserName = txtTenDangNhap.Text};
                    clsUser.ReadInfoUserByUserName(clsUser.UserName);
                    UserAuthorizations.ClassToken clsToken = new UserAuthorizations.ClassToken();
                    clsToken.UserName = txtTenDangNhap.Text.Trim();
                    clsToken.IdTree = Convert.ToInt32(ConfigurationManager.AppSettings["AppValue"].ToString());
                    clsToken.CreateLoginToken(clsToken.IdTree, clsToken.UserName);
                    Application["AppToken"] = clsToken;
                    FormsAuthentication.RedirectFromLoginPage(clsToken.UserName, false);
                    var ax = User.Identity.Name;
                    
                    Response.Redirect("Hotgate.aspx?Action=" + clsToken.CreateLoginToken(clsToken.IdTree, clsToken.UserName));

                    //SessionClass clsSession = new SessionClass(idTree);
                    //clsSession.IdUser = clsUser.IdUser;
                    //Session["ClassSession"] = clsSession;
                    //Response.Redirect("Hotgate.aspx");
                    break;
                case 2:
                    ClassUser clsU = new ClassUser();
                    clsU.UserName = txtTenDangNhap.Text;
                    break;
                case 3:
                    lblThongBao.Text = "Sai tai khoan hoac mat khau";
                    lblThongBao.Visible = true;
                    Clear();
                    break;
            }
        }

        void VerityToken()
        {
            
        }
    }
}
