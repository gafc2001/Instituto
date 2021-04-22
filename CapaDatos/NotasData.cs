using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    
    public class NotasData
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        public SqlDataReader ListarCursosAsignados(Profesor profesor)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARCURSOSASIGNADOS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROF", Int32.Parse(profesor.idProfesor));
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                reader = null;
            }

            return reader;
        }
        public SqlDataReader ListarPromedios(int idcurso)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARNOTASPROMEDIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CURSO", idcurso);
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                reader = null;
            }

            return reader;
        }
        public SqlDataReader ListarDetallesCurso(int idalu,int idpromedio)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTARDETALLENOTA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ALU", idalu);
            cmd.Parameters.AddWithValue("@PROM", idpromedio);
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                reader = null;
            }

            return reader;
        }

    }
}
