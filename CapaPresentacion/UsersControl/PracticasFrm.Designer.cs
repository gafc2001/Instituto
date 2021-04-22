
namespace CapaPresentacion
{
    partial class PracticasFrm
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
            this.lblpractica = new System.Windows.Forms.Label();
            this.dgvPractica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpractica
            // 
            this.lblpractica.AutoSize = true;
            this.lblpractica.Location = new System.Drawing.Point(51, 28);
            this.lblpractica.Name = "lblpractica";
            this.lblpractica.Size = new System.Drawing.Size(46, 13);
            this.lblpractica.TabIndex = 0;
            this.lblpractica.Text = "Practica";
            // 
            // dgvPractica
            // 
            this.dgvPractica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPractica.Location = new System.Drawing.Point(29, 91);
            this.dgvPractica.Name = "dgvPractica";
            this.dgvPractica.Size = new System.Drawing.Size(240, 150);
            this.dgvPractica.TabIndex = 2;
            // 
            // PracticasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPractica);
            this.Controls.Add(this.lblpractica);
            this.Name = "PracticasFrm";
            this.Size = new System.Drawing.Size(604, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpractica;
        private System.Windows.Forms.DataGridView dgvPractica;
    }
}
