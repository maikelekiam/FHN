using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class UsuarioNego
    {
        UsuarioRepo usuarioRepo = new UsuarioRepo();

        public Usuario ObtenerUsuario(String nombreUsuario, String contrasenia)
        {
            return usuarioRepo.ObtenerUsuario(nombreUsuario, contrasenia);
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            usuarioRepo.ActualizarUsuario(usuario);
        }
        public IEnumerable<Usuario> MostrarUsuarios()
        {
            return usuarioRepo.MostrarUsuarios();
        }
        public void GuardarUsuario(Usuario usuario)
        {
            usuarioRepo.GuardarUsuario(usuario);
        }
        public Usuario ObtenerUsuario(int id)
        {
            return usuarioRepo.ObtenerUsuario(id);
        }
        public Usuario ControlarDuplicadoUsuario(String nombre)
        {
            return usuarioRepo.ControlarDuplicadoUsuario(nombre);
        }
    }
}