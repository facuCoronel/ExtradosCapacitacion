using EmpleadosDapper.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDapper.Datos
{
    internal class ImplementacionHelper
    {
        Helper h;

        public ImplementacionHelper()
        {
            h = new Helper();
        }
        public void MostrarPersonas()
        {
            var Listado = h.GetPersona();
            List<Persona> lP = new List<Persona>();

            foreach(var l in Listado)
            {

                Console.WriteLine(l.ToString());
            }
        }


        public void AscenderPersona(int tipo, int id)
        {
            h.PutAscenderPersona(tipo, id);
        }


        public void PostPersona(Persona p)
        {
            h.PostPersona(p);
        }
    }
}
