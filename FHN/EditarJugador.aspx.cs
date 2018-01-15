using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaDominio;
using CapaNegocio;

namespace FHN
{
    public partial class EditarJugador : System.Web.UI.Page
    {
        IEnumerable<Jugador> datos;
        JugadorNego jugadorNego = new JugadorNego();
        ClubNego clubNego = new ClubNego();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarListaJugadores();
                CargarListaClubes();
            }
        }

        private void CargarListaJugadores()
        {
            IList<Jugador> nombreCompleto = jugadorNego.ListarJugadores().Select(j => new Jugador() { Nombre = "(" + j.IdJugador + ") " + j.Nombre + " " + j.Apellido, IdJugador = j.IdJugador }).OrderBy(c => c.IdJugador).ToList();

            ddlJugador.DataSource = nombreCompleto;
            ddlJugador.DataValueField = "idJugador";
            ddlJugador.DataBind();
        }
        private void CargarListaClubes()
        {
            ddlClub.DataSource = clubNego.ListarClubes().ToList();
            ddlClub.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarJugador();
        }

        private void ActualizarJugador()
        {
            Jugador jugador = new Jugador();







        }

        private void CargarJugador(int id)
        {
            //datos = jugadorNego.ListarUnicoJugador(id);

            //datosDataTable = ConvertirListaToDataTable(datos);

            //DataRow row = datosDataTable.Rows[0];
            //txtNombre.Text = Convert.ToString(row[1]);
            //txtApellido.Text = Convert.ToString(row[2]);
            //txtEdad.Text = Convert.ToString(row[3]);
            //txtDireccion.Text = Convert.ToString(row[4]);



        }

        protected void ddlJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJugador.Text = ddlJugador.SelectedValue.ToString();
            CargarJugador(Convert.ToInt32(lblIdJugador.Text));
        }
    }
}