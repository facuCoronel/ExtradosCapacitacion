﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDapper.Dominio
{
    internal class TipoEmpleado
    {
        public int idTipo { get; set; }
        public string Tipo { get; set; }


        public override string ToString()
        {
            return $"Tipo: {Tipo}";
        }
    }
}
