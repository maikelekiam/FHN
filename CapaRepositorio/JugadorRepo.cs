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
        public IEnumerable<Jugador> MostrarJugadores()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Jugador> result = modeloDeDominio.Jugadors.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public string TraerJugador(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Jugador result = modeloDeDominio.Jugadors.Where(c => c.IdJugador == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Apellido + "," + result.Nombre;
            }
        }
        public void GuardarJugador(Jugador jugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(jugador);
                modeloDeDominio.SaveChanges();
            }
        }
        public IEnumerable<Jugador> ListarJugadores()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Jugador> result = modeloDeDominio.Jugadors.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public int TraerJugadorIdSegunItem(string itemApellido, string itemNombre)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Jugador result = modeloDeDominio.Jugadors.Where(c => ((c.Nombre == itemNombre) && (c.Apellido == itemApellido))).FirstOrDefault();
                modeloDeDominio.CreateDetachedCopy(result);
                return result.IdJugador;
            }
        }
        public Jugador ObtenerJugador(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Jugador result = modeloDeDominio.Jugadors.Where(c => c.IdJugador == id).FirstOrDefault();

                //modeloDeDominio.CreateDetachedCopy(result);

                return result;
            }
        }
        public void ActualizarJugador(Jugador jugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(jugador);
                modeloDeDominio.SaveChanges();
            }
        }
        public List<Jugador> ListarUnicoJugador(int id)
        {
            List<Jugador> datosLista;

            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Jugador> listaDeJugadores = modeloDeDominio.Jugadors.Where(c => c.IdJugador == id).ToList();
                datosLista = (List<Jugador>)listaDeJugadores;
            }

            return datosLista;
        }
    }
}
