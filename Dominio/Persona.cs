using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDapper.Dominio
{
    internal class Persona : TipoEmpleado
    {
        public int idPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }


        public override string ToString()
        {
            return $"Id: {idPersona}  ||  Apellido y nombre: {Apellido}, {Nombre}  ||  Fecha Nac: {FechaNacimiento}  ||  Tipo Empleado: {Tipo}";
        }

    }
}
