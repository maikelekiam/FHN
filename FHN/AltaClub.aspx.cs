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
    public partial class AltaClub : System.Web.UI.Page
    {
        ClubNego clubNego = new ClubNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void btnGuardarClub_Click(object sender, EventArgs e)
        {
            GuardarClub();
        }
        private void GuardarClub()
        {
            Club club = new Club();

            club.NombreInstitucional = txtNombreInstitucional.Text;
            club.IdInterno = txtIdInterno.Text;
            club.PersoneriaJuridica = txtPersoneriaJuridica.Text;
            club.AnioAfiliacion = txtAnioAfiliacion.Text;
            club.NumeroCuil = txtNumeroCuil.Text;
            club.DomicilioSede = txtDomicilioSede.Text;
            club.TelefonoSede = txtTelefonoSede.Text;
            club.Email = txtEmail.Text;
            club.EmailAlternativo = txtEmailAlternativo.Text;
            club.ColoresOficiales = txtColoresOficiales.Text;
            club.ColoresAlternativos = txtColoresAlternativos.Text;
            club.DomicilioCampoJuego = txtDomicilioCampoJuego.Text;
            club.TelefonoCampoJuego = txtTelefonoCampoJuego.Text;
            club.EmailCampoJuego = txtEmailCampoJuego.Text;

            clubNego.GuardarClub(club);
        }
    }
}