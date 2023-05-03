namespace Spaniac.Formularios
{
    partial class FormCarga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarga));
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.aparece = new System.Windows.Forms.Timer(this.components);
            this.desaparece = new System.Windows.Forms.Timer(this.components);
            this.barra = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.logoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("logoEmpresa.Image")));
            this.logoEmpresa.Location = new System.Drawing.Point(21, 17);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(127, 111);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEmpresa.TabIndex = 0;
            this.logoEmpresa.TabStop = false;
            // 
            // aparece
            // 
            this.aparece.Interval = 30;
            this.aparece.Tick += new System.EventHandler(this.aparece_Tick);
            // 
            // desaparece
            // 
            this.desaparece.Interval = 30;
            this.desaparece.Tick += new System.EventHandler(this.desaparece_Tick);
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(34, 135);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(100, 11);
            this.barra.Step = 1;
            this.barra.TabIndex = 1;
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(171, 170);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.logoEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarga";
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Timer aparece;
        private System.Windows.Forms.Timer desaparece;
        private System.Windows.Forms.ProgressBar barra;
    }
}