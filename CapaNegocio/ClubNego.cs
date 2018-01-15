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

    }
}
