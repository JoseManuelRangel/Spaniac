namespace Spaniac.Formularios.Internos.Productos
{
    partial class FormCategoriaXProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaXProducto));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.panelCat = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtIDAlmacen = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbIDCategoria = new System.Windows.Forms.ComboBox();
            this.barra1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCatXProd = new System.Windows.Forms.DataGridView();
            this.barra4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.panelCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatXProd)).BeginInit();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 509);
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
            this.logoEmpresa.TabIndex = 1;
            this.logoEmpresa.TabStop = false;
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.White;
            this.panelCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCat.Controls.Add(this.label1);
            this.panelCat.Controls.Add(this.lbError);
            this.panelCat.Controls.Add(this.lb1);
            this.panelCat.Controls.Add(this.txtIDAlmacen);
            this.panelCat.Controls.Add(this.txtProductos);
            this.panelCat.Controls.Add(this.txtNombre);
            this.panelCat.Controls.Add(this.cbIDCategoria);
            this.panelCat.Controls.Add(this.barra1);
            this.panelCat.Location = new System.Drawing.Point(137, 21);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(264, 406);
            this.panelCat.TabIndex = 3;
            this.panelCat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCat_MouseDown);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.White;
            this.lbError.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(13, 139);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(41, 23);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "Error";
            this.lbError.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Reem Kufi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb1.Location = new System.Drawing.Point(51, 293);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(162, 49);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "ALMACÉN";
            // 
            // txtIDAlmacen
            // 
            this.txtIDAlmacen.Enabled = false;
            this.txtIDAlmacen.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.txtIDAlmacen.Location = new System.Drawing.Point(17, 357);
            this.txtIDAlmacen.Multiline = true;
            this.txtIDAlmacen.Name = "txtIDAlmacen";
            this.txtIDAlmacen.Size = new System.Drawing.Size(230, 33);
            this.txtIDAlmacen.TabIndex = 5;
            // 
            // txtProductos
            // 
            this.txtProductos.Enabled = false;
            this.txtProductos.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.txtProductos.Location = new System.Drawing.Point(17, 232);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(230, 33);
            this.txtProductos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(17, 183);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 33);
            this.txtNombre.TabIndex = 3;
            // 
            // cbIDCategoria
            // 
            this.cbIDCategoria.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.cbIDCategoria.FormattingEnabled = true;
            this.cbIDCategoria.Location = new System.Drawing.Point(17, 105);
            this.cbIDCategoria.Name = "cbIDCategoria";
            this.cbIDCategoria.Size = new System.Drawing.Size(230, 31);
            this.cbIDCategoria.TabIndex = 2;
            this.cbIDCategoria.SelectedIndexChanged += new System.EventHandler(this.cbIDCategoria_SelectedIndexChanged);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.MidnightBlue;
            this.barra1.Location = new System.Drawing.Point(17, 80);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(230, 5);
            this.barra1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(137, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(266, 55);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // dgvCatXProd
            // 
            this.dgvCatXProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatXProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatXProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatXProd.Location = new System.Drawing.Point(454, 21);
            this.dgvCatXProd.Name = "dgvCatXProd";
            this.dgvCatXProd.Size = new System.Drawing.Size(563, 467);
            this.dgvCatXProd.TabIndex = 10;
            // 
            // barra4
            // 
            this.barra4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barra4.Location = new System.Drawing.Point(428, 21);
            this.barra4.Name = "barra4";
            this.barra4.Size = new System.Drawing.Size(3, 470);
            this.barra4.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "CATEGORÍA";
            // 
            // FormCategoriaXProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 509);
            this.Controls.Add(this.barra4);
            this.Controls.Add(this.dgvCatXProd);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoriaXProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoriaXProducto";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCategoriaXProducto_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatXProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.ComboBox cbIDCategoria;
        private System.Windows.Forms.Panel barra1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCatXProd;
        private System.Windows.Forms.TextBox txtIDAlmacen;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel barra4;
        private System.Windows.Forms.Label label1;
    }
}