
namespace CapaPresentacion.UsersControl
{
    partial class NotasCursos
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
            this.lblcurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(131, 110);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.Size = new System.Drawing.Size(708, 332);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.Location = new System.Drawing.Point(125, 49);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(234, 33);
            this.lblcurso.TabIndex = 1;
            this.lblcurso.Text = "Curso asignados";
            // 
            // NotasCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.dgvCursos);
            this.Name = "NotasCursos";
            this.Size = new System.Drawing.Size(928, 509);
            this.Load += new System.EventHandler(this.NotasCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblcurso;
    }
}
