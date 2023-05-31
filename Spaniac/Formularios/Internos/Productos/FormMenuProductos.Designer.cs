namespace Spaniac.Formularios.Internos.Productos
{
    partial class FormMenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuProductos));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbErrorNombre = new System.Windows.Forms.Label();
            this.lbErrorStock = new System.Windows.Forms.Label();
            this.stockReservado = new System.Windows.Forms.NumericUpDown();
            this.stockFuturo = new System.Windows.Forms.NumericUpDown();
            this.txtD1 = new System.Windows.Forms.RichTextBox();
            this.cantMinima = new System.Windows.Forms.NumericUpDown();
            this.lbErrorCantMin = new System.Windows.Forms.Label();
            this.cantMaxima = new System.Windows.Forms.NumericUpDown();
            this.lbErrorCantMax = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbErrorPrecioVenta = new System.Windows.Forms.Label();
            this.cbCifProveedor = new System.Windows.Forms.ComboBox();
            this.lbErrorCIF = new System.Windows.Forms.Label();
            this.cbIdCategoria = new System.Windows.Forms.ComboBox();
            this.lbErrorIDCategoria = new System.Windows.Forms.Label();
            this.txtIDAlmacen = new System.Windows.Forms.TextBox();
            this.lbIDAlmacen = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAñadirProducto = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockReservado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockFuturo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.panelAñadirProducto.SuspendLayout();
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
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 650);
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
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(23, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(451, 67);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "MENÚ DE PRODUCTOS";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelAñadirProducto);
            this.panelMenu.Controls.Add(this.txtDescripcion);
            this.panelMenu.Controls.Add(this.lbTitulo);
            this.panelMenu.Location = new System.Drawing.Point(146, 21);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(972, 603);
            this.panelMenu.TabIndex = 6;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(35, 86);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(626, 79);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(29, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(223, 31);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "ID Autogenerado";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(29, 109);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 35);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(26, 136);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(224, 13);
            this.lbNombre.TabIndex = 14;
            this.lbNombre.Text = "_______________________________";
            // 
            // lbErrorNombre
            // 
            this.lbErrorNombre.AutoSize = true;
            this.lbErrorNombre.BackColor = System.Drawing.Color.White;
            this.lbErrorNombre.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombre.Location = new System.Drawing.Point(26, 149);
            this.lbErrorNombre.Name = "lbErrorNombre";
            this.lbErrorNombre.Size = new System.Drawing.Size(41, 23);
            this.lbErrorNombre.TabIndex = 15;
            this.lbErrorNombre.Text = "Error";
            this.lbErrorNombre.Visible = false;
            // 
            // lbErrorStock
            // 
            this.lbErrorStock.AutoSize = true;
            this.lbErrorStock.BackColor = System.Drawing.Color.White;
            this.lbErrorStock.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lbErrorStock.Location = new System.Drawing.Point(26, 253);
            this.lbErrorStock.Name = "lbErrorStock";
            this.lbErrorStock.Size = new System.Drawing.Size(41, 23);
            this.lbErrorStock.TabIndex = 17;
            this.lbErrorStock.Text = "Error";
            this.lbErrorStock.Visible = false;
            // 
            // stockReservado
            // 
            this.stockReservado.Enabled = false;
            this.stockReservado.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReservado.Location = new System.Drawing.Point(313, 118);
            this.stockReservado.Name = "stockReservado";
            this.stockReservado.Size = new System.Drawing.Size(221, 31);
            this.stockReservado.TabIndex = 18;
            // 
            // stockFuturo
            // 
            this.stockFuturo.Enabled = false;
            this.stockFuturo.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockFuturo.Location = new System.Drawing.Point(313, 205);
            this.stockFuturo.Name = "stockFuturo";
            this.stockFuturo.Size = new System.Drawing.Size(221, 31);
            this.stockFuturo.TabIndex = 19;
            // 
            // txtD1
            // 
            this.txtD1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtD1.Font = new System.Drawing.Font("Reem Kufi", 9F);
            this.txtD1.Location = new System.Drawing.Point(313, 43);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(207, 59);
            this.txtD1.TabIndex = 20;
            this.txtD1.Text = "Tanto el stock reservado como el futuro quedan  a  0  a la hora de realizar la in" +
    "serción.";
            // 
            // cantMinima
            // 
            this.cantMinima.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantMinima.Location = new System.Drawing.Point(725, 44);
            this.cantMinima.Name = "cantMinima";
            this.cantMinima.Size = new System.Drawing.Size(93, 31);
            this.cantMinima.TabIndex = 21;
            this.cantMinima.ValueChanged += new System.EventHandler(this.cantMinima_ValueChanged);
            // 
            // lbErrorCantMin
            // 
            this.lbErrorCantMin.AutoSize = true;
            this.lbErrorCantMin.BackColor = System.Drawing.Color.White;
            this.lbErrorCantMin.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorCantMin.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCantMin.Location = new System.Drawing.Point(593, 79);
            this.lbErrorCantMin.Name = "lbErrorCantMin";
            this.lbErrorCantMin.Size = new System.Drawing.Size(41, 23);
            this.lbErrorCantMin.TabIndex = 22;
            this.lbErrorCantMin.Text = "Error";
            this.lbErrorCantMin.Visible = false;
            // 
            // cantMaxima
            // 
            this.cantMaxima.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantMaxima.Location = new System.Drawing.Point(725, 136);
            this.cantMaxima.Name = "cantMaxima";
            this.cantMaxima.Size = new System.Drawing.Size(93, 31);
            this.cantMaxima.TabIndex = 23;
            this.cantMaxima.ValueChanged += new System.EventHandler(this.cantMaxima_ValueChanged);
            // 
            // lbErrorCantMax
            // 
            this.lbErrorCantMax.AutoSize = true;
            this.lbErrorCantMax.BackColor = System.Drawing.Color.White;
            this.lbErrorCantMax.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorCantMax.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCantMax.Location = new System.Drawing.Point(593, 170);
            this.lbErrorCantMax.Name = "lbErrorCantMax";
            this.lbErrorCantMax.Size = new System.Drawing.Size(41, 23);
            this.lbErrorCantMax.TabIndex = 24;
            this.lbErrorCantMax.Text = "Error";
            this.lbErrorCantMax.Visible = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioVenta.Location = new System.Drawing.Point(597, 205);
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(223, 35);
            this.txtPrecioVenta.TabIndex = 25;
            this.txtPrecioVenta.Text = "Precio de venta";
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioVenta.Location = new System.Drawing.Point(594, 232);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(224, 13);
            this.lbPrecioVenta.TabIndex = 26;
            this.lbPrecioVenta.Text = "_______________________________";
            // 
            // lbErrorPrecioVenta
            // 
            this.lbErrorPrecioVenta.AutoSize = true;
            this.lbErrorPrecioVenta.BackColor = System.Drawing.Color.White;
            this.lbErrorPrecioVenta.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorPrecioVenta.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPrecioVenta.Location = new System.Drawing.Point(594, 250);
            this.lbErrorPrecioVenta.Name = "lbErrorPrecioVenta";
            this.lbErrorPrecioVenta.Size = new System.Drawing.Size(41, 23);
            this.lbErrorPrecioVenta.TabIndex = 27;
            this.lbErrorPrecioVenta.Text = "Error";
            this.lbErrorPrecioVenta.Visible = false;
            // 
            // cbCifProveedor
            // 
            this.cbCifProveedor.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCifProveedor.FormattingEnabled = true;
            this.cbCifProveedor.Location = new System.Drawing.Point(79, 299);
            this.cbCifProveedor.Name = "cbCifProveedor";
            this.cbCifProveedor.Size = new System.Drawing.Size(171, 36);
            this.cbCifProveedor.TabIndex = 28;
            this.cbCifProveedor.SelectedIndexChanged += new System.EventHandler(this.cbCifProveedor_SelectedIndexChanged);
            // 
            // lbErrorCIF
            // 
            this.lbErrorCIF.AutoSize = true;
            this.lbErrorCIF.BackColor = System.Drawing.Color.White;
            this.lbErrorCIF.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorCIF.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCIF.Location = new System.Drawing.Point(26, 338);
            this.lbErrorCIF.Name = "lbErrorCIF";
            this.lbErrorCIF.Size = new System.Drawing.Size(41, 23);
            this.lbErrorCIF.TabIndex = 29;
            this.lbErrorCIF.Text = "Error";
            this.lbErrorCIF.Visible = false;
            // 
            // cbIdCategoria
            // 
            this.cbIdCategoria.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCategoria.FormattingEnabled = true;
            this.cbIdCategoria.Location = new System.Drawing.Point(313, 303);
            this.cbIdCategoria.Name = "cbIdCategoria";
            this.cbIdCategoria.Size = new System.Drawing.Size(124, 36);
            this.cbIdCategoria.TabIndex = 30;
            this.cbIdCategoria.SelectedIndexChanged += new System.EventHandler(this.cbIdCategoria_SelectedIndexChanged);
            // 
            // lbErrorIDCategoria
            // 
            this.lbErrorIDCategoria.AutoSize = true;
            this.lbErrorIDCategoria.BackColor = System.Drawing.Color.White;
            this.lbErrorIDCategoria.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorIDCategoria.ForeColor = System.Drawing.Color.Red;
            this.lbErrorIDCategoria.Location = new System.Drawing.Point(309, 342);
            this.lbErrorIDCategoria.Name = "lbErrorIDCategoria";
            this.lbErrorIDCategoria.Size = new System.Drawing.Size(41, 23);
            this.lbErrorIDCategoria.TabIndex = 31;
            this.lbErrorIDCategoria.Text = "Error";
            this.lbErrorIDCategoria.Visible = false;
            // 
            // txtIDAlmacen
            // 
            this.txtIDAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAlmacen.Enabled = false;
            this.txtIDAlmacen.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAlmacen.ForeColor = System.Drawing.Color.Gray;
            this.txtIDAlmacen.Location = new System.Drawing.Point(446, 299);
            this.txtIDAlmacen.Multiline = true;
            this.txtIDAlmacen.Name = "txtIDAlmacen";
            this.txtIDAlmacen.Size = new System.Drawing.Size(88, 35);
            this.txtIDAlmacen.TabIndex = 32;
            this.txtIDAlmacen.Text = "Almacén";
            // 
            // lbIDAlmacen
            // 
            this.lbIDAlmacen.AutoSize = true;
            this.lbIDAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDAlmacen.Location = new System.Drawing.Point(443, 326);
            this.lbIDAlmacen.Name = "lbIDAlmacen";
            this.lbIDAlmacen.Size = new System.Drawing.Size(91, 13);
            this.lbIDAlmacen.TabIndex = 33;
            this.lbIDAlmacen.Text = "____________";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(597, 297);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(221, 32);
            this.btnInsertar.TabIndex = 37;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            this.btnInsertar.MouseLeave += new System.EventHandler(this.btnInsertar_MouseLeave);
            this.btnInsertar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInsertar_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(597, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 30);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(79, 219);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(171, 31);
            this.stock.TabIndex = 39;
            this.stock.ValueChanged += new System.EventHandler(this.stock_ValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.lb1.Location = new System.Drawing.Point(25, 219);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(48, 26);
            this.lb1.TabIndex = 40;
            this.lb1.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.label1.Location = new System.Drawing.Point(31, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "CIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.label2.Location = new System.Drawing.Point(308, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID de Categoría y Almacén:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.label3.Location = new System.Drawing.Point(593, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cantidad Máxima:";
            // 
            // panelAñadirProducto
            // 
            this.panelAñadirProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAñadirProducto.Controls.Add(this.label4);
            this.panelAñadirProducto.Controls.Add(this.label3);
            this.panelAñadirProducto.Controls.Add(this.label2);
            this.panelAñadirProducto.Controls.Add(this.label1);
            this.panelAñadirProducto.Controls.Add(this.lb1);
            this.panelAñadirProducto.Controls.Add(this.stock);
            this.panelAñadirProducto.Controls.Add(this.btnSalir);
            this.panelAñadirProducto.Controls.Add(this.btnInsertar);
            this.panelAñadirProducto.Controls.Add(this.lbIDAlmacen);
            this.panelAñadirProducto.Controls.Add(this.txtIDAlmacen);
            this.panelAñadirProducto.Controls.Add(this.lbErrorIDCategoria);
            this.panelAñadirProducto.Controls.Add(this.cbIdCategoria);
            this.panelAñadirProducto.Controls.Add(this.lbErrorCIF);
            this.panelAñadirProducto.Controls.Add(this.cbCifProveedor);
            this.panelAñadirProducto.Controls.Add(this.lbErrorPrecioVenta);
            this.panelAñadirProducto.Controls.Add(this.lbPrecioVenta);
            this.panelAñadirProducto.Controls.Add(this.txtPrecioVenta);
            this.panelAñadirProducto.Controls.Add(this.lbErrorCantMax);
            this.panelAñadirProducto.Controls.Add(this.cantMaxima);
            this.panelAñadirProducto.Controls.Add(this.lbErrorCantMin);
            this.panelAñadirProducto.Controls.Add(this.cantMinima);
            this.panelAñadirProducto.Controls.Add(this.txtD1);
            this.panelAñadirProducto.Controls.Add(this.stockFuturo);
            this.panelAñadirProducto.Controls.Add(this.stockReservado);
            this.panelAñadirProducto.Controls.Add(this.lbErrorStock);
            this.panelAñadirProducto.Controls.Add(this.lbErrorNombre);
            this.panelAñadirProducto.Controls.Add(this.lbNombre);
            this.panelAñadirProducto.Controls.Add(this.txtNombre);
            this.panelAñadirProducto.Controls.Add(this.txtId);
            this.panelAñadirProducto.Location = new System.Drawing.Point(35, 188);
            this.panelAñadirProducto.Name = "panelAñadirProducto";
            this.panelAñadirProducto.Size = new System.Drawing.Size(896, 390);
            this.panelAñadirProducto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.label4.Location = new System.Drawing.Point(592, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad Mínima:";
            // 
            // FormMenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProd";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuProductos_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockReservado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockFuturo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.panelAñadirProducto.ResumeLayout(false);
            this.panelAñadirProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Panel panelAñadirProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lbIDAlmacen;
        private System.Windows.Forms.TextBox txtIDAlmacen;
        private System.Windows.Forms.Label lbErrorIDCategoria;
        private System.Windows.Forms.ComboBox cbIdCategoria;
        private System.Windows.Forms.Label lbErrorCIF;
        private System.Windows.Forms.ComboBox cbCifProveedor;
        private System.Windows.Forms.Label lbErrorPrecioVenta;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lbErrorCantMax;
        private System.Windows.Forms.NumericUpDown cantMaxima;
        private System.Windows.Forms.Label lbErrorCantMin;
        private System.Windows.Forms.NumericUpDown cantMinima;
        private System.Windows.Forms.RichTextBox txtD1;
        private System.Windows.Forms.NumericUpDown stockFuturo;
        private System.Windows.Forms.NumericUpDown stockReservado;
        private System.Windows.Forms.Label lbErrorStock;
        private System.Windows.Forms.Label lbErrorNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
    }
}