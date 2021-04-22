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
    public class LoginData
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        private SqlDataReader value;
        public SqlDataReader IniciarSesion(Usuario usuario)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_INICIARSESION", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USU", usuario.usuario);
            cmd.Parameters.AddWithValue("@CON", usuario.clave);
            value = cmd.ExecuteReader();
            return value;
        }
        
        
    }
}
