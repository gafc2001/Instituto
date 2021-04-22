using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class LoginCN
    {
        LoginData obj = new LoginData();
        public SqlDataReader IniciarSesion(Usuario user)
        {
            SqlDataReader reader = obj.IniciarSesion(user);
            return reader;
        }
       

    }
}
