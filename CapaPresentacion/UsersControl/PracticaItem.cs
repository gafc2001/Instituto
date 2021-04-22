using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UsersControl
{
    public partial class PracticaItem : UserControl
    {
        private int _id;
        private string _practica;
        private int _curso;
        public PracticaItem(int id, string practica,int curso)
        {
            this._id = id;
            this._practica = practica;
            this._curso = curso;
            InitializeComponent();
            Permisos();
        }

        private void Practica_Load(object sender, EventArgs e)
        {
            lblpractica.Text = this._practica;
        }

        private void btnrealizar_Click(object sender, EventArgs e)
        {
            Practica practica = new Practica(this._id,this._curso);
            practica.Show();
        }
        private void Permisos()
        {
            if (Program.Permiso.Equals("Profesor"))
            {
                btnrealizar.Hide();
                btneditar.Show();
                btneliminar.Show();
                
            }else if (Program.Permiso.Equals("Alumno"))
            {
                btnrealizar.Show();
                btneditar.Hide();
                btneliminar.Hide();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
