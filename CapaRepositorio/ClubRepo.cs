using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ClubRepo
    {
        // METODO PARA GUARDAR UN CLUB
        public void GuardarClub(Club club)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(club);
                modeloDeDominio.SaveChanges();
            }
        }
        // METODO PARA LISTAR LOS CLUBES
        public IEnumerable<Club> ListarClubes()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Club> result = modeloDeDominio.Clubs.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

    }
}
