using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using ClassUserControl;


namespace WebForm
{
    public partial class Hotgate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadModules();
            }
        }
        void LoadModules()
        {
            DataTable dt = BLL.ModuleOne.Hotgate.Hotgate_BLL.LoadModules();
            viewHotgate.DataSource = dt;
            viewHotgate.DataBind();                        
        }

        protected void btnImage_Click(object sender, ImageClickEventArgs e)
        {
            int idTree = Convert.ToInt32((sender as ImageButton).CommandArgument);
            SessionClass clsSession = (SessionClass)Session["SessionClass"];
            clsSession.IdTree = idTree;
            Session["SessionClass"] = clsSession;
            Response.Redirect((sender as ImageButton).);
        }

        protected void btnLink_Click(object sender, EventArgs e)
        {

        }
    }
}