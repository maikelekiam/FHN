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
        public string TraerClub(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Club result = modeloDeDominio.Clubs.Where(c => c.IdClub == id).FirstOrDefault();

                return result.NombreInstitucional;
            }
        }
        public Club ObtenerClub(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Club result = modeloDeDominio.Clubs.Where(c => c.IdClub == id).FirstOrDefault();

                return result;
            }
        }
        public void ActualizarClub(Club club)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(club);
                modeloDeDominio.SaveChanges();
            }
        }
        public List<Club> ListarUnicoClub(int id)
        {
            List<Club> datosLista;

            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Club> listaClubes = modeloDeDominio.Clubs.Where(c => c.IdClub == id).ToList();

                datosLista = (List<Club>)listaClubes;
            }
            return datosLista;
        }
    }
}
