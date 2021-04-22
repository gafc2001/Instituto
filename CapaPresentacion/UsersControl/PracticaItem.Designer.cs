
namespace CapaPresentacion.UsersControl
{
    partial class PracticaItem
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
            this.btnrealizar = new System.Windows.Forms.Button();
            this.lblpractica = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnrealizar
            // 
            this.btnrealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizar.Location = new System.Drawing.Point(357, 25);
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.Size = new System.Drawing.Size(155, 40);
            this.btnrealizar.TabIndex = 3;
            this.btnrealizar.Text = "Realizar";
            this.btnrealizar.UseVisualStyleBackColor = true;
            this.btnrealizar.Click += new System.EventHandler(this.btnrealizar_Click);
            // 
            // lblpractica
            // 
            this.lblpractica.AutoSize = true;
            this.lblpractica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpractica.Location = new System.Drawing.Point(27, 27);
            this.lblpractica.Name = "lblpractica";
            this.lblpractica.Size = new System.Drawing.Size(218, 29);
            this.lblpractica.TabIndex = 2;
            this.lblpractica.Text = "Practica calificada I";
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(311, 25);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(155, 40);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 28;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.Location = new System.Drawing.Point(493, 25);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(48, 40);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // PracticaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.lblpractica);
            this.Name = "PracticaItem";
            this.Size = new System.Drawing.Size(561, 87);
            this.Load += new System.EventHandler(this.Practica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrealizar;
        private System.Windows.Forms.Label lblpractica;
        private System.Windows.Forms.Button btneditar;
        private FontAwesome.Sharp.IconButton btneliminar;
    }
}
