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
    public partial class ListarJugadores : System.Web.UI.Page
    {
        JugadorNego jugadorNego = new JugadorNego();
        public static int idJugadorSeleccionado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarListaJugadores();
        }
        private void MostrarListaJugadores()
        {
            dgvJugador.Columns[0].Visible = true;
            dgvJugador.Columns[1].Visible = true;
            dgvJugador.Columns[2].Visible = true;
            dgvJugador.Columns[3].Visible = true;
            dgvJugador.Columns[4].Visible = true;
            dgvJugador.Columns[5].Visible = true;

            dgvJugador.DataSource = jugadorNego.MostrarJugadores().OrderBy(c => c.Nombre).ToList();
            dgvJugador.DataBind();

            dgvJugador.Columns[0].Visible = false;
        }


        protected void dgvJugador_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            idJugadorSeleccionado = Convert.ToInt32(dgvJugador.Rows[e.RowIndex].Cells[0].Text);

            Response.Redirect("MostrarJugador.aspx");
        }
    }
}