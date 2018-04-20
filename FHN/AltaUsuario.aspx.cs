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
    public partial class AltaUsuario : System.Web.UI.Page
    {
        UsuarioNego usuarioNego = new UsuarioNego();
        static string usuarioControlNombre;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["usergrupo"].ToString() == "1")
                {
                    PanelAltaUsuario.Visible = true;
                }
                else
                {
                    PanelAltaUsuario.Visible = false;
                }

                btnGuardar.Visible = true;
                btnActualizar.Visible = false;

                MostrarListas();

                MostrarGrillaUsuarios();
            }
        }
        public void MostrarListas()
        {
            ddlUsuarios.DataSource = usuarioNego.MostrarUsuarios().ToList().OrderBy(c => c.Nombre);
            ddlUsuarios.DataValueField = "idUsuario";
            ddlUsuarios.DataBind();
        }
        public void MostrarGrillaUsuarios()
        {
            dgvUsuario.DataSource = usuarioNego.MostrarUsuarios().ToList().OrderBy(c => c.Nombre);
            dgvUsuario.DataBind();
        }

        protected void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = usuarioNego.ObtenerUsuario(Convert.ToInt32(ddlUsuarios.SelectedItem.Value));

            lblIdUsuario.Text = ddlUsuarios.SelectedValue.ToString();

            CargarUsuario(usuario);
        }
        public void CargarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                usuarioControlNombre = usuario.Nombre;

                btnGuardar.Visible = false;
                btnActualizar.Visible = true;

                txtNombre.Text = usuario.Nombre;
                txtContrasenia.Text = usuario.Contrasenia;
                txtGrupo.Text = Convert.ToString(usuario.Grupo);
                txtMail.Text = usuario.Mail;
            }
            else
            {
                btnGuardar.Visible = true;
                btnActualizar.Visible = false;

                LimpiarFormularioUsuario();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;

            GuardarUsuario();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;

            ActualizarUsuario();
        }
        private void GuardarUsuario()
        {
            if (txtNombre.Text != "" && txtContrasenia.Text != "" && txtMail.Text != "" && txtGrupo.Text != "")
            {
                Usuario usuarioControl = usuarioNego.ControlarDuplicadoUsuario(txtNombre.Text);

                if (usuarioControl == null)
                {
                    Usuario usuario = new Usuario();

                    usuario.Nombre = txtNombre.Text;
                    usuario.Contrasenia = txtContrasenia.Text;
                    usuario.Grupo = Convert.ToInt32(txtGrupo.Text);
                    usuario.Mail = txtMail.Text;

                    usuarioNego.GuardarUsuario(usuario);

                    MostrarGrillaUsuarios();

                    LimpiarFormularioUsuario();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('El Nombre de Usuario ya existe. Ingrese otro.')", true);
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Debe completar todos los campos.')", true);
            }
        }

        private void ActualizarUsuario()
        {
            if (txtNombre.Text != "" && txtContrasenia.Text != "" && txtMail.Text != "" && txtGrupo.Text != "")
            {
                Usuario usuarioControl = usuarioNego.ControlarDuplicadoUsuario(txtNombre.Text);

                if (usuarioControl == null)
                {
                    //significa que no esta en la base, entonces se puede actualizar
                    // => ACTUALIZO
                    Usuario usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(lblIdUsuario.Text);
                    usuario.Nombre = txtNombre.Text;
                    usuario.Contrasenia = txtContrasenia.Text;
                    usuario.Grupo = Convert.ToInt32(txtGrupo.Text);
                    usuario.Mail = txtMail.Text;

                    usuarioNego.ActualizarUsuario(usuario);

                    MostrarGrillaUsuarios();

                    LimpiarFormularioUsuario();

                    Response.Redirect("AltaUsuario.aspx");

                    ddlUsuarios.Text = "-1";

                }
                else if (usuarioControl != null)
                {
                    //1ra Opcion: el nombre ingresado es igual al nombre cargado
                    if (usuarioControlNombre == usuarioControl.Nombre)
                    {
                        //Actualizo
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = Convert.ToInt32(lblIdUsuario.Text);
                        usuario.Nombre = txtNombre.Text;
                        usuario.Contrasenia = txtContrasenia.Text;
                        usuario.Grupo = Convert.ToInt32(txtGrupo.Text);
                        usuario.Mail = txtMail.Text;

                        usuarioNego.ActualizarUsuario(usuario);

                        MostrarGrillaUsuarios();

                        LimpiarFormularioUsuario();

                        Response.Redirect("AltaUsuario.aspx");

                        ddlUsuarios.Text = "-1";
                    }
                    else if (usuarioControlNombre != usuarioControl.Nombre)
                    {
                        lblGrupo.Text = usuarioControlNombre;
                        lblMail.Text = usuarioControl.Nombre;

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('El Nombre de Usuario ya existe. Ingrese otro.')", true);

                        btnGuardar.Visible = false;
                        btnActualizar.Visible = true;
                    }
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Complete todos los campos.')", true);

                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
            }
        }
        public void LimpiarFormularioUsuario()
        {
            txtNombre.Text = "";
            txtContrasenia.Text = "";
            txtGrupo.Text = "";
            txtMail.Text = "";
        }
    }
}