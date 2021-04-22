using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion.UsersControl
{
    public partial class PromedioCurso : UserControl
    {
        NotasCN objNotas = new NotasCN();
        private int _idcurso;
        public PromedioCurso(string idcurso)
        {
            Console.WriteLine("id : ",idcurso);
            this._idcurso = Int32.Parse(idcurso);
            InitializeComponent();
        }

        private void PromedioCurso_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(objNotas.ListarPromedios(this._idcurso));
            dgvPromedios.DataSource = dt;
            DataGridViewButtonColumn btndetalles = new DataGridViewButtonColumn();
            btndetalles.Text = "Detalles";
            btndetalles.Name = "Accion";
            btndetalles.UseColumnTextForButtonValue = true;
            dgvPromedios.Columns.Add(btndetalles);
            format();
        }

        private void dgvPromedios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvPromedios.CurrentCell != null && dgvPromedios.CurrentCell.Value != null)
                {
                    string idpromedio = dgvPromedios.CurrentRow.Cells[1].Value.ToString();
                    string idcurso = dgvPromedios.CurrentRow.Cells[2].Value.ToString();
                    string nombre = dgvPromedios.CurrentRow.Cells[4].Value.ToString();
                    if (dgvPromedios.CurrentCell.Value.ToString().Equals("Detalles"))
                    {
                        DetalleNotaCurso promedio = new DetalleNotaCurso(idcurso,idpromedio,nombre);
                        this.Parent.Controls.Add(promedio);
                        this.Hide();

                    }

                }
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            
        }
        private void format()
        {
            dgvPromedios.Columns[0].Width = 80;
            dgvPromedios.Columns[1].Width = 80;
            dgvPromedios.Columns[2].Width = 180;
            dgvPromedios.Columns[3].Width = 180;
            dgvPromedios.Columns[4].Width = 180;
            dgvPromedios.Columns[5].DefaultCellStyle.Padding = new Padding(10, 2, 10, 2);
            dgvPromedios.RowTemplate.Height = 30;
        }
    }
}
