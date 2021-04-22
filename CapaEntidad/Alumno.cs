using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaEntidad
{
    public class Alumno : Usuario
    {
        public string idAlumno { get; set; }
        public DateTime fechaNac { get; set; }
        public string observaciones { get; set; }
    }
}
