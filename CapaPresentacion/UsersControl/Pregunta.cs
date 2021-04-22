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
    public partial class Pregunta : UserControl
    {
        PracticasCN objPrac = new PracticasCN();
        private int _id;
        private string _pregunta;
        private float nota;
        public Pregunta(int id, string pregunta)
        {
            this._id = id;
            this._pregunta = pregunta;
            InitializeComponent();
        }
        
        private void Pregunta_Load(object sender, EventArgs e)
        {
            lblpregunta.Text = this._pregunta;
            SqlDataReader reader = objPrac.ListarRespuestas(this._id);
            
            while (reader.Read())
            {
                RadioButton rpta = new RadioButton();
                rpta.Text = reader.GetString(1);
                rpta.Name = "opcion";
                rpta.Tag = reader.GetBoolean(2);
                rpta.MinimumSize = new Size(500, 50);
                Contenedor.Controls.Add(rpta);
            }
        }

        private void Contenedor_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
