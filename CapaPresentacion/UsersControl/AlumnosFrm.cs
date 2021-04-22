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

namespace CapaPresentacion
{
    public partial class AlumnosFrm : UserControl
    {
        AlumnoCN objAlu = new AlumnoCN();
        Alumno entAlu = new Alumno();

        string accion;
        string idAlumno;
        string idUsuario;
        public AlumnosFrm()
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
            dgvUsuarios.DataSource = data;
            dgvUsuarios.Columns.Add(btnEditar);
            dgvUsuarios.Columns.Add(btnEliminar);
            format();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            entAlu.idAlumno = idAlumno;
            entAlu.idUSuario = idUsuario;
            entAlu.usuario = txtusuario.Text;
            entAlu.clave = txtclave.Text;
            entAlu.nombre = txtnombre.Text;
            entAlu.apellido = txtapellido.Text;
            entAlu.telefono = txttelefono.Text;
            entAlu.direccion = txtdireccion.Text;
            entAlu.email = txtemail.Text;
            entAlu.fechaNac = fechaNac.Value;
            entAlu.observaciones = txtobservaciones.Text;
            if (accion.Equals("nuevo"))
            {
                string msg = objAlu.AgregarAlumno(entAlu);
                MessageBox.Show(msg);
            }
            if (accion.Equals("editar"))
            {
                string msg = objAlu.EditarAlumno(entAlu);
                MessageBox.Show(msg);
            }
            setData(objAlu.ListarAlumno());
            limpiar();
        }


        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                if (dgvUsuarios.CurrentCell != null && dgvUsuarios.CurrentCell.Value != null)
                {
                    idAlumno = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    idUsuario = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                    if (dgvUsuarios.CurrentCell.Value.ToString().Equals("Editar"))
                    {
                        accion = "editar";
                        txtusuario.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                        txtclave.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                        txtnombre.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                        txtapellido.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
                        txttelefono.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
                        txtdireccion.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
                        txtemail.Text = dgvUsuarios.CurrentRow.Cells[10].Value.ToString();
                        fechaNac.Text = dgvUsuarios.CurrentRow.Cells[11].Value.ToString();
                        txtobservaciones.Text = dgvUsuarios.CurrentRow.Cells[12].Value.ToString();
                        activarTextBox();
                    }
                    if (dgvUsuarios.CurrentCell.Value.ToString().Equals("Eliminar"))
                    {
                        if (MessageBox.Show("Confirmación", "Desea eliminar este registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            entAlu.idAlumno = idAlumno;
                            entAlu.idUSuario = idUsuario;
                            string msg = objAlu.EliminarAlumno(entAlu);
                            MessageBox.Show(msg);
                        }
                    }
                }
            }
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
            fechaNac.Enabled = true;
            txtobservaciones.Enabled = true;
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
            fechaNac.Enabled = false;
            txtobservaciones.Enabled = false;

            txtusuario.Clear();
            txtclave.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            fechaNac.Text = null;
            txtobservaciones.Clear();
        }
        private void format()
        {
            dgvUsuarios.Columns[0].Width = 50;
            dgvUsuarios.Columns[1].Width = 50;
            dgvUsuarios.Columns[2].Width = 80;
            dgvUsuarios.Columns[3].Width = 80;
            dgvUsuarios.Columns[4].Width = 80;
            dgvUsuarios.Columns[5].Width = 80;
            dgvUsuarios.Columns[6].Width = 80;
            dgvUsuarios.Columns[7].Width = 120;
            dgvUsuarios.Columns[8].Width = 120;
            dgvUsuarios.Columns[9].Width = 80;
            dgvUsuarios.Columns[10].Width = 120;
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            accion = "nuevo";
            activarTextBox();
        }
    }
}
