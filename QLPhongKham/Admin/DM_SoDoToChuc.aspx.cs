using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using ClassUserControl;

namespace QLPhongKham.Admin
{
    public partial class DM_SoDoToChuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTreeSoDoToChuc();
            }
        }
        void LoadTreeSoDoToChuc()
        {
            DataTable dt = new DataTable();
            dt = BLL.ModulePhongKham.Admin.SoDoToChuc_BLL.GetAllTreeById(6);
            DataRow[] dr = dt.Select("LeverTree = 0");
            foreach (DataRow row in dr)
            {
                TreeNode node = new TreeNode();
                node.Text = row["NameTree"].ToString();
                node.Value = row["IdTree"].ToString();
                LoadChildNode(dt, node);
                TreeSoDoToChuc.Nodes.Add(node);
            }
        }
        void LoadChildNode(DataTable dt, TreeNode node)
        {
            DataRow[] dr = dt.Select("ParentTree = " + node.Value);
            foreach (DataRow row in dr)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = row["NameTree"].ToString();
                childNode.Value = row["IdTree"].ToString();
                LoadChildNode(dt, childNode);
                node.ChildNodes.Add(childNode);
            }
        }

        protected void TreeSoDoToChuc_SelectedNodeChanged(object sender, EventArgs e)
        {
            
        }
    }
}