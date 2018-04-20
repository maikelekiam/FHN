using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaRepositorio;
using CapaDominio;

namespace CapaNegocio
{
    public class CuotaJugadorNego
    {
        CuotaJugadorRepo cuotaJugadorRepo = new CuotaJugadorRepo();

        public IEnumerable<CuotaJugador> MostrarCuotaJugadores()
        {
            return cuotaJugadorRepo.MostrarCuotaJugadores();
        }
        public string TraerCuotaJugador(int id)
        {
            return cuotaJugadorRepo.TraerCuotaJugador(id);
        }
        public void GuardarCuotaJugador(CuotaJugador jugador)
        {
            cuotaJugadorRepo.GuardarCuotaJugador(jugador);
        }
        public CuotaJugador ObtenerCuotaJugador(int id)
        {
            return cuotaJugadorRepo.ObtenerCuotaJugador(id);
        }
        public IEnumerable<CuotaJugador> ListarCuotaJugadores()
        {
            return cuotaJugadorRepo.ListarCuotaJugadores();
        }
        public void ActualizarCuotaJugador(CuotaJugador jugador)
        {
            cuotaJugadorRepo.ActualizarCuotaJugador(jugador);
        }

        public List<CuotaJugador> ListarUnicoCuotaJugador(int id)
        {
            return cuotaJugadorRepo.ListarUnicoCuotaJugador(id);
        }
    }
}
