namespace Spaniac.Formularios.Internos.Configuración
{
    partial class EditarRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarRoles));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.lbError = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.GroupBox();
            this.cEmp = new System.Windows.Forms.CheckBox();
            this.cAdm = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModRol = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.rol.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 510);
            this.panelIzquierdo.TabIndex = 3;
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
            this.lbInicio.Location = new System.Drawing.Point(138, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(298, 67);
            this.lbInicio.TabIndex = 4;
            this.lbInicio.Text = "EDITAR ROLES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 5;
            // 
            // cbUsers
            // 
            this.cbUsers.BackColor = System.Drawing.Color.White;
            this.cbUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbUsers.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Empleado"});
            this.cbUsers.Location = new System.Drawing.Point(152, 99);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(266, 31);
            this.cbUsers.TabIndex = 43;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(148, 142);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(41, 23);
            this.lbError.TabIndex = 44;
            this.lbError.Text = "Error";
            this.lbError.Visible = false;
            // 
            // rol
            // 
            this.rol.BackColor = System.Drawing.Color.Transparent;
            this.rol.Controls.Add(this.cEmp);
            this.rol.Controls.Add(this.cAdm);
            this.rol.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.rol.Location = new System.Drawing.Point(152, 187);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(266, 100);
            this.rol.TabIndex = 45;
            this.rol.TabStop = false;
            this.rol.Text = "Roles";
            // 
            // cEmp
            // 
            this.cEmp.AutoSize = true;
            this.cEmp.Location = new System.Drawing.Point(20, 53);
            this.cEmp.Name = "cEmp";
            this.cEmp.Size = new System.Drawing.Size(80, 23);
            this.cEmp.TabIndex = 1;
            this.cEmp.Text = "Empleado";
            this.cEmp.UseVisualStyleBackColor = true;
            this.cEmp.CheckedChanged += new System.EventHandler(this.cEmp_CheckedChanged);
            // 
            // cAdm
            // 
            this.cAdm.AutoSize = true;
            this.cAdm.Location = new System.Drawing.Point(20, 30);
            this.cAdm.Name = "cAdm";
            this.cAdm.Size = new System.Drawing.Size(101, 23);
            this.cAdm.TabIndex = 0;
            this.cAdm.Text = "Administrador";
            this.cAdm.UseVisualStyleBackColor = true;
            this.cAdm.CheckedChanged += new System.EventHandler(this.cAdm_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnN);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(152, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 88);
            this.panel1.TabIndex = 46;
            this.panel1.Visible = false;
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Reem Kufi", 8F, System.Drawing.FontStyle.Bold);
            this.btnN.ForeColor = System.Drawing.Color.White;
            this.btnN.Location = new System.Drawing.Point(141, 39);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(109, 27);
            this.btnN.TabIndex = 42;
            this.btnN.Text = "NO";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            this.btnN.MouseLeave += new System.EventHandler(this.btnN_MouseLeave);
            this.btnN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnN_MouseMove);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Reem Kufi", 8F, System.Drawing.FontStyle.Bold);
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Location = new System.Drawing.Point(11, 39);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(109, 27);
            this.btnS.TabIndex = 41;
            this.btnS.Text = "SÍ";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            this.btnS.MouseLeave += new System.EventHandler(this.btnS_MouseLeave);
            this.btnS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnS_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.label2.Location = new System.Drawing.Point(79, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿Estás seguro?";
            // 
            // btnModRol
            // 
            this.btnModRol.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModRol.Enabled = false;
            this.btnModRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModRol.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnModRol.ForeColor = System.Drawing.Color.White;
            this.btnModRol.Location = new System.Drawing.Point(152, 403);
            this.btnModRol.Name = "btnModRol";
            this.btnModRol.Size = new System.Drawing.Size(266, 40);
            this.btnModRol.TabIndex = 47;
            this.btnModRol.Text = "MODIFICAR";
            this.btnModRol.UseVisualStyleBackColor = false;
            this.btnModRol.Click += new System.EventHandler(this.btnModRol_Click);
            this.btnModRol.MouseLeave += new System.EventHandler(this.btnModRol_MouseLeave);
            this.btnModRol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModRol_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(152, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(266, 40);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // EditarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(473, 510);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModRol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarRoles";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditarRoles_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.rol.ResumeLayout(false);
            this.rol.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.GroupBox rol;
        private System.Windows.Forms.CheckBox cEmp;
        private System.Windows.Forms.CheckBox cAdm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnModRol;
        private System.Windows.Forms.Button btnSalir;
    }
}