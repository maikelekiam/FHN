using System;
using CapaDominio;
using CapaNegocio;

namespace FHN
{
    public partial class MostrarClub : System.Web.UI.Page
    {
        ClubNego clubNego = new ClubNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarClubSeleccionado();
        }
        public void MostrarClubSeleccionado()
        {
            Club club = clubNego.ObtenerClub(ListarClubes.idClubSeleccionado);

            if (club != null)
            {
                txtNombreInstitucional.Text = club.NombreInstitucional; 
                txtNombreCorto.Text = club.NombreCorto;
                txtIdInterno.Text = club.IdInterno;
                txtPersoneriaJuridica.Text = club.PersoneriaJuridica;
                txtAnioAfiliacion.Text = club.AnioAfiliacion;
                txtNumeroCuil.Text = club.NumeroCuil;

                txtDomicilioSede.Text = club.DomicilioSede;
                txtTelefonoSede.Text = club.TelefonoSede;
                txtEmail.Text = club.Email;
                txtEmailAlternativo.Text = club.EmailAlternativo;

                txtColoresOficiales.Text = club.ColoresOficiales;
                txtColoresAlternativos.Text = club.ColoresAlternativos;
                txtDomicilioCampoJuego.Text = club.DomicilioCampoJuego;
                txtTelefonoCampoJuego.Text = club.TelefonoCampoJuego;
                txtEmailCampoJuego.Text = club.EmailCampoJuego;
            }
            else
            {

            }
        }
    }
}