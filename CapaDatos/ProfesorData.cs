using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaEntidad;

namespace CapaDatos
{
    public class ProfesorData
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        public DataTable ListarProfesor()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARPROFESOR", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string AgregarProfesor(Profesor profesor)
        {
            cn = objCon.getConecta();
            cn.Open();
            
            SqlCommand cmd = new SqlCommand("SP_AGREGARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USU", profesor.usuario);
            cmd.Parameters.AddWithValue("@CON", profesor.clave);
            cmd.Parameters.AddWithValue("@PERMISOS", "Profesor");
            cmd.Parameters.AddWithValue("@NOM", profesor.nombre);
            cmd.Parameters.AddWithValue("@APE", profesor.apellido);
            cmd.Parameters.AddWithValue("@TEL", profesor.telefono);
            cmd.Parameters.AddWithValue("@DIR", profesor.direccion);
            cmd.Parameters.AddWithValue("@EMAIL", profesor.email);
            cmd.Parameters.AddWithValue("@FECHA", SqlString.Null);
            cmd.Parameters.AddWithValue("@OBV", SqlString.Null);
            try
            {
                cmd.ExecuteNonQuery();
                return "Se guardo correctamente";
            }
            catch(SqlException e)
            {
                return "Error: " + e.StackTrace;
            }
        }
        public string EditarProfesor(Profesor profesor)
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", profesor.idProfesor);
            cmd.Parameters.AddWithValue("@CODUSU", profesor.idUSuario);
            cmd.Parameters.AddWithValue("@USU", profesor.usuario);
            cmd.Parameters.AddWithValue("@CON", profesor.clave);
            cmd.Parameters.AddWithValue("@PERMISOS", "Profesor");
            cmd.Parameters.AddWithValue("@NOM", profesor.nombre);
            cmd.Parameters.AddWithValue("@APE", profesor.apellido);
            cmd.Parameters.AddWithValue("@TEL", profesor.telefono);
            cmd.Parameters.AddWithValue("@DIR", profesor.direccion);
            cmd.Parameters.AddWithValue("@EMAIL", profesor.email);
            cmd.Parameters.AddWithValue("@FECHA", SqlString.Null);
            cmd.Parameters.AddWithValue("@OBV", SqlString.Null);
            try
            {
                cmd.ExecuteNonQuery();
                return "Se guardo correctamente";
            }
            catch (SqlException e)
            {
                return "Error: " + e.StackTrace;
            }
        }
        public string EliminarProfesor(Profesor profesor)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", profesor.idProfesor);
            cmd.Parameters.AddWithValue("@CODUSU", profesor.idUSuario);
            cmd.Parameters.AddWithValue("@PER", "Profesor");
            try
            {
                cmd.ExecuteNonQuery();
                return "Se elimno el registro";
            }
            catch (SqlException e)
            {
                return "Error: " + e.StackTrace;
            }
        }
    }
}
