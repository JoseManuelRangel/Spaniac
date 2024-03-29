﻿namespace Spaniac.Formularios
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.imgClave = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imgMuestra = new System.Windows.Forms.PictureBox();
            this.lbError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIzquierdo.BackgroundImage")));
            this.panelIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelIzquierdo.Controls.Add(this.logoEmpresa);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 344);
            this.panelIzquierdo.TabIndex = 0;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.logoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("logoEmpresa.Image")));
            this.logoEmpresa.Location = new System.Drawing.Point(12, 21);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(87, 67);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEmpresa.TabIndex = 1;
            this.logoEmpresa.TabStop = false;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbInicio.Location = new System.Drawing.Point(134, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(332, 71);
            this.lbInicio.TabIndex = 1;
            this.lbInicio.Text = "INICIAR SESIÓN";
            this.lbInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbInicio_MouseDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(185, 105);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(346, 32);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgUsuario.Image")));
            this.imgUsuario.Location = new System.Drawing.Point(146, 107);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(30, 30);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 4;
            this.imgUsuario.TabStop = false;
            // 
            // imgClave
            // 
            this.imgClave.Image = ((System.Drawing.Image)(resources.GetObject("imgClave.Image")));
            this.imgClave.Location = new System.Drawing.Point(146, 163);
            this.imgClave.Name = "imgClave";
            this.imgClave.Size = new System.Drawing.Size(30, 30);
            this.imgClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClave.TabIndex = 7;
            this.imgClave.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.Location = new System.Drawing.Point(185, 161);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(349, 31);
            this.txtClave.TabIndex = 6;
            this.txtClave.Text = "Contraseña";
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(146, 240);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(190, 40);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEntrar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(342, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.linkLabel1.Location = new System.Drawing.Point(141, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(279, 28);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste la contraseña?. Haz click aquí";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // imgMuestra
            // 
            this.imgMuestra.Image = ((System.Drawing.Image)(resources.GetObject("imgMuestra.Image")));
            this.imgMuestra.Location = new System.Drawing.Point(557, 163);
            this.imgMuestra.Name = "imgMuestra";
            this.imgMuestra.Size = new System.Drawing.Size(32, 30);
            this.imgMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMuestra.TabIndex = 11;
            this.imgMuestra.TabStop = false;
            this.imgMuestra.Click += new System.EventHandler(this.imgMuestra_Click);
            this.imgMuestra.MouseLeave += new System.EventHandler(this.imgMuestra_MouseLeave);
            this.imgMuestra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMuestra_MouseMove);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.White;
            this.lbError.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(145, 206);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(43, 25);
            this.lbError.TabIndex = 12;
            this.lbError.Text = "Error";
            this.lbError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(146, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(149, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 1);
            this.panel2.TabIndex = 14;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.imgMuestra);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.imgClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InicioSesion_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox imgMuestra;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}