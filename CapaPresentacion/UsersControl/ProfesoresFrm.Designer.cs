
namespace CapaPresentacion.UsersControl
{
    partial class ProfesorFrm
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
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(19, 261);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.RowHeadersVisible = false;
            this.dgvProfesores.Size = new System.Drawing.Size(943, 349);
            this.dgvProfesores.TabIndex = 30;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(379, 124);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(151, 20);
            this.txtemail.TabIndex = 26;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(129, 164);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(399, 20);
            this.txtdireccion.TabIndex = 27;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(131, 124);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(151, 20);
            this.txttelefono.TabIndex = 28;
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(379, 80);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(151, 20);
            this.txtapellido.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(131, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 20;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(275, 198);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(121, 39);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(90, 198);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(124, 39);
            this.btnguardar.TabIndex = 19;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(802, 218);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(160, 37);
            this.btnagregar.TabIndex = 31;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.Location = new System.Drawing.Point(379, 28);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(151, 20);
            this.txtclave.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(131, 28);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(151, 20);
            this.txtusuario.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Usuario";
            // 
            // ProfesorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
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
            this.Name = "ProfesorFrm";
            this.Size = new System.Drawing.Size(1150, 648);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label7;
    }
}
