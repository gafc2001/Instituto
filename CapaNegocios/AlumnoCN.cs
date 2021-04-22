using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;


namespace CapaNegocios
{
    public class AlumnoCN
    {
        AlumnoData obj = new AlumnoData();
        public DataTable ListarAlumno()
        {
            return obj.ListarAlumno();
        }
        public string AgregarAlumno(Alumno alumno)
        {
            return obj.AgregarAlumno(alumno);
        }
        public string EditarAlumno(Alumno alumno)
        {
            return obj.EditarAlumno(alumno);
        }
        public string EliminarAlumno(Alumno alumno)
        {
            return obj.EliminarAlumno(alumno);
        }
    }
}
