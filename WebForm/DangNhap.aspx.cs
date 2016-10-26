using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using ClassUserControl;
namespace WebForm
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                
                
            }
        }
        private void Clear()
        {
            txtPass.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
        }
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            int trangThai = BLL.ModuleOne.ChucNang.BLL_DangNhap.CheckLogIn(txtTenDangNhap.Text, txtPass.Text);
            switch (trangThai)
            {
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
    }
}
