﻿namespace WindowsFormsApp1
{
    partial class FrmModuloAviones
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarVuelo = new System.Windows.Forms.Button();
            this.BtnEditarVuelo = new System.Windows.Forms.Button();
            this.BtnAgregarVuelo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aviones";
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(762, 539);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(128, 40);
            this.BtnEliminarVuelo.TabIndex = 21;
            this.BtnEliminarVuelo.Text = "Eliminar";
            this.BtnEliminarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnEditarVuelo
            // 
            this.BtnEditarVuelo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnEditarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarVuelo.Location = new System.Drawing.Point(494, 539);
            this.BtnEditarVuelo.Name = "BtnEditarVuelo";
            this.BtnEditarVuelo.Size = new System.Drawing.Size(128, 40);
            this.BtnEditarVuelo.TabIndex = 20;
            this.BtnEditarVuelo.Text = "Editar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(218, 539);
            this.BtnAgregarVuelo.Name = "BtnAgregarVuelo";
            this.BtnAgregarVuelo.Size = new System.Drawing.Size(128, 40);
            this.BtnAgregarVuelo.TabIndex = 19;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 388);
            this.dataGridView1.TabIndex = 18;
            // 
            // FrmModuloAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloAviones";
            this.Text = "FrmModuloAviones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}