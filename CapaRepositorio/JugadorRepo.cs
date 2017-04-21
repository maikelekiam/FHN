using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class JugadorRepo
    {
        // METODO PARA GUARDAR UN JUGADOR
        public void GuardarJugador(Jugador jugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(jugador);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
