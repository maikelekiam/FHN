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
    public partial class AltaJugador : System.Web.UI.Page
    {
        JugadorNego jugadorNego = new JugadorNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;


        }

        private void GuardarJugador()
        {
            Jugador jugador = new Jugador();

            jugador.Nombre = txtNombre.Text;
            jugador.Apellido = txtApellido.Text;
            jugador.Telefono = txtTelefono.Text;
            jugador.Celular = txtCelular.Text;
            jugador.Documento = txtDocumento.Text;
            jugador.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            jugador.Ficha = txtFicha.Text;
            jugador.Sector = ddlSector.SelectedValue.ToString();
            jugador.Tipo = ddlTipoDocumento.SelectedValue.ToString();
            jugador.Club = Convert.ToInt32(txtClub.Text);
            jugador.Email = txtEmail.Text;





            jugadorNego.GuardarJugador(jugador);






        }

        protected void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            GuardarJugador();
        }

    }
}