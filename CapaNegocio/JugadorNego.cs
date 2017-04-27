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

        public IEnumerable<Jugador> ListarJugadores()
        {
            return jugadorRepo.ListarJugadores();
        }

        public void ActualizarJugador(Jugador jugador)
        {
            jugadorRepo.ActualizarJugador(jugador);
        }

        public List<Jugador> ListarUnicoJugador(int id)
        {
            return jugadorRepo.ListarUnicoJugador(id);
        }
    }
}
