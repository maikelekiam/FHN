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
        //IEnumerable<Jugador> datos;
        JugadorNego jugadorNego = new JugadorNego();
        ClubNego clubNego = new ClubNego();
        IEnumerable<Club> listaClubes;

        static int id;

        public static List<int> listaDia = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        public static List<string> listaMes = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre" };
        public static List<int> listaAnio = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            lblIdJ.Visible = false;
            lblIdJugador.Visible = false;

            CargarListaJugadores();
            CargarListaClubes();
            LlenarFechas();
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

        private void CargarListaJugadores()
        {
            IList<Jugador> nombreCompleto = jugadorNego.ListarJugadores().Select(j => new Jugador() { Nombre = "(Socio: " + j.NumeroSocio + ") " + j.Nombre + " " + j.Apellido, IdJugador = j.IdJugador }).OrderBy(c => c.NumeroSocio).ToList();
            //IList<Jugador> nombreCompleto = jugadorNego.ListarJugadores().Select(j => new Jugador() { Nombre = j.Nombre + " " + j.Apellido, IdJugador = j.IdJugador }).OrderBy(c => c.IdJugador).ToList();

            ddlJugador.DataSource = nombreCompleto;
            ddlJugador.DataValueField = "idJugador";
            ddlJugador.DataBind();
        }
        private void CargarListaClubes()
        {
            listaClubes = clubNego.ListarClubes();

            ddlClub.DataSource = listaClubes.OrderBy(c => c.NombreInstitucional).ToList();
            ddlClub.DataTextField = "nombreInstitucional";
            ddlClub.DataValueField = "idClub";
            ddlClub.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ChequearFechas() == true)
            {
                if ((txtNombre.Text != "") && (txtApellido.Text != ""))
                {
                    ActualizarJugador();
                    Response.Redirect("ListarJugadores.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Complete los campos: NOMBRE y APELLIDO.')", true);
                }
            }
        }

        private void ActualizarJugador()
        {
            Jugador jugador = new Jugador();

            jugador.IdJugador = id;

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

            jugadorNego.ActualizarJugador(jugador);

            //Faltaria limpiar el formulario...



        }

        private void CargarJugador(int id)
        {
            Jugador jugador = jugadorNego.ObtenerJugador(id);

            txtNombre.Text = jugador.Nombre;
            txtApellido.Text = jugador.Apellido;
            ddlTipoDocumento.Text = jugador.Tipo;
            txtDocumento.Text = jugador.Documento;
            ddlDia.Text = Convert.ToString(jugador.FechaNacDia);
            ddlMes.Text = jugador.FechaNacMes;
            ddlAnio.Text = Convert.ToString(jugador.FechaNacAnio);
            txtTelefono.Text = jugador.Telefono;
            txtCelular.Text = jugador.Celular;
            txtEmail.Text = jugador.Email;
            txtDomicilio.Text = jugador.Domicilio;
            txtNumeroSocio.Text = jugador.NumeroSocio;
            ddlSector.Text = jugador.Sector;

            if (jugador.IdClub > 0) { ddlClub.Text = Convert.ToString(jugador.IdClub); }
            else { ddlClub.Text = "-1"; }

            //ddlClub.Text = Convert.ToString(jugador.IdClub);

            txtContactoNombre.Text = jugador.ContactoNombre;
            txtContactoParentezco.Text = jugador.ContactoParentezco;
            txtContactoTelefono.Text = jugador.ContactoTelefono;

            if (jugador.Activo==true)
            {
                chkActivo.Checked = true;
            }
            else if (jugador.Activo == false)
            {
                chkActivo.Checked = false;
            }
        }

        protected void ddlJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblIdJugador.Text = ddlJugador.SelectedValue.ToString();

            //CargarJugador(Convert.ToInt32(lblIdJugador.Text));

            if (ddlJugador.SelectedValue != "-1")
            {
                //OBTENGO EL ID DEL JUGADOR SELECCIONADO DESDE EL DROPDOWNLIST
                id = Convert.ToInt32(ddlJugador.SelectedValue.ToString());

                //Jugador jugador = jugadorNego.ListarUnicoJugador(id);

                CargarJugador(id);
            }
            else
            {
                LimpiarFormulario();
            }
        }
        public void LimpiarFormulario()
        {

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