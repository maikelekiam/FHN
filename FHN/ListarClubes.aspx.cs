using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;
using System.Data;

namespace FHN
{
    public partial class ListarClubes : System.Web.UI.Page
    {
        ClubNego clubNego = new ClubNego();
        public static int idClubSeleccionado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarListaClubes();
        }
        private void MostrarListaClubes()
        {
            dgvClub.Columns[0].Visible = true;
            dgvClub.Columns[1].Visible = true;
            dgvClub.Columns[2].Visible = true;

            dgvClub.DataSource = clubNego.ListarClubes().OrderBy(c => c.NombreInstitucional).ToList();
            dgvClub.DataBind();

            dgvClub.Columns[0].Visible = false;
        }

        protected void dgvClub_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            idClubSeleccionado = Convert.ToInt32(dgvClub.Rows[e.RowIndex].Cells[0].Text);

            Response.Redirect("MostrarClub.aspx");
        }
    }
}