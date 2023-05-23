namespace Spaniac.Formularios.Internos.Configuración
{
    partial class VerPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPerfil));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dniUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.emailUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.claveUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ap2User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ap1User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreUser = new System.Windows.Forms.TextBox();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 620);
            this.panelIzquierdo.TabIndex = 2;
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
            this.lbInicio.Location = new System.Drawing.Point(139, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(161, 67);
            this.lbInicio.TabIndex = 3;
            this.lbInicio.Text = "PERFIL";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbRol);
            this.panel1.Controls.Add(this.dniUser);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.imgUser);
            this.panel1.Controls.Add(this.emailUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.claveUser);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.userUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ap2User);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ap1User);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nombreUser);
            this.panel1.Location = new System.Drawing.Point(151, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 501);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Rol:";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.White;
            this.cbRol.Enabled = false;
            this.cbRol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRol.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Empleado"});
            this.cbRol.Location = new System.Drawing.Point(120, 319);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(278, 31);
            this.cbRol.TabIndex = 42;
            // 
            // dniUser
            // 
            this.dniUser.Enabled = false;
            this.dniUser.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniUser.Location = new System.Drawing.Point(291, 34);
            this.dniUser.Name = "dniUser";
            this.dniUser.Size = new System.Drawing.Size(107, 31);
            this.dniUser.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "DNI:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 16F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(444, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(256, 56);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.White;
            this.imgUser.Location = new System.Drawing.Point(444, 34);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(256, 210);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 14;
            this.imgUser.TabStop = false;
            // 
            // emailUser
            // 
            this.emailUser.Enabled = false;
            this.emailUser.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUser.Location = new System.Drawing.Point(120, 384);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(278, 31);
            this.emailUser.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // claveUser
            // 
            this.claveUser.Enabled = false;
            this.claveUser.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveUser.Location = new System.Drawing.Point(120, 259);
            this.claveUser.Name = "claveUser";
            this.claveUser.Size = new System.Drawing.Size(278, 31);
            this.claveUser.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave:";
            // 
            // userUser
            // 
            this.userUser.Enabled = false;
            this.userUser.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUser.Location = new System.Drawing.Point(120, 205);
            this.userUser.Name = "userUser";
            this.userUser.Size = new System.Drawing.Size(278, 31);
            this.userUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario:";
            // 
            // ap2User
            // 
            this.ap2User.Enabled = false;
            this.ap2User.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap2User.Location = new System.Drawing.Point(120, 149);
            this.ap2User.Name = "ap2User";
            this.ap2User.Size = new System.Drawing.Size(278, 31);
            this.ap2User.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido 2:";
            // 
            // ap1User
            // 
            this.ap1User.Enabled = false;
            this.ap1User.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap1User.Location = new System.Drawing.Point(120, 91);
            this.ap1User.Name = "ap1User";
            this.ap1User.Size = new System.Drawing.Size(278, 31);
            this.ap1User.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // nombreUser
            // 
            this.nombreUser.Enabled = false;
            this.nombreUser.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUser.Location = new System.Drawing.Point(120, 34);
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.Size = new System.Drawing.Size(107, 31);
            this.nombreUser.TabIndex = 0;
            // 
            // VerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarPerfil";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarPerfil_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox emailUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox claveUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ap2User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ap1User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreUser;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox dniUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRol;
    }
}