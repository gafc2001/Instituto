
namespace CapaPresentacion.UsersControl
{
    partial class PromedioCurso
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
            this.lblpromedio = new System.Windows.Forms.Label();
            this.dgvPromedios = new System.Windows.Forms.DataGridView();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(151, 31);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(310, 31);
            this.lblpromedio.TabIndex = 0;
            this.lblpromedio.Text = "Promedios de los cursos";
            // 
            // dgvPromedios
            // 
            this.dgvPromedios.AllowUserToAddRows = false;
            this.dgvPromedios.AllowUserToDeleteRows = false;
            this.dgvPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedios.Location = new System.Drawing.Point(154, 110);
            this.dgvPromedios.Name = "dgvPromedios";
            this.dgvPromedios.RowHeadersVisible = false;
            this.dgvPromedios.Size = new System.Drawing.Size(814, 245);
            this.dgvPromedios.TabIndex = 1;
            this.dgvPromedios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromedios_CellContentClick);
            // 
            // btnreporte
            // 
            this.btnreporte.Location = new System.Drawing.Point(565, 421);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(175, 32);
            this.btnreporte.TabIndex = 2;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // PromedioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.dgvPromedios);
            this.Controls.Add(this.lblpromedio);
            this.Name = "PromedioCurso";
            this.Size = new System.Drawing.Size(1002, 572);
            this.Load += new System.EventHandler(this.PromedioCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.DataGridView dgvPromedios;
        private System.Windows.Forms.Button btnreporte;
    }
}
