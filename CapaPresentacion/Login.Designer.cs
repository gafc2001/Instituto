
namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnacceder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnacceder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.ForeColor = System.Drawing.Color.White;
            this.btnacceder.Location = new System.Drawing.Point(79, 369);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(129, 41);
            this.btnacceder.TabIndex = 8;
            this.btnacceder.Text = "Ingresar";
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 141);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(48, 226);
            this.txtusuario.MinimumSize = new System.Drawing.Size(200, 20);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(200, 26);
            this.txtusuario.TabIndex = 12;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.White;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(48, 304);
            this.txtclave.MaximumSize = new System.Drawing.Size(250, 100);
            this.txtclave.MinimumSize = new System.Drawing.Size(200, 20);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(200, 26);
            this.txtclave.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(200, 80);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
    }
}