
namespace CapaPresentacion.UsersControl
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.imgcurso = new System.Windows.Forms.PictureBox();
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblprofesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgcurso)).BeginInit();
            this.SuspendLayout();
            // 
            // imgcurso
            // 
            this.imgcurso.Image = ((System.Drawing.Image)(resources.GetObject("imgcurso.Image")));
            this.imgcurso.Location = new System.Drawing.Point(0, 0);
            this.imgcurso.Margin = new System.Windows.Forms.Padding(0);
            this.imgcurso.Name = "imgcurso";
            this.imgcurso.Size = new System.Drawing.Size(308, 159);
            this.imgcurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcurso.TabIndex = 0;
            this.imgcurso.TabStop = false;
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.Location = new System.Drawing.Point(19, 171);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(268, 25);
            this.lblcurso.TabIndex = 1;
            this.lblcurso.Text = "Lenguaje de programación";
            // 
            // lblprofesor
            // 
            this.lblprofesor.AutoSize = true;
            this.lblprofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofesor.Location = new System.Drawing.Point(21, 203);
            this.lblprofesor.Name = "lblprofesor";
            this.lblprofesor.Size = new System.Drawing.Size(136, 16);
            this.lblprofesor.TabIndex = 1;
            this.lblprofesor.Text = "Carlos Mayna Magno";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lblprofesor);
            this.Controls.Add(this.imgcurso);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(25);
            this.Name = "Cursos";
            this.Size = new System.Drawing.Size(306, 226);
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgcurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgcurso;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblprofesor;
    }
}
