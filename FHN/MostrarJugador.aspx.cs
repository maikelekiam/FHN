using System;
using CapaDominio;
using CapaNegocio;

namespace FHN
{
    public partial class MostrarJugador : System.Web.UI.Page
    {
        JugadorNego jugadorNego = new JugadorNego();
        ClubNego clubNego = new ClubNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarJugadorSeleccionado();
        }
        public void MostrarJugadorSeleccionado()
        {
            Jugador jugador = jugadorNego.ObtenerJugador(ListarJugadores.idJugadorSeleccionado);

            if (jugador != null)
            {
                txtNombre.Text = jugador.Nombre;
                txtApellido.Text = jugador.Apellido;
                txtDocumento.Text = jugador.Tipo + " " + jugador.Documento;
                txtFechaNacimiento.Text = jugador.FechaNacDia + " de " + jugador.FechaNacMes + " de " + jugador.FechaNacAnio;
                txtTelefono.Text = jugador.Telefono;
                txtCelular.Text = jugador.Celular;
                txtEmail.Text = jugador.Email;
                txtDomicilio.Text = jugador.Domicilio;
                txtNumeroSocio.Text = jugador.NumeroSocio;
                txtSector.Text = jugador.Sector;

                if (jugador.IdClub > 0) { txtClub.Text = clubNego.TraerClub(Convert.ToInt32(jugador.IdClub.Value)); }
                else { txtClub.Text = "No pertenece a ningun club."; }

                if (jugador.Activo == true) { txtActivo.Text = "JUGADOR ACTIVO"; }
                else { txtActivo.Text = "JUGADOR INACTIVO"; }

                txtContactoNombre.Text = jugador.ContactoNombre;
                txtContactoParentezco.Text = jugador.ContactoParentezco;
                txtContactoTelefono.Text = jugador.ContactoTelefono;
            }
            else
            {

            }
        }
    }
}
