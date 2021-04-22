using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class PracticasData
    {
        Conexion objCon = new Conexion();
        SqlConnection cn;
        public SqlDataReader ListarPracticas(int IdCurso)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARPRACTICAS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CURSO", IdCurso);
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }catch(SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }
        public  SqlDataReader ListarPreguntas(int IdPractica)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARPREGUNTAS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRACTICA", IdPractica);
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }
        public SqlDataReader ListarRespuestas(int IdPregunta)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARRPTA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PREGUNTA", IdPregunta);
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }
        public String GuardarNotaPractica(int idpractica,int idalumno,float nota)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_GUARDARNOTAPRACTICA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRAC", idpractica);
            cmd.Parameters.AddWithValue("@ALUM", idalumno);
            cmd.Parameters.AddWithValue("@NOTA", nota);
            try
            {
                cmd.ExecuteNonQuery();
                return "Se guardo tu puntuación";
            }catch(SqlException e)
            {
                return e.StackTrace;
            }

        }
        
        public float PromedioCurso(int alumno,int curso)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_PROMEDIOCURSO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ALUM", alumno);
            cmd.Parameters.AddWithValue("@CURSO", curso);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) return reader.GetInt32(0);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return 0;
        }
       
    }
}
