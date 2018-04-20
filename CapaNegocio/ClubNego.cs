using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaRepositorio;
using CapaDominio;

namespace CapaNegocio
{
    public class ClubNego
    {
        ClubRepo clubRepo = new ClubRepo();

        public void GuardarClub(Club club)
        {
            clubRepo.GuardarClub(club);
        }

        public IEnumerable<Club> ListarClubes()
        {
            return clubRepo.ListarClubes();
        }
        public string TraerClub(int id)
        {
            return clubRepo.TraerClub(id);
        }
        public Club ObtenerClub(int id)
        {
            return clubRepo.ObtenerClub(id);
        }
        public void ActualizarClub(Club Club)
        {
            clubRepo.ActualizarClub(Club);
        }

        public List<Club> ListarUnicoClub(int id)
        {
            return clubRepo.ListarUnicoClub(id);
        }
    }
}
