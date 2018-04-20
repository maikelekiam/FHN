using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;

namespace FHN
{
    public partial class Contenidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if ((string)Session["usergrupo"].ToString() == "1")
            {
                Panel.Visible = true;
            }
            else
            {
                Panel.Visible = false;
            }
        }
    }
}