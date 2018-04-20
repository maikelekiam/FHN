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
    public partial class EditarClub : System.Web.UI.Page
    {
        ClubNego clubNego = new ClubNego();
        IEnumerable<Club> listaClubes;
        static int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarListaClubes();
        }

        protected void ddlClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlClub.SelectedValue != "-1")
            {
                //OBTENGO EL ID DEL CLUB SELECCIONADO DESDE EL DROPDOWNLIST
                id = Convert.ToInt32(ddlClub.SelectedValue.ToString());

                CargarClub(id);
            }
            else
            {
                LimpiarFormulario();
            }
        }
        private void CargarListaClubes()
        {
            listaClubes = clubNego.ListarClubes();

            ddlClub.DataSource = listaClubes.OrderBy(c => c.NombreInstitucional).ToList();
            ddlClub.DataTextField = "nombreInstitucional";
            ddlClub.DataValueField = "idClub";
            ddlClub.DataBind();
        }

        protected void btnActualizarClub_Click(object sender, EventArgs e)
        {
            if ((txtNombreCorto.Text != "") && (txtNombreInstitucional.Text != ""))
            {
                ActualizarClub();

                Response.Redirect("ListarClubes.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Complete los campos: NOMBRES.')", true);
            }
        }
        private void ActualizarClub()
        {
            Club club = new Club();

            club.IdClub = id;

            club.NombreInstitucional = txtNombreInstitucional.Text;
            club.NombreCorto = txtNombreCorto.Text;
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

            clubNego.ActualizarClub(club);
        }
        private void CargarClub(int id)
        {
            Club club = clubNego.ObtenerClub(id);

            txtNombreCorto.Text = club.NombreCorto;
            txtNombreInstitucional.Text = club.NombreInstitucional;
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
        public void LimpiarFormulario()
        {

        }
    }
}