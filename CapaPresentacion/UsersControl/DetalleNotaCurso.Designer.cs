
namespace CapaPresentacion.UsersControl
{
    partial class DetalleNotaCurso
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
            this.lblalumno = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblalumno
            // 
            this.lblalumno.AutoSize = true;
            this.lblalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalumno.Location = new System.Drawing.Point(214, 32);
            this.lblalumno.Name = "lblalumno";
            this.lblalumno.Size = new System.Drawing.Size(137, 25);
            this.lblalumno.TabIndex = 0;
            this.lblalumno.Text = "Alumno Juan";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(219, 93);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.Size = new System.Drawing.Size(513, 355);
            this.dgvDetalles.TabIndex = 1;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // DetalleNotaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblalumno);
            this.Name = "DetalleNotaCurso";
            this.Size = new System.Drawing.Size(1066, 535);
            this.Load += new System.EventHandler(this.DetalleNotaCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalumno;
        private System.Windows.Forms.DataGridView dgvDetalles;
    }
}
