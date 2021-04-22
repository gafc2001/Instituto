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
    public class AlumnoData
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        public DataTable ListarAlumno()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARALUMNOS", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string AgregarAlumno(Alumno alumno)
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlCommand cmd = new SqlCommand("SP_AGREGARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USU", alumno.usuario);
            cmd.Parameters.AddWithValue("@CON", alumno.clave);
            cmd.Parameters.AddWithValue("@PERMISOS", "Alumno");
            cmd.Parameters.AddWithValue("@NOM", alumno.nombre);
            cmd.Parameters.AddWithValue("@APE", alumno.apellido);
            cmd.Parameters.AddWithValue("@TEL", alumno.telefono);
            cmd.Parameters.AddWithValue("@DIR", alumno.direccion);
            cmd.Parameters.AddWithValue("@EMAIL", alumno.email);
            cmd.Parameters.AddWithValue("@FECHA", alumno.fechaNac);
            cmd.Parameters.AddWithValue("@OBV", alumno.observaciones);
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
        public string EditarAlumno(Alumno alumno)
        {
            cn = objCon.getConecta();
            cn.Open();
            /*string sql = "UPDATE Usuarios SET usuario = @USU, contrasena = @CON, nombre = @NOM, apellido = @APE,   telefono = @TEL,  direccion = @DIR,"+
            "email = @EMAIL  WHERE id_usuario = @CODUSU";*/
            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", alumno.idAlumno);
            cmd.Parameters.AddWithValue("@CODUSU", alumno.idUSuario);
            cmd.Parameters.AddWithValue("@USU", alumno.usuario);
            cmd.Parameters.AddWithValue("@CON", alumno.clave);
            cmd.Parameters.AddWithValue("@PERMISOS", "Alumno");
            cmd.Parameters.AddWithValue("@NOM", alumno.nombre);
            cmd.Parameters.AddWithValue("@APE", alumno.apellido);
            cmd.Parameters.AddWithValue("@TEL", alumno.telefono);
            cmd.Parameters.AddWithValue("@DIR", alumno.direccion);
            cmd.Parameters.AddWithValue("@EMAIL", alumno.email);
            cmd.Parameters.AddWithValue("@FECHA", alumno.fechaNac);
            cmd.Parameters.AddWithValue("@OBV", alumno.observaciones);
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
        public string EliminarAlumno(Alumno alumno)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", alumno.idAlumno);
            cmd.Parameters.AddWithValue("@CODUSU", alumno.idUSuario);
            cmd.Parameters.AddWithValue("@PER", "Alumno");
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
