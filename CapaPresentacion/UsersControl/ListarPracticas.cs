using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;
namespace CapaPresentacion.UsersControl
{
    public partial class ListarPracticas : UserControl
    {
        private int _id;
        private string _profesor;
        private int  _curso;
        PracticasCN objPrac = new PracticasCN();
        public ListarPracticas(int id,string profesor,int curso)
        {
            InitializeComponent();
            this._id = id;
            this._profesor = profesor;
            this._curso = curso;
            Permisos();
        }

        private void ListarPracticas_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = objPrac.ListarPracticas(this._id);
            while (reader.Read())
            {
                lblcurso.Text = reader.GetString(1);
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(2);
                int idcurso = reader.GetInt32(3);
                PracticaItem practica = new PracticaItem(id,nombre,idcurso);
                ContainerPracticas.Controls.Add(practica);
            }
            lblprofesor.Text = this._profesor;
        }
        
        private void Permisos()
        {
            btnagregar.Hide();
            if (Program.Permiso.Equals("Profesor"))
            {
                lblnota.Hide();
                btnagregar.Show();
            }
        }
        public void Promedio()
        {
            lblnota.Text = "Nota : " +  objPrac.PromedioCurso(Program.Id, this._curso).ToString();
        }

    }
}
