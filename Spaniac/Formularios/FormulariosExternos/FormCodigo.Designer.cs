namespace Spaniac.Formularios
{
    partial class FormCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodigo));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.codigo1 = new System.Windows.Forms.MaskedTextBox();
            this.codigo2 = new System.Windows.Forms.MaskedTextBox();
            this.codigo3 = new System.Windows.Forms.MaskedTextBox();
            this.codigo4 = new System.Windows.Forms.MaskedTextBox();
            this.codigo5 = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelBloqueo = new System.Windows.Forms.Panel();
            this.bloqueoCodigo = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.panelBloqueo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloqueoCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIzquierdo.BackgroundImage")));
            this.panelIzquierdo.Controls.Add(this.logoEmpresa);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 354);
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
            this.logoEmpresa.TabIndex = 2;
            this.logoEmpresa.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(134, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(347, 71);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "CONFIRMACIÓN";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.White;
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion.Font = new System.Drawing.Font("Reem Kufi", 9.7F);
            this.descripcion.Location = new System.Drawing.Point(146, 89);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(367, 75);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "Descripción del titulo";
            // 
            // codigo1
            // 
            this.codigo1.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo1.Location = new System.Drawing.Point(146, 218);
            this.codigo1.Mask = "9";
            this.codigo1.Name = "codigo1";
            this.codigo1.Size = new System.Drawing.Size(61, 59);
            this.codigo1.TabIndex = 5;
            this.codigo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo1.TextChanged += new System.EventHandler(this.codigo1_TextChanged);
            // 
            // codigo2
            // 
            this.codigo2.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo2.Location = new System.Drawing.Point(223, 218);
            this.codigo2.Mask = "9";
            this.codigo2.Name = "codigo2";
            this.codigo2.Size = new System.Drawing.Size(61, 59);
            this.codigo2.TabIndex = 6;
            this.codigo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo2.TextChanged += new System.EventHandler(this.codigo2_TextChanged);
            // 
            // codigo3
            // 
            this.codigo3.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo3.Location = new System.Drawing.Point(299, 218);
            this.codigo3.Mask = "9";
            this.codigo3.Name = "codigo3";
            this.codigo3.Size = new System.Drawing.Size(61, 59);
            this.codigo3.TabIndex = 7;
            this.codigo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo3.TextChanged += new System.EventHandler(this.codigo3_TextChanged);
            // 
            // codigo4
            // 
            this.codigo4.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo4.Location = new System.Drawing.Point(376, 218);
            this.codigo4.Mask = "9";
            this.codigo4.Name = "codigo4";
            this.codigo4.Size = new System.Drawing.Size(61, 59);
            this.codigo4.TabIndex = 8;
            this.codigo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo4.TextChanged += new System.EventHandler(this.codigo4_TextChanged);
            // 
            // codigo5
            // 
            this.codigo5.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo5.Location = new System.Drawing.Point(452, 218);
            this.codigo5.Mask = "9";
            this.codigo5.Name = "codigo5";
            this.codigo5.Size = new System.Drawing.Size(61, 59);
            this.codigo5.TabIndex = 9;
            this.codigo5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo5.TextChanged += new System.EventHandler(this.codigo5_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(146, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 40);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(339, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 40);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelBloqueo
            // 
            this.panelBloqueo.Controls.Add(this.bloqueoCodigo);
            this.panelBloqueo.Location = new System.Drawing.Point(146, 197);
            this.panelBloqueo.Name = "panelBloqueo";
            this.panelBloqueo.Size = new System.Drawing.Size(367, 80);
            this.panelBloqueo.TabIndex = 44;
            this.panelBloqueo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBloqueo_MouseDown);
            // 
            // bloqueoCodigo
            // 
            this.bloqueoCodigo.Image = ((System.Drawing.Image)(resources.GetObject("bloqueoCodigo.Image")));
            this.bloqueoCodigo.Location = new System.Drawing.Point(153, 18);
            this.bloqueoCodigo.Name = "bloqueoCodigo";
            this.bloqueoCodigo.Size = new System.Drawing.Size(61, 50);
            this.bloqueoCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bloqueoCodigo.TabIndex = 0;
            this.bloqueoCodigo.TabStop = false;
            this.bloqueoCodigo.Click += new System.EventHandler(this.bloqueoCodigo_Click);
            this.bloqueoCodigo.MouseLeave += new System.EventHandler(this.bloqueoCodigo_MouseLeave);
            this.bloqueoCodigo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bloqueoCodigo_MouseMove);
            // 
            // FormCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 354);
            this.Controls.Add(this.panelBloqueo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.codigo5);
            this.Controls.Add(this.codigo4);
            this.Controls.Add(this.codigo3);
            this.Controls.Add(this.codigo2);
            this.Controls.Add(this.codigo1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCodigo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCodigo_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.panelBloqueo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bloqueoCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.MaskedTextBox codigo1;
        private System.Windows.Forms.MaskedTextBox codigo2;
        private System.Windows.Forms.MaskedTextBox codigo3;
        private System.Windows.Forms.MaskedTextBox codigo4;
        private System.Windows.Forms.MaskedTextBox codigo5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelBloqueo;
        private System.Windows.Forms.PictureBox bloqueoCodigo;
    }
}