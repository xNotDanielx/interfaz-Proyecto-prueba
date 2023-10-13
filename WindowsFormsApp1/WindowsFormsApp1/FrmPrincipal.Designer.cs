namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnTitulo = new System.Windows.Forms.Panel();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.PnContenedorMenu = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnAviones = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAeropuertos = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVuelos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.PnTitulo.SuspendLayout();
            this.PnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PnContenedorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnTitulo
            // 
            this.PnTitulo.BackColor = System.Drawing.Color.Gold;
            this.PnTitulo.Controls.Add(this.BtnCerrrar);
            this.PnTitulo.Controls.Add(this.BtnMinimizar);
            this.PnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnTitulo.Name = "PnTitulo";
            this.PnTitulo.Size = new System.Drawing.Size(1300, 35);
            this.PnTitulo.TabIndex = 0;
            this.PnTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTitulo_MouseDown);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCerrrar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.window_close_icon_135015;
            this.BtnCerrrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrrar.Location = new System.Drawing.Point(1263, 3);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Size = new System.Drawing.Size(34, 21);
            this.BtnCerrrar.TabIndex = 18;
            this.BtnCerrrar.UseVisualStyleBackColor = false;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnMinimizar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.window_minimize_icon_138009;
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMinimizar.Location = new System.Drawing.Point(1223, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(34, 21);
            this.BtnMinimizar.TabIndex = 17;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.Gold;
            this.PnMenu.Controls.Add(this.label2);
            this.PnMenu.Controls.Add(this.pictureBox3);
            this.PnMenu.Controls.Add(this.LblNombreUsuario);
            this.PnMenu.Controls.Add(this.PnContenedorMenu);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 35);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(200, 615);
            this.PnMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "¡Bienvenido!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(35, 162);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(126, 16);
            this.LblNombreUsuario.TabIndex = 19;
            this.LblNombreUsuario.Text = "Nombre de usuario";
            // 
            // PnContenedorMenu
            // 
            this.PnContenedorMenu.BackColor = System.Drawing.Color.LightCoral;
            this.PnContenedorMenu.Controls.Add(this.pictureBox7);
            this.PnContenedorMenu.Controls.Add(this.panel6);
            this.PnContenedorMenu.Controls.Add(this.BtnAviones);
            this.PnContenedorMenu.Controls.Add(this.pictureBox6);
            this.PnContenedorMenu.Controls.Add(this.panel5);
            this.PnContenedorMenu.Controls.Add(this.BtnAeropuertos);
            this.PnContenedorMenu.Controls.Add(this.pictureBox5);
            this.PnContenedorMenu.Controls.Add(this.pictureBox4);
            this.PnContenedorMenu.Controls.Add(this.pictureBox2);
            this.PnContenedorMenu.Controls.Add(this.pictureBox1);
            this.PnContenedorMenu.Controls.Add(this.panel4);
            this.PnContenedorMenu.Controls.Add(this.panel2);
            this.PnContenedorMenu.Controls.Add(this.BtnHistorial);
            this.PnContenedorMenu.Controls.Add(this.panel1);
            this.PnContenedorMenu.Controls.Add(this.BtnVuelos);
            this.PnContenedorMenu.Controls.Add(this.BtnClientes);
            this.PnContenedorMenu.Controls.Add(this.panel3);
            this.PnContenedorMenu.Controls.Add(this.BtnEstadisticas);
            this.PnContenedorMenu.Location = new System.Drawing.Point(0, 181);
            this.PnContenedorMenu.Name = "PnContenedorMenu";
            this.PnContenedorMenu.Size = new System.Drawing.Size(200, 370);
            this.PnContenedorMenu.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.vueloPng1;
            this.pictureBox7.Location = new System.Drawing.Point(12, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SkyBlue;
            this.panel6.Location = new System.Drawing.Point(0, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 44);
            this.panel6.TabIndex = 20;
            // 
            // BtnAviones
            // 
            this.BtnAviones.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAviones.FlatAppearance.BorderSize = 0;
            this.BtnAviones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAviones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAviones.Location = new System.Drawing.Point(0, 128);
            this.BtnAviones.Name = "BtnAviones";
            this.BtnAviones.Size = new System.Drawing.Size(197, 44);
            this.BtnAviones.TabIndex = 19;
            this.BtnAviones.Text = "Aviones";
            this.BtnAviones.UseVisualStyleBackColor = false;
            this.BtnAviones.Click += new System.EventHandler(this.BtnAviones_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.AeropertoPng;
            this.pictureBox6.Location = new System.Drawing.Point(12, 78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 44);
            this.panel5.TabIndex = 17;
            // 
            // BtnAeropuertos
            // 
            this.BtnAeropuertos.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAeropuertos.FlatAppearance.BorderSize = 0;
            this.BtnAeropuertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnAeropuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAeropuertos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAeropuertos.Location = new System.Drawing.Point(0, 78);
            this.BtnAeropuertos.Name = "BtnAeropuertos";
            this.BtnAeropuertos.Size = new System.Drawing.Size(197, 44);
            this.BtnAeropuertos.TabIndex = 16;
            this.BtnAeropuertos.Text = "Aeropuertos";
            this.BtnAeropuertos.UseVisualStyleBackColor = false;
            this.BtnAeropuertos.Click += new System.EventHandler(this.BtnAeropuertos_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.EstadisticasPng;
            this.pictureBox5.Location = new System.Drawing.Point(9, 278);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.ClientesPn;
            this.pictureBox4.Location = new System.Drawing.Point(9, 228);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.HistoriaVuelosPng;
            this.pictureBox2.Location = new System.Drawing.Point(9, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Location = new System.Drawing.Point(-3, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 44);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(-3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 44);
            this.panel2.TabIndex = 10;
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.BackColor = System.Drawing.Color.LightCoral;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnHistorial.Location = new System.Drawing.Point(-3, 178);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(197, 44);
            this.BtnHistorial.TabIndex = 11;
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.UseVisualStyleBackColor = false;
            this.BtnHistorial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnHistorial_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(-3, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 44);
            this.panel1.TabIndex = 0;
            // 
            // BtnVuelos
            // 
            this.BtnVuelos.BackColor = System.Drawing.Color.LightCoral;
            this.BtnVuelos.FlatAppearance.BorderSize = 0;
            this.BtnVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVuelos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnVuelos.Location = new System.Drawing.Point(12, 28);
            this.BtnVuelos.Name = "BtnVuelos";
            this.BtnVuelos.Size = new System.Drawing.Size(185, 44);
            this.BtnVuelos.TabIndex = 12;
            this.BtnVuelos.Text = "Vuelos";
            this.BtnVuelos.UseVisualStyleBackColor = false;
            this.BtnVuelos.Click += new System.EventHandler(this.BtnVuelos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.LightCoral;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnClientes.Location = new System.Drawing.Point(-3, 228);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(197, 44);
            this.BtnClientes.TabIndex = 9;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 44);
            this.panel3.TabIndex = 11;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnEstadisticas.Location = new System.Drawing.Point(-3, 278);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(197, 44);
            this.BtnEstadisticas.TabIndex = 8;
            this.BtnEstadisticas.Text = "Estadísticas";
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPrincipal.Location = new System.Drawing.Point(200, 35);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(1100, 615);
            this.PnPrincipal.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.PnMenu);
            this.Controls.Add(this.PnTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.PnTitulo.ResumeLayout(false);
            this.PnMenu.ResumeLayout(false);
            this.PnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PnContenedorMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnTitulo;
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnVuelos;
        private System.Windows.Forms.Button BtnHistorial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Panel PnContenedorMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAeropuertos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnAviones;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}