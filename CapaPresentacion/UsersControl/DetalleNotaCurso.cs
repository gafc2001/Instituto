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

namespace CapaPresentacion.UsersControl
{
    public partial class DetalleNotaCurso : UserControl
    {
        private int _idalu;
        private string _nombrealu;
        private int _prom;
        NotasCN objNotas = new NotasCN();
        public DetalleNotaCurso(string idalu,string prom,string nombrealu)
        {
            this._nombrealu = nombrealu;
            this._idalu = Int32.Parse(idalu);
            this._prom = Int32.Parse(prom);
            InitializeComponent();
        }
        private void DetalleNotaCurso_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(objNotas.ListarDetallesCurso(this._idalu, this._prom));
            dgvDetalles.DataSource = dt;
            lblalumno.Text = "Alumno" + this._nombrealu;
            format();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvDetalles.CurrentCell != null && dgvDetalles.CurrentCell.Value != null)
                {
                    string idcurso = dgvDetalles.CurrentRow.Cells[2].Value.ToString();
                    string idpromedio = dgvDetalles.CurrentRow.Cells[1].Value.ToString();
                    if (dgvDetalles.CurrentCell.Value.ToString().Equals("Detalles"))
                    {
                        

                    }

                }
            }
        }
        private void format()
        {
            dgvDetalles.Columns[0].Width = 100;
            dgvDetalles.Columns[1].Width = 200;
            dgvDetalles.Columns[2].Width = 200;
            dgvDetalles.Columns[2].DefaultCellStyle.Padding = new Padding(10, 2, 10, 2);
            dgvDetalles.RowTemplate.Height = 30;
        }

        
    }
}
