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
        ClubNego clubNego = new ClubNego();

        public static List<int> listaDia = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        public static List<string> listaMes = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre" };
        public static List<int> listaAnio = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            LlenarFechas();

            CargarListaClubes();
        }
        private void CargarListaClubes()
        {
            ddlClub.DataSource = clubNego.ListarClubes().ToList();
            ddlClub.DataValueField = "idClub";
            ddlClub.DataBind();
        }

        private void LlenarFechas()
        {
            listaAnio.Clear();
            int anioHoy = DateTime.Now.Year;
            for (int i = 0; i < 100; i++) { listaAnio.Add(anioHoy - i); }

            ddlDia.DataSource = listaDia;
            ddlDia.DataBind();

            ddlMes.DataSource = listaMes;
            ddlMes.DataBind();

            ddlAnio.DataSource = listaAnio;
            ddlAnio.DataBind();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ChequearFechas() == true)
            {
                //if ((txtNombre.Text != "") && (txtApellido.Text != "") && (ddlClub.SelectedValue != "-1"))
                if ((txtNombre.Text != "") && (txtApellido.Text != ""))
                {
                    GuardarJugador();
                    Response.Redirect("ListarJugadores.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Complete los campos: NOMBRE y APELLIDO.')", true);
                }
            }
        }
        private void GuardarJugador()
        {
            Jugador jugador = new Jugador();

            jugador.Nombre = txtNombre.Text;
            jugador.Apellido = txtApellido.Text;
            jugador.Tipo = ddlTipoDocumento.SelectedValue.ToString();
            jugador.Documento = txtDocumento.Text;
            jugador.FechaNacDia = Convert.ToInt32(ddlDia.SelectedItem.ToString());
            jugador.FechaNacMes = ddlMes.SelectedValue.ToString();
            jugador.FechaNacAnio = Convert.ToInt32(ddlAnio.SelectedItem.ToString());
            jugador.Telefono = txtTelefono.Text;
            jugador.Celular = txtCelular.Text;
            jugador.Email = txtEmail.Text;
            jugador.Domicilio = txtDomicilio.Text;
            jugador.NumeroSocio = txtNumeroSocio.Text;
            jugador.Sector = ddlSector.SelectedValue.ToString();

            if (ddlClub.SelectedValue != "-1")
            {
                jugador.IdClub = Convert.ToInt32(ddlClub.SelectedValue);
            }
            else
            {
                jugador.IdClub = null;
            }

            jugador.ContactoNombre = txtContactoNombre.Text;
            jugador.ContactoParentezco = txtContactoParentezco.Text;
            jugador.ContactoTelefono = txtContactoTelefono.Text;

            if (chkActivo.Checked)
            {
                jugador.Activo = true;
            }
            else if (!chkActivo.Checked)
            {
                jugador.Activo = false;
            }

            jugadorNego.GuardarJugador(jugador);
        }
        public bool ChequearFechas()
        {
            if (ddlDia.Text == "30" || ddlDia.Text == "31")
            {
                if (ddlMes.Text == "Febrero")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Fecha Ingresada Incorrecta.')", true);

                    return false;
                }
            }
            if (ddlDia.Text == "31")
            {
                if (ddlMes.Text == "Febrero" || ddlMes.Text == "Abril" || ddlMes.Text == "Junio" || ddlMes.Text == "Setiembre" || ddlMes.Text == "Noviembre")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Fecha Ingresada Incorrecta.')", true);

                    return false;
                }
            }
            return true;
        }
    }
}