using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnacceder_Click(object sender, EventArgs e)
        {
            LoginCN objLogin = new LoginCN();
            SqlDataReader Loguear;
            Usuario user = new Usuario();
            user.usuario = txtusuario.Text;
            user.clave = txtclave.Text;
            Loguear = objLogin.IniciarSesion(user);
            
            if (Loguear.Read() == true)
            {
                Program.IdUsuario = Int32.Parse(Loguear["id_usuario"].ToString());

                
                Program.Permiso = Loguear["permisos"].ToString();
                if(Program.Permiso.Equals("Profesor"))
                    Program.Id = Int32.Parse(Loguear["id_profesor"].ToString());
                else if(Program.Permiso.Equals("Alumno"))
                    Program.Id = Int32.Parse(Loguear["id_alumno"].ToString());
                
                Program.Usuario = Loguear["usuario"].ToString();
                Program.Nombre = String.Concat(Loguear["nombre"],' ', Loguear["apellido"]); 
                        
                this.Hide();
                Principal form = new Principal();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }
        private void permisos(SqlDataReader reader) 
        {
            if(reader["permisos"].Equals("Administrador"))
            {

            }
            else if (reader["permisos"].Equals("Profesor"))
            {

            }
            else if(reader["permisos"].Equals("Alumno"))
            {
                
            }
        }
    }
}
