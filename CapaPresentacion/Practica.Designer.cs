
namespace CapaPresentacion
{
    partial class Practica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContenedorPreguntas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnterminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContenedorPreguntas
            // 
            this.ContenedorPreguntas.AutoScroll = true;
            this.ContenedorPreguntas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContenedorPreguntas.Location = new System.Drawing.Point(106, 54);
            this.ContenedorPreguntas.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorPreguntas.Name = "ContenedorPreguntas";
            this.ContenedorPreguntas.Size = new System.Drawing.Size(1038, 520);
            this.ContenedorPreguntas.TabIndex = 0;
            this.ContenedorPreguntas.WrapContents = false;
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(998, 593);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(146, 47);
            this.btnterminar.TabIndex = 1;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // Practica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 749);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.ContenedorPreguntas);
            this.Name = "Practica";
            this.Text = "Practica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContenedorPreguntas;
        private System.Windows.Forms.Button btnterminar;
    }
}