using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Data.SqlClient;
using CapaNegocios;
using CapaPresentacion.UsersControl;

namespace CapaPresentacion
{
    public partial class Practica : Form
    {
        PracticasCN objPrac = new PracticasCN();
        private int _id;
        private int _curso;
        private int _totalPreguntas;
        private int _puntos;
        private int _calificacion;
        public Practica(int id,int curso)
        {
            InitializeComponent();
            this._id = id;
            this._curso = curso;
            load();
        }
        private void load()
        {
            SqlDataReader reader = objPrac.ListarPreguntas(this._id);
            while (reader.Read())
            {
                this._totalPreguntas++;
                int id = reader.GetInt32(0);
                string pregunta = reader.GetString(1);
                Pregunta ObjPregunta = new Pregunta(id, pregunta);
                
                ContenedorPreguntas.Controls.Add(ObjPregunta);
            }
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            foreach(Pregunta control in ContenedorPreguntas.Controls)
            {
                foreach(FlowLayoutPanel pregunta in control.Controls)
                {
                    var respuesta = pregunta.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if ((bool)respuesta.Tag)
                    {
                        this._puntos++;
                    }
                    
                }
            }
            this._calificacion = this._puntos / this._totalPreguntas;
            this._calificacion = this._calificacion * 20;
            string result = objPrac.GuardarNotaPractica(this._id, Program.Id, this._calificacion);

            MessageBox.Show(result);


            this.Close();
        }
        
       
    }
}
