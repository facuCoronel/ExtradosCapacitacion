using Dapper;
using EmpleadosDapper.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpleadosDapper.Datos
{
    internal class Helper
    {
        private Persona p = new Persona();
        string stringConnection = @"Data Source=localhost;Initial Catalog=ExtradosEjercicioEmpresa;Integrated Security=True";



        public List<Persona> GetPersona()
        {
            string consulta = "select p.id_persona 'idPersona', p.Apellido 'Apellido', p.Nombre 'Nombre', Convert(varchar, p.FechaNac, 106) 'FechaNacimiento', t.tipo 'Tipo' from Personas p join TipoEmpleado t on p.id_tipo = t.id_tipo";
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var persona =  conn.Query<Persona>(consulta).ToList();

                return persona;

            }
        }



    }
}
