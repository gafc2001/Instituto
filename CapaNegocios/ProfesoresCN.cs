using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
namespace CapaNegocios
{
    public class ProfesoresCN
    {
        ProfesorData obj = new ProfesorData();
        public DataTable ListarProfesor()
        {
            return obj.ListarProfesor();
        }
        public string AgregarProfesor(Profesor profesor)
        {
            return obj.AgregarProfesor(profesor);
        }
        public string EditarProfesor(Profesor profesor)
        {
            return obj.EditarProfesor(profesor);
        }
        public string EliminarProfesor(Profesor profesor)
        {
            return obj.EliminarProfesor(profesor);
        }
    }
}
