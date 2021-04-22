
namespace CapaPresentacion.UsersControl
{
    partial class Pregunta
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
            this.Contenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.lblpregunta = new System.Windows.Forms.Label();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.lblpregunta);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(40);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Padding = new System.Windows.Forms.Padding(30);
            this.Contenedor.Size = new System.Drawing.Size(699, 406);
            this.Contenedor.TabIndex = 9;
            this.Contenedor.WrapContents = false;
            this.Contenedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contenedor_MouseClick);
            // 
            // lblpregunta
            // 
            this.lblpregunta.AutoSize = true;
            this.lblpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta.Location = new System.Drawing.Point(33, 30);
            this.lblpregunta.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblpregunta.Name = "lblpregunta";
            this.lblpregunta.Size = new System.Drawing.Size(99, 25);
            this.lblpregunta.TabIndex = 7;
            this.lblpregunta.Text = "Pregunta";
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Contenedor);
            this.Name = "Pregunta";
            this.Size = new System.Drawing.Size(699, 406);
            this.Load += new System.EventHandler(this.Pregunta_Load);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Contenedor;
        private System.Windows.Forms.Label lblpregunta;
    }
}
