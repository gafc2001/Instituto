using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;
using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.UsersControl;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        ProfesoresCN objPro = new ProfesoresCN();
        AlumnoCN objAlu = new AlumnoCN();
        CursoCN objCur = new CursoCN();
        public Principal()
        {
            InitializeComponent();
            //profesorform.setData(objPro.ListarProfesor());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Program.Usuario;
            lblcargo.Text = Program.Permiso;
            lblnombre.Text = Program.Nombre;
            Permisos();
        }
        
        
        private void btncursos_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            SqlDataReader reader = objCur.ListarCursos();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string profesor = reader.GetString(1);
                string curso = reader.GetString(2);
                string imagen = reader.GetString(3);
                Cursos cursos = new Cursos(id, curso, profesor, imagen);
                cursos.Click += curso_Click;
                MainContainer.Controls.Add(cursos);
            }
            MainContainer.Padding = new Padding(40, 20, 40, 0);
        }
        private void Permisos()
        {
            if (Program.Permiso.Equals("Administrador"))
            {
                btncursos.Hide();
                btnpracticas.Hide();
                btnmatriculas.Hide();
                btnnotas.Hide();
            }else if (Program.Permiso.Equals("Profesor"))
            {
                btnprofesor.Hide();
                btncursos.Hide();
                btncursos.Text = "Cursos";
                btnmatriculas.Hide();
                btnpracticas.Hide();
                
            }else if (Program.Permiso.Equals("Alumno"))
            {
                btnprofesor.Hide();
                btnalumno.Hide();
                btnmatriculas.Hide();
                btnnotas.Hide();
                btnpracticas.Hide();
            }
        }
        private void curso_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            Cursos curso = (Cursos)sender;
            ListarPracticas practicas = new ListarPracticas(curso.Id,curso.Profesor,curso.Id);
            MainContainer.Controls.Add(practicas);
        }

        private void btnprofesor_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ProfesorFrm profesorFrm = new ProfesorFrm();
            profesorFrm.setData(objPro.ListarProfesor());
            MainContainer.Controls.Add(profesorFrm);
        }

        private void btnalumno_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            AlumnosFrm alumnosFrm = new AlumnosFrm();
            alumnosFrm.setData(objAlu.ListarAlumno());
            MainContainer.Controls.Add(alumnosFrm);
        }

        private void btnnotas_Click(object sender, EventArgs e)
        {
            NotasCursos notas = new NotasCursos();
            table.Controls.Add(notas, 1, 1);
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(notas);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }
    }
}
