using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using ClassUserControl;


namespace WebForm
{
    public partial class MasterPageHotgate : System.Web.UI.MasterPage
    {
        public string menuText = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemTraSession();
            if (!IsPostBack)
            {
                //LoadMenu();
                LoadMenuText();
            }
        }
        void LoadMenu()
        {
            DataTable dt = BLL.GetChildsById.GetChildMenuById(1);
            DataRow[] dr = dt.Select("LeverMenu = 1");
            foreach (DataRow r in dr)
            {
                MenuItem mnu = new MenuItem();
                mnu.Text = r["NameMenu"].ToString();
                mnu.Value = r["IdMenu"].ToString();
                mnuHotgate.Items.Add(mnu);
                LoadChildMenu(dt, mnu);
            }
        }
        void LoadChildMenu(DataTable dt, MenuItem mnu)
        {
            DataRow[] dr = dt.Select("ParentMenu = " + mnu.Value);
            foreach (DataRow r in dr)
            {
                MenuItem item = new MenuItem();
                item.Text = r["NameMenu"].ToString();
                item.Value = r["IdMenu"].ToString();
                mnu.ChildItems.Add(item);
                LoadChildMenu(dt, item);
            }

        }
        void KiemTraSession()
        {
            string _userName = Page.User.Identity.Name;
            if (Session["ClassSession"] == null)
            {
                Response.Redirect("DangNhap.aspx");
            }
            else
            {
                SessionClass clsSession = (SessionClass)Session["ClassSession"];

                ClassUser clsUser = new ClassUser();
                clsUser.IdUser = clsSession.IdUser;
                if (clsSession.IdUser == 0 || string.IsNullOrEmpty(clsSession.IdUser.ToString()) || clsSession.IdTree == 0 || string.IsNullOrEmpty(clsSession.IdTree.ToString()))
                {
                    Response.Redirect("DangNhap.aspx");
                }
                else
                {
                    clsUser.ReadInfoUserByID(clsUser.IdUser);
                    lblWellcome.Text = string.Format("Chào mừng: {0}", clsUser.UserName);
                }
            }


        }
        void KiemTraToken(string userName, int idTree)
        {
            string _userName = Page.User.Identity.Name;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["ClassSession"] = null;
            Response.Redirect("DangNhap.aspx");
        }


        void LoadMenuText()
        {
            DataTable dt = BLL.GetChildsById.GetChildMenuById(1);
            DataRow[] dr = dt.Select("LeverMenu = 1");
            menuText += "<ul>";
            foreach (DataRow r in dr)
            {
                menuText += "<li>";
                menuText += "<a href=\"#\">";
                menuText += r["NameMenu"].ToString();
                menuText += "</a>";
                menuText += LoadChildMenuText(dt, Convert.ToInt32(r["IdMenu"].ToString()));
                menuText += "</li>";
            }
            menuText += "</ul>";
        }
        private string LoadChildMenuText(DataTable dt, int Id)
        {
            string kq = "";
            DataRow[] dr = dt.Select("ParentMenu = " + Id);
            if (dr.Any())
            {
                kq += "<ul>";
                foreach (DataRow r in dr)
                {
                    kq += "<li>";
                    kq += "<a href=\"#\">";
                    kq += r["NameMenu"].ToString();
                    kq += "</a>";
                    kq += LoadChildMenuText(dt, Convert.ToInt32(r["IdMenu"].ToString()));
                    kq += "</li>";
                }
                kq += "</ul>";
                return kq;
            }

            return kq;

        }
    }
}