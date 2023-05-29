namespace Spaniac.Formularios.Internos.Productos
{
    partial class FormListarCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarCategorias));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.listadoCompleto = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDAlmacen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 516);
            this.panelIzquierdo.TabIndex = 3;
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
            this.lbInicio.Location = new System.Drawing.Point(133, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(271, 67);
            this.lbInicio.TabIndex = 4;
            this.lbInicio.Text = "CATEGORÍAS";
            // 
            // listadoCompleto
            // 
            this.listadoCompleto.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.listadoCompleto.Location = new System.Drawing.Point(145, 89);
            this.listadoCompleto.Name = "listadoCompleto";
            this.listadoCompleto.Size = new System.Drawing.Size(319, 385);
            this.listadoCompleto.TabIndex = 5;
            this.listadoCompleto.Text = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(601, 89);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 36);
            this.txtID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label1.Location = new System.Drawing.Point(547, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(601, 144);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 36);
            this.txtNombre.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label2.Location = new System.Drawing.Point(505, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // txtProductos
            // 
            this.txtProductos.Enabled = false;
            this.txtProductos.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos.Location = new System.Drawing.Point(601, 201);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(239, 36);
            this.txtProductos.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label3.Location = new System.Drawing.Point(491, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Productos:";
            // 
            // txtIDAlmacen
            // 
            this.txtIDAlmacen.Enabled = false;
            this.txtIDAlmacen.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAlmacen.Location = new System.Drawing.Point(601, 258);
            this.txtIDAlmacen.Multiline = true;
            this.txtIDAlmacen.Name = "txtIDAlmacen";
            this.txtIDAlmacen.Size = new System.Drawing.Size(239, 36);
            this.txtIDAlmacen.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label4.Location = new System.Drawing.Point(484, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID Almacén:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(503, 434);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(337, 40);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnUltimo.ForeColor = System.Drawing.Color.White;
            this.btnUltimo.Location = new System.Drawing.Point(681, 373);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(159, 40);
            this.btnUltimo.TabIndex = 37;
            this.btnUltimo.Text = "ÚLTIMO";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            this.btnUltimo.MouseLeave += new System.EventHandler(this.btnUltimo_MouseLeave);
            this.btnUltimo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUltimo_MouseMove);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Location = new System.Drawing.Point(503, 373);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(159, 40);
            this.btnPrimero.TabIndex = 36;
            this.btnPrimero.Text = "PRIMERO";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            this.btnPrimero.MouseLeave += new System.EventHandler(this.btnPrimero_MouseLeave);
            this.btnPrimero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPrimero_MouseMove);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(681, 327);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(159, 40);
            this.btnSiguiente.TabIndex = 35;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            this.btnSiguiente.MouseLeave += new System.EventHandler(this.btnSiguiente_MouseLeave);
            this.btnSiguiente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSiguiente_MouseMove);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(503, 327);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(159, 40);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            this.btnAnterior.MouseLeave += new System.EventHandler(this.btnAnterior_MouseLeave);
            this.btnAnterior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAnterior_MouseMove);
            // 
            // FormListarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(873, 516);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtIDAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoCompleto);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListarCategorias";
            this.Text = "FormListarProductos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormListarCategorias_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.RichTextBox listadoCompleto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
    }
}