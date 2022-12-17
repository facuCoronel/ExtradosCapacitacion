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
            string consulta = "select p.id_persona 'idPersona', p.Apellido 'Apellido', p.Nombre 'Nombre', Convert(varchar, p.FechaNac, 106) 'FechaNacimiento', t.tipo 'Tipo' " +
                "               from Personas p join TipoEmpleado t on p.id_tipo = t.id_tipo";
            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var persona = conn.Query<Persona>(consulta).ToList();

                return persona;

            }
        }

        public void PutAscenderPersona(int tipo, int id)
        {
            string consulta = @"update Personas set id_tipo = @tipo where id_persona = @id ";

            using (var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var parametros = new DynamicParameters();

                parametros.Add("@tipo", tipo);
                parametros.Add("@id", id);

                conn.Execute(consulta, parametros, commandType: CommandType.Text);
            }
        }

        public void PostPersona(Persona p)
        {
            string consulta = $"Insert into Personas values (@nombre,@apellido,@fechanac,@id_tipo)";
            using(var conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                var parametros = new DynamicParameters();

                parametros.Add("@nombre", p.Nombre);
                parametros.Add("@apellido", p.Apellido);
                parametros.Add("@fechanac", p.FechaNacimiento);
                parametros.Add("@id_tipo", p.idTipo);

                conn.Execute(consulta, parametros, commandType: CommandType.Text);
                //conn.Execute(consulta,commandType: CommandType.Text);
            }
        }

    }
}
