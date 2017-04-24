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
    }
}
