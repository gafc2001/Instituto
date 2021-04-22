
namespace CapaPresentacion
{
    partial class AlumnosFrm
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(706, 228);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(160, 37);
            this.btnagregar.TabIndex = 49;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(59, 271);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(943, 349);
            this.dgvUsuarios.TabIndex = 48;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(404, 120);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(151, 20);
            this.txtemail.TabIndex = 44;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(156, 156);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(399, 20);
            this.txtdireccion.TabIndex = 45;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(156, 120);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(151, 20);
            this.txttelefono.TabIndex = 46;
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(404, 73);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(151, 20);
            this.txtapellido.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nombre";
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(156, 24);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(151, 20);
            this.txtusuario.TabIndex = 36;
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.Location = new System.Drawing.Point(404, 24);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(151, 20);
            this.txtclave.TabIndex = 35;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(156, 73);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 34;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(289, 228);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 37);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(130, 228);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(135, 37);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Fecha Nac.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Observaciones";
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Enabled = false;
            this.txtobservaciones.Location = new System.Drawing.Point(734, 20);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(211, 137);
            this.txtobservaciones.TabIndex = 44;
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(156, 189);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(208, 20);
            this.fechaNac.TabIndex = 50;
            // 
            // AlumnosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Name = "AlumnosFrm";
            this.Size = new System.Drawing.Size(1098, 628);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.DateTimePicker fechaNac;
    }
}
