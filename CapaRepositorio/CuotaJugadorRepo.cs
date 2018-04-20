using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class CuotaJugadorRepo
    {
        public IEnumerable<CuotaJugador> MostrarCuotaJugadores()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<CuotaJugador> result = modeloDeDominio.CuotaJugadors.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public string TraerCuotaJugador(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                CuotaJugador result = modeloDeDominio.CuotaJugadors.Where(c => c.IdCuotaJugador == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }
        public void GuardarCuotaJugador(CuotaJugador cuotaJugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(cuotaJugador);
                modeloDeDominio.SaveChanges();
            }
        }
        public IEnumerable<CuotaJugador> ListarCuotaJugadores()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<CuotaJugador> result = modeloDeDominio.CuotaJugadors.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public CuotaJugador ObtenerCuotaJugador(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                CuotaJugador result = modeloDeDominio.CuotaJugadors.Where(c => c.IdCuotaJugador == id).FirstOrDefault();

                //modeloDeDominio.CreateDetachedCopy(result);

                return result;
            }
        }
        public void ActualizarCuotaJugador(CuotaJugador cuotaJugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(cuotaJugador);
                modeloDeDominio.SaveChanges();
            }
        }
        public List<CuotaJugador> ListarUnicoCuotaJugador(int id)
        {
            List<CuotaJugador> datosLista;

            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<CuotaJugador> listaDeCuotaJugadores = modeloDeDominio.CuotaJugadors.Where(c => c.IdCuotaJugador == id).ToList();
                datosLista = (List<CuotaJugador>)listaDeCuotaJugadores;
            }

            return datosLista;
        }
    }
}