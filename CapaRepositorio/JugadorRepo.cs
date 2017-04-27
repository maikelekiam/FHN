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
        // METODO PARA GUARDAR UN JUGADOR
        public void GuardarJugador(Jugador jugador)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(jugador);
                modeloDeDominio.SaveChanges();
            }
        }

        // METODO PARA MOSTRAR LAS PERSONAS
        public IEnumerable<Jugador> ListarJugadores()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Jugador> result = modeloDeDominio.Jugadors.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        // METODO PARA ACTUALIZAR UN JUGADOR
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
