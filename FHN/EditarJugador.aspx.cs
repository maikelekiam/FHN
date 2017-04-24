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
        List<Jugador> datos;
        DataTable datosDataTable;
        JugadorNego jugadorNego = new JugadorNego();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarListaJugadores();
            }
        }

        protected void ddlActualizarJugador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarListaJugadores()
        {
            datos = (List<Jugador>)jugadorNego.ListarJugadores();

            datosDataTable.Columns.Add("nombre_completo", typeof(string), "idJugador+ ' '+ nombre");

            ddlActualizarJugador.DataSource = datosDataTable;
            ddlActualizarJugador.DataTextField = "nombre_completo";
            ddlActualizarJugador.DataValueField = "idjugador";
            ddlActualizarJugador.DataBind();
        }
    }
}