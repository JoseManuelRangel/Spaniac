namespace Spaniac.Formularios.Externos
{
    partial class FormRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperar));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbRecupera = new System.Windows.Forms.Label();
            this.imgMuestra2 = new System.Windows.Forms.PictureBox();
            this.imgMuestra1 = new System.Windows.Forms.PictureBox();
            this.lbErrorConfirma = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.lbConfirma = new System.Windows.Forms.Label();
            this.lbErrorClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIzquierdo.BackgroundImage")));
            this.panelIzquierdo.Controls.Add(this.logoEmpresa);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 379);
            this.panelIzquierdo.TabIndex = 1;
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
            this.logoEmpresa.TabIndex = 2;
            this.logoEmpresa.TabStop = false;
            // 
            // lbRecupera
            // 
            this.lbRecupera.AutoSize = true;
            this.lbRecupera.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecupera.Location = new System.Drawing.Point(141, 21);
            this.lbRecupera.Name = "lbRecupera";
            this.lbRecupera.Size = new System.Drawing.Size(532, 67);
            this.lbRecupera.TabIndex = 3;
            this.lbRecupera.Text = "CONFIRMAR NUEVA CLAVE";
            // 
            // imgMuestra2
            // 
            this.imgMuestra2.Image = ((System.Drawing.Image)(resources.GetObject("imgMuestra2.Image")));
            this.imgMuestra2.Location = new System.Drawing.Point(548, 202);
            this.imgMuestra2.Name = "imgMuestra2";
            this.imgMuestra2.Size = new System.Drawing.Size(32, 30);
            this.imgMuestra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMuestra2.TabIndex = 53;
            this.imgMuestra2.TabStop = false;
            // 
            // imgMuestra1
            // 
            this.imgMuestra1.Image = ((System.Drawing.Image)(resources.GetObject("imgMuestra1.Image")));
            this.imgMuestra1.Location = new System.Drawing.Point(548, 114);
            this.imgMuestra1.Name = "imgMuestra1";
            this.imgMuestra1.Size = new System.Drawing.Size(32, 30);
            this.imgMuestra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMuestra1.TabIndex = 52;
            this.imgMuestra1.TabStop = false;
            // 
            // lbErrorConfirma
            // 
            this.lbErrorConfirma.AutoSize = true;
            this.lbErrorConfirma.BackColor = System.Drawing.Color.White;
            this.lbErrorConfirma.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorConfirma.ForeColor = System.Drawing.Color.Red;
            this.lbErrorConfirma.Location = new System.Drawing.Point(150, 245);
            this.lbErrorConfirma.Name = "lbErrorConfirma";
            this.lbErrorConfirma.Size = new System.Drawing.Size(41, 23);
            this.lbErrorConfirma.TabIndex = 51;
            this.lbErrorConfirma.Text = "Error";
            this.lbErrorConfirma.Visible = false;
            // 
            // txtConfirma
            // 
            this.txtConfirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirma.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConfirma.Location = new System.Drawing.Point(154, 202);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(361, 24);
            this.txtConfirma.TabIndex = 50;
            this.txtConfirma.Text = "Confirmar contraseña";
            this.txtConfirma.TextChanged += new System.EventHandler(this.txtConfirma_TextChanged);
            this.txtConfirma.Enter += new System.EventHandler(this.txtConfirma_Enter);
            this.txtConfirma.Leave += new System.EventHandler(this.txtConfirma_Leave);
            // 
            // lbConfirma
            // 
            this.lbConfirma.AutoSize = true;
            this.lbConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirma.Location = new System.Drawing.Point(150, 227);
            this.lbConfirma.Name = "lbConfirma";
            this.lbConfirma.Size = new System.Drawing.Size(364, 13);
            this.lbConfirma.TabIndex = 49;
            this.lbConfirma.Text = "___________________________________________________";
            // 
            // lbErrorClave
            // 
            this.lbErrorClave.AutoSize = true;
            this.lbErrorClave.BackColor = System.Drawing.Color.White;
            this.lbErrorClave.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorClave.ForeColor = System.Drawing.Color.Red;
            this.lbErrorClave.Location = new System.Drawing.Point(149, 157);
            this.lbErrorClave.Name = "lbErrorClave";
            this.lbErrorClave.Size = new System.Drawing.Size(40, 22);
            this.lbErrorClave.TabIndex = 48;
            this.lbErrorClave.Text = "Error";
            this.lbErrorClave.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.Location = new System.Drawing.Point(153, 114);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(361, 24);
            this.txtClave.TabIndex = 47;
            this.txtClave.Text = "Contraseña";
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.Location = new System.Drawing.Point(149, 139);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(364, 13);
            this.lbClave.TabIndex = 46;
            this.lbClave.Text = "___________________________________________________";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.Location = new System.Drawing.Point(154, 299);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(214, 40);
            this.btnCambiar.TabIndex = 54;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            this.btnCambiar.MouseLeave += new System.EventHandler(this.btnCambiar_MouseLeave);
            this.btnCambiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCambiar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(374, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 40);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // FormRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 379);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.imgMuestra2);
            this.Controls.Add(this.imgMuestra1);
            this.Controls.Add(this.lbErrorConfirma);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.lbConfirma);
            this.Controls.Add(this.lbErrorClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.lbRecupera);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecuperar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRecuperar_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbRecupera;
        private System.Windows.Forms.PictureBox imgMuestra2;
        private System.Windows.Forms.PictureBox imgMuestra1;
        private System.Windows.Forms.Label lbErrorConfirma;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label lbConfirma;
        private System.Windows.Forms.Label lbErrorClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}