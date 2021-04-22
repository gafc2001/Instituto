
namespace CapaPresentacion
{
    partial class CursosFrm
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(18, 83);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(555, 266);
            this.dgvCursos.TabIndex = 43;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(671, 237);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(151, 20);
            this.txtemail.TabIndex = 39;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(671, 208);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(151, 20);
            this.txtdireccion.TabIndex = 40;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(671, 172);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(151, 20);
            this.txttelefono.TabIndex = 41;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(671, 131);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(151, 20);
            this.txtapellido.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(671, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 33;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(770, 326);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(627, 326);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 32;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // CursosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Name = "CursosFrm";
            this.Size = new System.Drawing.Size(862, 432);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
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
    }
}
