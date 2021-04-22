using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocios
{
    public class PracticasCN
    {
        PracticasData obj = new PracticasData();
        public SqlDataReader ListarPracticas(int IdCurso)
        {
            return obj.ListarPracticas(IdCurso);
        }
        public SqlDataReader ListarPreguntas(int IdPractica)
        {
            return obj.ListarPreguntas(IdPractica);
        }
        public SqlDataReader ListarRespuestas(int IdPregunta)
        {
            return obj.ListarRespuestas(IdPregunta);
        }
        public String GuardarNotaPractica(int idpractica, int idalumno, float nota)
        {
            return obj.GuardarNotaPractica(idpractica, idalumno, nota);
        }
        public float PromedioCurso(int alumno, int curso)
        {
            return obj.PromedioCurso(alumno, curso);
        }


    }
}
