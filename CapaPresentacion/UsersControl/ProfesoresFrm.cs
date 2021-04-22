using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion.UsersControl
{
    public partial class ProfesorFrm : UserControl
    {
        ProfesoresCN objPro = new ProfesoresCN();
        Profesor entPro = new Profesor();
        
        string accion;
        string idProfesor;
        string idUsuario;
        public ProfesorFrm()
        {
            InitializeComponent();
        }
        public void setData(DataTable data)
        {
            //Boton editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Text = "Editar";
            btnEditar.Name = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

            //Boton eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvProfesores.DataSource = data;
            dgvProfesores.Columns.Add(btnEditar);
            dgvProfesores.Columns.Add(btnEliminar);
            format();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            entPro.idProfesor = idProfesor;
            entPro.idUSuario = idUsuario;
            entPro.usuario = txtusuario.Text;
            entPro.clave = txtclave.Text;
            entPro.nombre = txtnombre.Text;
            entPro.apellido = txtapellido.Text;
            entPro.telefono = txttelefono.Text;
            entPro.direccion = txtdireccion.Text;
            entPro.email = txtemail.Text;
            if (accion.Equals("nuevo"))
            {
                string msg = objPro.AgregarProfesor(entPro);
                MessageBox.Show(msg);
            }
            if (accion.Equals("editar"))
            {
                string msg = objPro.EditarProfesor(entPro);
                MessageBox.Show(msg);
            }
            dgvProfesores.DataSource = objPro.ListarProfesor();
            limpiar();
        }
        

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (e.RowIndex != -1)
            {
                if (dgvProfesores.CurrentCell != null && dgvProfesores.CurrentCell.Value != null)
                {
                    idProfesor = dgvProfesores.CurrentRow.Cells[2].Value.ToString();
                    idUsuario = dgvProfesores.CurrentRow.Cells[3].Value.ToString();
                    if (dgvProfesores.CurrentCell.Value.ToString().Equals("Editar"))
                    {
                        accion = "editar";
                        txtusuario.Text = dgvProfesores.CurrentRow.Cells[4].Value.ToString();
                        txtclave.Text = dgvProfesores.CurrentRow.Cells[5].Value.ToString();
                        txtnombre.Text = dgvProfesores.CurrentRow.Cells[6].Value.ToString();
                        txtapellido.Text = dgvProfesores.CurrentRow.Cells[7].Value.ToString();
                        txttelefono.Text = dgvProfesores.CurrentRow.Cells[8].Value.ToString();
                        txtdireccion.Text = dgvProfesores.CurrentRow.Cells[9].Value.ToString();
                        txtemail.Text = dgvProfesores.CurrentRow.Cells[10].Value.ToString();
                        activarTextBox();
                    }
                    if (dgvProfesores.CurrentCell.Value.ToString().Equals("Eliminar"))
                    {
                        if (MessageBox.Show("Confirmación", "Desea eliminar este registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            entPro.idProfesor = idProfesor;
                            entPro.idUSuario = idUsuario;
                            string msg = objPro.EliminarProfesor(entPro);
                            MessageBox.Show(msg);
                        }
                    }
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            activarTextBox();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void activarTextBox()
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
        }
        private void limpiar()
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txttelefono.Enabled = false;
            txtdireccion.Enabled = false;
            txtemail.Enabled = false;

            txtusuario.Clear();
            txtclave.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
        }
        private void format()
        {
            dgvProfesores.Columns[0].Width = 50;
            dgvProfesores.Columns[1].Width = 50;
            dgvProfesores.Columns[2].Width = 80;
            dgvProfesores.Columns[3].Width = 80;
            dgvProfesores.Columns[4].Width = 80;
            dgvProfesores.Columns[5].Width = 80;
            dgvProfesores.Columns[6].Width = 80;
            dgvProfesores.Columns[7].Width = 120;
            dgvProfesores.Columns[8].Width = 120;
        }
    }
}
