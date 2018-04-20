using System;
using System.Linq;
using System.Web.UI.WebControls;
using CapaNegocio;
using System.Windows.Forms;





namespace FHN
{
    public partial class ListarCuotasJugador : System.Web.UI.Page
    {
        CuotaJugadorNego cuotaJugadorNego = new CuotaJugadorNego();
        public static int idCuotaJugadorSeleccionada;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarListaCuotaJugadores();
        }

        protected void dgvCuotaJugadores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            idCuotaJugadorSeleccionada = Convert.ToInt32(dgvCuotaJugadores.Rows[e.RowIndex].Cells[0].Text);

            Response.Redirect("MostrarCuotaJugador.aspx");
        }
        private void MostrarListaCuotaJugadores()
        {
            dgvCuotaJugadores.Columns[0].Visible = true;
            dgvCuotaJugadores.Columns[1].Visible = true;
            dgvCuotaJugadores.Columns[2].Visible = true;

            dgvCuotaJugadores.DataSource = cuotaJugadorNego.MostrarCuotaJugadores().OrderBy(c => c.FechaVencimiento).ToList();
            dgvCuotaJugadores.DataBind();

            dgvCuotaJugadores.Columns[0].Visible = false;
        }
    }
}