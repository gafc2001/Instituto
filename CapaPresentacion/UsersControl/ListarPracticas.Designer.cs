
namespace CapaPresentacion.UsersControl
{
    partial class ListarPracticas
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
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblprofesor = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.ContainerPracticas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Location = new System.Drawing.Point(72, 21);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(34, 13);
            this.lblcurso.TabIndex = 0;
            this.lblcurso.Text = "Curso";
            // 
            // lblprofesor
            // 
            this.lblprofesor.AutoSize = true;
            this.lblprofesor.Location = new System.Drawing.Point(72, 61);
            this.lblprofesor.Name = "lblprofesor";
            this.lblprofesor.Size = new System.Drawing.Size(46, 13);
            this.lblprofesor.TabIndex = 0;
            this.lblprofesor.Text = "Profesor";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Location = new System.Drawing.Point(642, 52);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(30, 13);
            this.lblnota.TabIndex = 0;
            this.lblnota.Text = "Nota";
            // 
            // ContainerPracticas
            // 
            this.ContainerPracticas.AutoScroll = true;
            this.ContainerPracticas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContainerPracticas.Location = new System.Drawing.Point(53, 114);
            this.ContainerPracticas.Name = "ContainerPracticas";
            this.ContainerPracticas.Size = new System.Drawing.Size(637, 396);
            this.ContainerPracticas.TabIndex = 1;
            this.ContainerPracticas.WrapContents = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(730, 169);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(151, 39);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar practica";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // ListarPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.ContainerPracticas);
            this.Controls.Add(this.lblprofesor);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblcurso);
            this.Name = "ListarPracticas";
            this.Size = new System.Drawing.Size(934, 534);
            this.Load += new System.EventHandler(this.ListarPracticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblprofesor;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.FlowLayoutPanel ContainerPracticas;
        private System.Windows.Forms.Button btnagregar;
    }
}
