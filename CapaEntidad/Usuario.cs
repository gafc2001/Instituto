﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public string idUSuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string permiso { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public string email { get; set; }
    }
}
