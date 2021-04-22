using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class NotasCN
    {
        NotasData objNota = new NotasData();

        public SqlDataReader ListarCursosAsignados(Profesor profesor)
        {
            return objNota.ListarCursosAsignados(profesor);
        }
        public SqlDataReader ListarPromedios(int idcurso)
        {
            return objNota.ListarPromedios(idcurso);
        }
        public SqlDataReader ListarDetallesCurso(int idalu, int idpromedio)
        {
            return objNota.ListarDetallesCurso(idalu, idpromedio);
        }
    }
}
