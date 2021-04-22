
namespace CapaPresentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.PanelOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnprofesor = new FontAwesome.Sharp.IconButton();
            this.btnalumno = new FontAwesome.Sharp.IconButton();
            this.btncursos = new FontAwesome.Sharp.IconButton();
            this.btnmatriculas = new FontAwesome.Sharp.IconButton();
            this.btnnotas = new FontAwesome.Sharp.IconButton();
            this.btnpracticas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new FontAwesome.Sharp.IconButton();
            this.lblcolegio = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.table.SuspendLayout();
            this.PanelOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(98, 20);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(79, 24);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.White;
            this.lblcargo.Location = new System.Drawing.Point(98, 48);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(52, 20);
            this.lblcargo.TabIndex = 2;
            this.lblcargo.Text = "Cargo";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(298, 19);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(74, 24);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            // 
            // table
            // 
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.PanelOptions, 0, 1);
            this.table.Controls.Add(this.panel1, 0, 0);
            this.table.Controls.Add(this.MainContainer, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(1235, 570);
            this.table.TabIndex = 3;
            // 
            // PanelOptions
            // 
            this.PanelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.PanelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOptions.Controls.Add(this.btnprofesor);
            this.PanelOptions.Controls.Add(this.btnalumno);
            this.PanelOptions.Controls.Add(this.btncursos);
            this.PanelOptions.Controls.Add(this.btnmatriculas);
            this.PanelOptions.Controls.Add(this.btnnotas);
            this.PanelOptions.Controls.Add(this.btnpracticas);
            this.PanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOptions.Location = new System.Drawing.Point(0, 100);
            this.PanelOptions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelOptions.Name = "PanelOptions";
            this.PanelOptions.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.PanelOptions.Size = new System.Drawing.Size(201, 470);
            this.PanelOptions.TabIndex = 4;
            // 
            // btnprofesor
            // 
            this.btnprofesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnprofesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofesor.FlatAppearance.BorderSize = 0;
            this.btnprofesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofesor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnprofesor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnprofesor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnprofesor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnprofesor.IconSize = 30;
            this.btnprofesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprofesor.Location = new System.Drawing.Point(3, 23);
            this.btnprofesor.Name = "btnprofesor";
            this.btnprofesor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnprofesor.Size = new System.Drawing.Size(194, 44);
            this.btnprofesor.TabIndex = 0;
            this.btnprofesor.Text = "Profesores";
            this.btnprofesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprofesor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprofesor.UseVisualStyleBackColor = false;
            this.btnprofesor.Click += new System.EventHandler(this.btnprofesor_Click);
            // 
            // btnalumno
            // 
            this.btnalumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnalumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalumno.FlatAppearance.BorderSize = 0;
            this.btnalumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnalumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalumno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnalumno.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnalumno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnalumno.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnalumno.IconSize = 30;
            this.btnalumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalumno.Location = new System.Drawing.Point(3, 73);
            this.btnalumno.Name = "btnalumno";
            this.btnalumno.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnalumno.Size = new System.Drawing.Size(194, 44);
            this.btnalumno.TabIndex = 0;
            this.btnalumno.Text = "Alumnos";
            this.btnalumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnalumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalumno.UseVisualStyleBackColor = false;
            this.btnalumno.Click += new System.EventHandler(this.btnalumno_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btncursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncursos.FlatAppearance.BorderSize = 0;
            this.btncursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btncursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncursos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btncursos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btncursos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btncursos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncursos.IconSize = 30;
            this.btncursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.Location = new System.Drawing.Point(3, 123);
            this.btncursos.Name = "btncursos";
            this.btncursos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btncursos.Size = new System.Drawing.Size(194, 44);
            this.btncursos.TabIndex = 0;
            this.btncursos.Text = "Mis cursos";
            this.btncursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // btnmatriculas
            // 
            this.btnmatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnmatriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmatriculas.FlatAppearance.BorderSize = 0;
            this.btnmatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnmatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatriculas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatriculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnmatriculas.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnmatriculas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnmatriculas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnmatriculas.IconSize = 30;
            this.btnmatriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmatriculas.Location = new System.Drawing.Point(3, 173);
            this.btnmatriculas.Name = "btnmatriculas";
            this.btnmatriculas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnmatriculas.Size = new System.Drawing.Size(194, 44);
            this.btnmatriculas.TabIndex = 0;
            this.btnmatriculas.Text = "Matriculas";
            this.btnmatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmatriculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmatriculas.UseVisualStyleBackColor = false;
            // 
            // btnnotas
            // 
            this.btnnotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnnotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnotas.FlatAppearance.BorderSize = 0;
            this.btnnotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnnotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnnotas.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnnotas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnnotas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnnotas.IconSize = 30;
            this.btnnotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotas.Location = new System.Drawing.Point(3, 223);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnnotas.Size = new System.Drawing.Size(194, 44);
            this.btnnotas.TabIndex = 0;
            this.btnnotas.Text = "Notas";
            this.btnnotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnotas.UseVisualStyleBackColor = false;
            this.btnnotas.Click += new System.EventHandler(this.btnnotas_Click);
            // 
            // btnpracticas
            // 
            this.btnpracticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnpracticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpracticas.FlatAppearance.BorderSize = 0;
            this.btnpracticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnpracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpracticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpracticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnpracticas.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnpracticas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.btnpracticas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnpracticas.IconSize = 30;
            this.btnpracticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpracticas.Location = new System.Drawing.Point(3, 273);
            this.btnpracticas.Name = "btnpracticas";
            this.btnpracticas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnpracticas.Size = new System.Drawing.Size(194, 44);
            this.btnpracticas.TabIndex = 0;
            this.btnpracticas.Text = "Practicas";
            this.btnpracticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpracticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpracticas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.table.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblcolegio);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnexit.IconColor = System.Drawing.Color.White;
            this.btnexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexit.IconSize = 35;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.Location = new System.Drawing.Point(481, 20);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 51);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Cerrar sesión";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblcolegio
            // 
            this.lblcolegio.AutoSize = true;
            this.lblcolegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolegio.ForeColor = System.Drawing.Color.White;
            this.lblcolegio.Location = new System.Drawing.Point(130, 44);
            this.lblcolegio.Name = "lblcolegio";
            this.lblcolegio.Size = new System.Drawing.Size(280, 24);
            this.lblcolegio.TabIndex = 4;
            this.lblcolegio.Text = "I.E. Carlos Morales de Chimbote";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnexit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblnombre);
            this.panel4.Controls.Add(this.lblcargo);
            this.panel4.Controls.Add(this.lblusuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(606, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 100);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainContainer
            // 
            this.MainContainer.AutoScroll = true;
            this.MainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(204, 103);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1028, 464);
            this.MainContainer.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.table);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 570);
            this.panel3.TabIndex = 7;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 570);
            this.Controls.Add(this.panel3);
            this.Name = "Principal";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.table.ResumeLayout(false);
            this.PanelOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.FlowLayoutPanel PanelOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnprofesor;
        private FontAwesome.Sharp.IconButton btnalumno;
        private FontAwesome.Sharp.IconButton btncursos;
        private FontAwesome.Sharp.IconButton btnmatriculas;
        private FontAwesome.Sharp.IconButton btnnotas;
        private FontAwesome.Sharp.IconButton btnpracticas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MainContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblcolegio;
        private FontAwesome.Sharp.IconButton btnexit;
    }
}