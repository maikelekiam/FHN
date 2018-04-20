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
    public partial class AltaCuotaJugador : System.Web.UI.Page
    {
        CuotaJugadorNego cuotaJugadorNego = new CuotaJugadorNego();

        public static List<int> listaDia = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        public static List<string> listaMes = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre" };
        public static List<int> listaAnio = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            int anioHoy = DateTime.Now.Year;
            for (int i = 0; i < 100; i++) { listaAnio.Add(anioHoy - i); }

            txtAnio.Text = Convert.ToString(DateTime.Now.Year);

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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ChequearFechas() == true)
            {
                if ((txtNombre.Text != ""))// && (ChequearAnio()==true))
                {
                    GuardarCuotaJugador();
                    Response.Redirect("ListarCuotasJugador.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Complete los campos: NOMBRE y AÑO.')", true);
                }
            }
        }
        private void GuardarCuotaJugador()
        {
            CuotaJugador cuotaJugador = new CuotaJugador();

            cuotaJugador.Nombre = txtNombre.Text;

            if (txtAnio.Text == "") { cuotaJugador.Anio = null; }
            else { cuotaJugador.Anio = Int32.Parse(txtAnio.Text); }

            cuotaJugador.FechaVencimientoDia = Convert.ToInt32(ddlDia.SelectedItem.ToString());
            cuotaJugador.FechaVencimientoMes = ddlMes.SelectedValue.ToString();
            cuotaJugador.FechaVencimientoAnio = Convert.ToInt32(ddlAnio.SelectedItem.ToString());

            String fecha = ddlDia.SelectedItem.ToString()+" - " + ddlMes.SelectedValue.ToString()+" - " + ddlAnio.SelectedItem.ToString();
            cuotaJugador.FechaVencimiento = Convert.ToDateTime(fecha);


            if (txtMonto.Text == "") { cuotaJugador.Monto = null; }
            else { cuotaJugador.Monto = Int32.Parse(txtMonto.Text); }

            cuotaJugador.Detalle = txtDetalles.Text;
            cuotaJugador.Observaciones = txtObservaciones.Text;

            cuotaJugadorNego.GuardarCuotaJugador(cuotaJugador);
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
        //public bool ChequearAnio()
        //{
        //    if (Convert.ToInt32(txtAnio.Text) < DateTime.Now.Year)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}