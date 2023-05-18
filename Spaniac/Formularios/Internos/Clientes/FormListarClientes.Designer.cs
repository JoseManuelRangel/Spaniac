namespace Spaniac.Formularios.Internos.Clientes
{
    partial class FormListarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarClientes));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.listadoCompleto = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 617);
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
            this.lbInicio.Location = new System.Drawing.Point(140, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(217, 67);
            this.lbInicio.TabIndex = 3;
            this.lbInicio.Text = "CLIENTES";
            // 
            // listadoCompleto
            // 
            this.listadoCompleto.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.listadoCompleto.Location = new System.Drawing.Point(152, 99);
            this.listadoCompleto.Name = "listadoCompleto";
            this.listadoCompleto.Size = new System.Drawing.Size(381, 488);
            this.listadoCompleto.TabIndex = 4;
            this.listadoCompleto.Text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(665, 154);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 36);
            this.txtNombre.TabIndex = 22;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(665, 211);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(239, 36);
            this.txtFecha.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(665, 99);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 36);
            this.txtID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label3.Location = new System.Drawing.Point(593, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label2.Location = new System.Drawing.Point(575, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label1.Location = new System.Drawing.Point(611, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(665, 270);
            this.txtLocalidad.Multiline = true;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(239, 36);
            this.txtLocalidad.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label4.Location = new System.Drawing.Point(562, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(665, 327);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 36);
            this.txtDireccion.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label5.Location = new System.Drawing.Point(562, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(665, 384);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 36);
            this.txtTelefono.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label6.Location = new System.Drawing.Point(568, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(567, 547);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(337, 40);
            this.btnSalir.TabIndex = 33;
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
            this.btnUltimo.Location = new System.Drawing.Point(745, 486);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(159, 40);
            this.btnUltimo.TabIndex = 32;
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
            this.btnPrimero.Location = new System.Drawing.Point(567, 486);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(159, 40);
            this.btnPrimero.TabIndex = 31;
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
            this.btnSiguiente.Location = new System.Drawing.Point(745, 440);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(159, 40);
            this.btnSiguiente.TabIndex = 30;
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
            this.btnAnterior.Location = new System.Drawing.Point(567, 440);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(159, 40);
            this.btnAnterior.TabIndex = 29;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            this.btnAnterior.MouseLeave += new System.EventHandler(this.btnAnterior_MouseLeave);
            this.btnAnterior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAnterior_MouseMove);
            // 
            // FormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(967, 617);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoCompleto);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListarClientes";
            this.Text = "FormListarClientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormListarClientes_MouseDown);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
    }
}