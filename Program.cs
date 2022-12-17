using EmpleadosDapper.Datos;
using EmpleadosDapper.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ImplementacionHelper ih = new ImplementacionHelper();

            Console.WriteLine("0. Agregar Personal");
            Console.WriteLine("1. Mostrar Personal");
            Console.WriteLine("2. Ascender a persona");
            Console.WriteLine("3. Salir");
            int comando = Convert.ToInt32(Console.ReadLine());
            while (comando != 3)
            {

                if(comando == 0)
                {
                    Persona p = new Persona();
                    Console.WriteLine("Nombre:");
                    p.Nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    p.Apellido = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento: ");
                    p.FechaNacimiento = Console.ReadLine();
                    Console.WriteLine("tipo Empleado (numerico)");
                    Console.WriteLine("1. Empleado, 2. Supervisor, 3. Encargado Regional");
                    p.idTipo = Convert.ToInt32(Console.ReadLine());
                    ih.PostPersona(p);
                    Console.WriteLine("--------------------------------------------------------------");
                }

                if (comando == 1)
                {

                    ih.MostrarPersonas();
                    Console.WriteLine("--------------------------------------------------------------");
                }
                if(comando == 2)
                {
                    Console.WriteLine("3. Ingrese Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2 supervisor, 3 encargado regional");

                    int tipo = Convert.ToInt32(Console.ReadLine());
                    ih.AscenderPersona(tipo, id);
                    Console.WriteLine("--------------------------------------------------------------");
                }


                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("0. Agregar Personal");
                Console.WriteLine("1. Mostrar Personal");
                Console.WriteLine("2. Ascender a persona");
                Console.WriteLine("3. Salir");
                comando = Convert.ToInt32(Console.ReadLine());
            }

           




        }
    }
}
