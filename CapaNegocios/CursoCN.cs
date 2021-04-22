using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocios
{
    public class CursoCN
    {
        CursosData obj = new CursosData();
        public SqlDataReader ListarCursos()
        {
            return obj.ListarCursos();
        }
    }
}
