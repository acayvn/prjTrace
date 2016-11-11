using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassUserControl;
using BLL;
using System.Data;

namespace QLPhongKham
{
    public partial class MasterPhongKham : System.Web.UI.MasterPage
    {
        public string menuText = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //KiemTraSession();
            if (!IsPostBack)
            {
                LoadMenuText();
            }
        }
        void KiemTraSession()
        {
            if (Session["ClassSession"] == null)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Hotgate"].ToString());
            }
            else
            {
                SessionClass clsSession = (SessionClass)Session["ClassSession"];

                ClassUser clsUser = new ClassUser();
                clsUser.IdUser = clsSession.IdUser;
                if (clsSession.IdUser == 0 || string.IsNullOrEmpty(clsSession.IdUser.ToString()) || clsSession.IdTree == 0 || string.IsNullOrEmpty(clsSession.IdTree.ToString()))
                {
                    Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Hotgate"].ToString());
                }
                else
                {
                    clsUser.ReadInfoUserByID(clsUser.IdUser);
                    lblInfo.InnerText = string.Format("Chào mừng: {0}", clsUser.UserName);
                }
            }


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

        protected void btnDangXuat_Click(object sender, EventArgs e)
        {
            Session["ClassSession"] = null;
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Hotgate"].ToString());
        }
    }
}