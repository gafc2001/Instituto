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
using CapaEntidad;

namespace CapaPresentacion.UsersControl
{
    public partial class NotasCursos : UserControl
    {
        NotasCN objNota = new NotasCN();
        Profesor profesor = new Profesor();
        public NotasCursos()
        {
            InitializeComponent();
            
        }

        private void NotasCursos_Load(object sender, EventArgs e)
        {
            profesor.idProfesor = Program.Id.ToString();
            Console.WriteLine(profesor.idProfesor);
            SqlDataReader reader = objNota.ListarCursosAsignados(profesor);
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvCursos.DataSource = dt;
            DataGridViewButtonColumn btninformacion = new DataGridViewButtonColumn();
            btninformacion.Text = "Ver curso";
            btninformacion.Name = "Accion";
            btninformacion.UseColumnTextForButtonValue = true;
            dgvCursos.Columns.Add(btninformacion);
            format();
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvCursos.CurrentCell != null && dgvCursos.CurrentCell.Value != null)
                {
                    string idcurso = dgvCursos.CurrentRow.Cells[1].Value.ToString();
                    if (dgvCursos.CurrentCell.Value.ToString().Equals("Ver curso"))
                    {
                        PromedioCurso promedio = new PromedioCurso(idcurso);
                        this.Parent.Controls.Add(promedio);
                        this.Hide();
                    }
                    
                }
            }
        }
        private void format()
        {
            dgvCursos.Columns[1].Width = 250;
            dgvCursos.Columns[2].Width = 200;
            dgvCursos.Columns[3].Width = 150;
            dgvCursos.Columns[3].DefaultCellStyle.Padding = new Padding(10,2,10,2);
            dgvCursos.RowTemplate.Height = 30;
        }
    }
}
