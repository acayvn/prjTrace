using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;


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
    }
}