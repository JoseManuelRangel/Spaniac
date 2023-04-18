namespace Spaniac
{
    partial class MenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("imgMinimizar.Image")));
            this.imgMinimizar.InitialImage = null;
            this.imgMinimizar.Location = new System.Drawing.Point(634, 3);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(36, 36);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMinimizar.TabIndex = 0;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            this.imgMinimizar.MouseEnter += new System.EventHandler(this.imgMinimizar_MouseEnter);
            this.imgMinimizar.MouseLeave += new System.EventHandler(this.imgMinimizar_MouseLeave);
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Image = ((System.Drawing.Image)(resources.GetObject("imgCerrar.Image")));
            this.imgCerrar.Location = new System.Drawing.Point(676, 3);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(36, 36);
            this.imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCerrar.TabIndex = 1;
            this.imgCerrar.TabStop = false;
            this.imgCerrar.Click += new System.EventHandler(this.imgCerrar_Click);
            this.imgCerrar.MouseEnter += new System.EventHandler(this.imgCerrar_MouseEnter);
            this.imgCerrar.MouseLeave += new System.EventHandler(this.imgCerrar_MouseLeave);
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.logoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("logoEmpresa.Image")));
            this.logoEmpresa.Location = new System.Drawing.Point(184, 27);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(328, 323);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoEmpresa.TabIndex = 2;
            this.logoEmpresa.TabStop = false;
            this.logoEmpresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoEmpresa_MouseDown);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Reem Kufi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(184, 356);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(328, 45);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "INICIAR SESIÓN";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.btnIniciar_MouseEnter);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_MouseLeave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Reem Kufi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(184, 417);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(328, 45);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.MouseEnter += new System.EventHandler(this.btnRegistrarse_MouseEnter);
            this.btnRegistrarse.MouseLeave += new System.EventHandler(this.btnRegistrarse_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(184, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(328, 45);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 567);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.logoEmpresa);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.imgMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.PictureBox imgCerrar;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnSalir;
    }
}

