﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class MasterPageHotgate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMenu();
            }
        }
        void LoadMenu()
        { 
        
        }
        void LoadChildMenu()
        { 
        
        }
    }
}