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
    public class CursosData
    {
        SqlConnection cn = new SqlConnection();
        Conexion objCon = new Conexion();
        SqlDataReader reader;
        public SqlDataReader ListarCursos()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_LISTARCURSOS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = cmd.ExecuteReader();
            }catch(SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return reader;
        }
    }
}
