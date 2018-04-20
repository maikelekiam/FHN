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

        public IEnumerable<Jugador> MostrarJugadores()
        {
            return jugadorRepo.MostrarJugadores();
        }
        public string TraerJugador(int id)
        {
            return jugadorRepo.TraerJugador(id);
        }
        public void GuardarJugador(Jugador jugador)
        {
            jugadorRepo.GuardarJugador(jugador);
        }
        public int TraerJugadorIdSegunItem(string item1, string item2)
        {
            return jugadorRepo.TraerJugadorIdSegunItem(item1, item2);
        }
        public Jugador ObtenerJugador(int id)
        {
            return jugadorRepo.ObtenerJugador(id);
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
