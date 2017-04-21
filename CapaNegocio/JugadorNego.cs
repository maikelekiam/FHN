using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaRepositorio;
using CapaDominio;

namespace CapaNegocio
{
    public class JugadorNego
    {
        JugadorRepo jugadorRepo = new JugadorRepo();

        public void GuardarJugador(Jugador jugador)
        {
            jugadorRepo.GuardarJugador(jugador);
        }
    }
}
