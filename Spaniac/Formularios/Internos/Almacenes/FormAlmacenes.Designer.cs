namespace Spaniac.Formularios.Internos.Almacenes
{
    partial class FormAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbInicio = new System.Windows.Forms.Label();
            this.barra1 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panelAlmacenes = new System.Windows.Forms.Panel();
            this.panelMenuExcel = new System.Windows.Forms.Panel();
            this.btnListarEXCEL = new System.Windows.Forms.Button();
            this.btnGenEXCEL = new System.Windows.Forms.Button();
            this.btnImpEXCEL = new System.Windows.Forms.Button();
            this.btnMenuExcel = new System.Windows.Forms.Button();
            this.panelMenuJSON = new System.Windows.Forms.Panel();
            this.btnListarJSON = new System.Windows.Forms.Button();
            this.btnGenJSON = new System.Windows.Forms.Button();
            this.btnImpJSON = new System.Windows.Forms.Button();
            this.btnMenuJSON = new System.Windows.Forms.Button();
            this.panelMenuXml = new System.Windows.Forms.Panel();
            this.btnListarXML = new System.Windows.Forms.Button();
            this.btnGenXML = new System.Windows.Forms.Button();
            this.btnImpXML = new System.Windows.Forms.Button();
            this.btnMenuXml = new System.Windows.Forms.Button();
            this.dgvAlmacenes = new System.Windows.Forms.DataGridView();
            this.imgLimpiar = new System.Windows.Forms.PictureBox();
            this.txtFiltroA = new System.Windows.Forms.TextBox();
            this.cbDatosA = new System.Windows.Forms.ComboBox();
            this.lbBuscarA = new System.Windows.Forms.Label();
            this.barra4 = new System.Windows.Forms.Panel();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelAñadirAlmacen = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAceptarAAdd = new System.Windows.Forms.Button();
            this.cbAct2 = new System.Windows.Forms.CheckBox();
            this.cbAct1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbErrorNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.barra3 = new System.Windows.Forms.Panel();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lbErrorEstado = new System.Windows.Forms.Label();
            this.panelAlmacenes.SuspendLayout();
            this.panelMenuExcel.SuspendLayout();
            this.panelMenuJSON.SuspendLayout();
            this.panelMenuXml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimpiar)).BeginInit();
            this.panelIzquierdo.SuspendLayout();
            this.panelAñadirAlmacen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Reem Kufi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbInicio.Location = new System.Drawing.Point(34, 23);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(461, 116);
            this.lbInicio.TabIndex = 8;
            this.lbInicio.Text = "ALMACENES";
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barra1.Location = new System.Drawing.Point(54, 151);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(1386, 5);
            this.barra1.TabIndex = 9;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.lbFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFecha.Location = new System.Drawing.Point(1224, 95);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(98, 27);
            this.lbFecha.TabIndex = 11;
            this.lbFecha.Text = "DÍA ACTUAL";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Reem Kufi", 18F, System.Drawing.FontStyle.Bold);
            this.lbHora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbHora.Location = new System.Drawing.Point(1349, 57);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(91, 44);
            this.lbHora.TabIndex = 10;
            this.lbHora.Text = "HORA";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAlmacenes
            // 
            this.panelAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlmacenes.Controls.Add(this.panelMenuExcel);
            this.panelAlmacenes.Controls.Add(this.btnMenuExcel);
            this.panelAlmacenes.Controls.Add(this.panelMenuJSON);
            this.panelAlmacenes.Controls.Add(this.btnMenuJSON);
            this.panelAlmacenes.Controls.Add(this.panelMenuXml);
            this.panelAlmacenes.Controls.Add(this.btnMenuXml);
            this.panelAlmacenes.Controls.Add(this.dgvAlmacenes);
            this.panelAlmacenes.Controls.Add(this.imgLimpiar);
            this.panelAlmacenes.Controls.Add(this.txtFiltroA);
            this.panelAlmacenes.Controls.Add(this.cbDatosA);
            this.panelAlmacenes.Controls.Add(this.lbBuscarA);
            this.panelAlmacenes.Controls.Add(this.barra4);
            this.panelAlmacenes.Controls.Add(this.panelIzquierdo);
            this.panelAlmacenes.Controls.Add(this.btnEliminar);
            this.panelAlmacenes.Controls.Add(this.btnModificar);
            this.panelAlmacenes.Controls.Add(this.btnAñadir);
            this.panelAlmacenes.Controls.Add(this.barra3);
            this.panelAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlmacenes.Location = new System.Drawing.Point(54, 185);
            this.panelAlmacenes.Name = "panelAlmacenes";
            this.panelAlmacenes.Size = new System.Drawing.Size(1386, 637);
            this.panelAlmacenes.TabIndex = 12;
            // 
            // panelMenuExcel
            // 
            this.panelMenuExcel.Controls.Add(this.btnListarEXCEL);
            this.panelMenuExcel.Controls.Add(this.btnGenEXCEL);
            this.panelMenuExcel.Controls.Add(this.btnImpEXCEL);
            this.panelMenuExcel.Location = new System.Drawing.Point(342, 524);
            this.panelMenuExcel.Name = "panelMenuExcel";
            this.panelMenuExcel.Size = new System.Drawing.Size(180, 92);
            this.panelMenuExcel.TabIndex = 50;
            // 
            // btnListarEXCEL
            // 
            this.btnListarEXCEL.BackColor = System.Drawing.Color.White;
            this.btnListarEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListarEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnListarEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEXCEL.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnListarEXCEL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnListarEXCEL.Location = new System.Drawing.Point(2, 60);
            this.btnListarEXCEL.Name = "btnListarEXCEL";
            this.btnListarEXCEL.Size = new System.Drawing.Size(177, 30);
            this.btnListarEXCEL.TabIndex = 47;
            this.btnListarEXCEL.Text = "LISTAR EXCEL";
            this.btnListarEXCEL.UseVisualStyleBackColor = false;
            // 
            // btnGenEXCEL
            // 
            this.btnGenEXCEL.BackColor = System.Drawing.Color.White;
            this.btnGenEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGenEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenEXCEL.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGenEXCEL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenEXCEL.Location = new System.Drawing.Point(2, 30);
            this.btnGenEXCEL.Name = "btnGenEXCEL";
            this.btnGenEXCEL.Size = new System.Drawing.Size(177, 30);
            this.btnGenEXCEL.TabIndex = 46;
            this.btnGenEXCEL.Text = "GENERAR EXCEL";
            this.btnGenEXCEL.UseVisualStyleBackColor = false;
            // 
            // btnImpEXCEL
            // 
            this.btnImpEXCEL.BackColor = System.Drawing.Color.White;
            this.btnImpEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImpEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnImpEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImpEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpEXCEL.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImpEXCEL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImpEXCEL.Location = new System.Drawing.Point(2, 0);
            this.btnImpEXCEL.Name = "btnImpEXCEL";
            this.btnImpEXCEL.Size = new System.Drawing.Size(177, 30);
            this.btnImpEXCEL.TabIndex = 45;
            this.btnImpEXCEL.Text = "IMPORTAR EXCEL";
            this.btnImpEXCEL.UseVisualStyleBackColor = false;
            // 
            // btnMenuExcel
            // 
            this.btnMenuExcel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenuExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExcel.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuExcel.ForeColor = System.Drawing.Color.White;
            this.btnMenuExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuExcel.Image")));
            this.btnMenuExcel.Location = new System.Drawing.Point(342, 431);
            this.btnMenuExcel.Name = "btnMenuExcel";
            this.btnMenuExcel.Size = new System.Drawing.Size(181, 94);
            this.btnMenuExcel.TabIndex = 49;
            this.btnMenuExcel.UseVisualStyleBackColor = false;
            this.btnMenuExcel.Click += new System.EventHandler(this.btnMenuExcel_Click);
            // 
            // panelMenuJSON
            // 
            this.panelMenuJSON.Controls.Add(this.btnListarJSON);
            this.panelMenuJSON.Controls.Add(this.btnGenJSON);
            this.panelMenuJSON.Controls.Add(this.btnImpJSON);
            this.panelMenuJSON.Location = new System.Drawing.Point(344, 322);
            this.panelMenuJSON.Name = "panelMenuJSON";
            this.panelMenuJSON.Size = new System.Drawing.Size(180, 92);
            this.panelMenuJSON.TabIndex = 48;
            // 
            // btnListarJSON
            // 
            this.btnListarJSON.BackColor = System.Drawing.Color.White;
            this.btnListarJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListarJSON.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnListarJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJSON.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnListarJSON.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnListarJSON.Location = new System.Drawing.Point(2, 60);
            this.btnListarJSON.Name = "btnListarJSON";
            this.btnListarJSON.Size = new System.Drawing.Size(177, 30);
            this.btnListarJSON.TabIndex = 47;
            this.btnListarJSON.Text = "LISTAR JSON";
            this.btnListarJSON.UseVisualStyleBackColor = false;
            // 
            // btnGenJSON
            // 
            this.btnGenJSON.BackColor = System.Drawing.Color.White;
            this.btnGenJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenJSON.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGenJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenJSON.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGenJSON.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenJSON.Location = new System.Drawing.Point(2, 30);
            this.btnGenJSON.Name = "btnGenJSON";
            this.btnGenJSON.Size = new System.Drawing.Size(177, 30);
            this.btnGenJSON.TabIndex = 46;
            this.btnGenJSON.Text = "GENERAR JSON";
            this.btnGenJSON.UseVisualStyleBackColor = false;
            // 
            // btnImpJSON
            // 
            this.btnImpJSON.BackColor = System.Drawing.Color.White;
            this.btnImpJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImpJSON.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnImpJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImpJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpJSON.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImpJSON.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImpJSON.Location = new System.Drawing.Point(2, 0);
            this.btnImpJSON.Name = "btnImpJSON";
            this.btnImpJSON.Size = new System.Drawing.Size(177, 30);
            this.btnImpJSON.TabIndex = 45;
            this.btnImpJSON.Text = "IMPORTAR JSON";
            this.btnImpJSON.UseVisualStyleBackColor = false;
            // 
            // btnMenuJSON
            // 
            this.btnMenuJSON.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenuJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuJSON.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuJSON.ForeColor = System.Drawing.Color.White;
            this.btnMenuJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuJSON.Image")));
            this.btnMenuJSON.Location = new System.Drawing.Point(344, 229);
            this.btnMenuJSON.Name = "btnMenuJSON";
            this.btnMenuJSON.Size = new System.Drawing.Size(181, 94);
            this.btnMenuJSON.TabIndex = 47;
            this.btnMenuJSON.UseVisualStyleBackColor = false;
            this.btnMenuJSON.Click += new System.EventHandler(this.btnMenuJSON_Click);
            // 
            // panelMenuXml
            // 
            this.panelMenuXml.Controls.Add(this.btnListarXML);
            this.panelMenuXml.Controls.Add(this.btnGenXML);
            this.panelMenuXml.Controls.Add(this.btnImpXML);
            this.panelMenuXml.Location = new System.Drawing.Point(344, 116);
            this.panelMenuXml.Name = "panelMenuXml";
            this.panelMenuXml.Size = new System.Drawing.Size(180, 92);
            this.panelMenuXml.TabIndex = 46;
            // 
            // btnListarXML
            // 
            this.btnListarXML.BackColor = System.Drawing.Color.White;
            this.btnListarXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListarXML.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnListarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarXML.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnListarXML.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnListarXML.Location = new System.Drawing.Point(2, 60);
            this.btnListarXML.Name = "btnListarXML";
            this.btnListarXML.Size = new System.Drawing.Size(177, 30);
            this.btnListarXML.TabIndex = 47;
            this.btnListarXML.Text = "LISTAR XML";
            this.btnListarXML.UseVisualStyleBackColor = false;
            // 
            // btnGenXML
            // 
            this.btnGenXML.BackColor = System.Drawing.Color.White;
            this.btnGenXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenXML.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGenXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenXML.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGenXML.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenXML.Location = new System.Drawing.Point(2, 30);
            this.btnGenXML.Name = "btnGenXML";
            this.btnGenXML.Size = new System.Drawing.Size(177, 30);
            this.btnGenXML.TabIndex = 46;
            this.btnGenXML.Text = "GENERAR XML";
            this.btnGenXML.UseVisualStyleBackColor = false;
            // 
            // btnImpXML
            // 
            this.btnImpXML.BackColor = System.Drawing.Color.White;
            this.btnImpXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImpXML.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnImpXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImpXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpXML.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImpXML.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImpXML.Location = new System.Drawing.Point(2, 0);
            this.btnImpXML.Name = "btnImpXML";
            this.btnImpXML.Size = new System.Drawing.Size(177, 30);
            this.btnImpXML.TabIndex = 45;
            this.btnImpXML.Text = "IMPORTAR XML";
            this.btnImpXML.UseVisualStyleBackColor = false;
            // 
            // btnMenuXml
            // 
            this.btnMenuXml.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenuXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuXml.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuXml.ForeColor = System.Drawing.Color.White;
            this.btnMenuXml.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuXml.Image")));
            this.btnMenuXml.Location = new System.Drawing.Point(344, 23);
            this.btnMenuXml.Name = "btnMenuXml";
            this.btnMenuXml.Size = new System.Drawing.Size(181, 94);
            this.btnMenuXml.TabIndex = 1;
            this.btnMenuXml.UseVisualStyleBackColor = false;
            this.btnMenuXml.Click += new System.EventHandler(this.btnMenuXml_Click);
            // 
            // dgvAlmacenes
            // 
            this.dgvAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacenes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlmacenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Reem Kufi", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlmacenes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlmacenes.Enabled = false;
            this.dgvAlmacenes.Location = new System.Drawing.Point(539, 88);
            this.dgvAlmacenes.Name = "dgvAlmacenes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlmacenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlmacenes.Size = new System.Drawing.Size(838, 522);
            this.dgvAlmacenes.TabIndex = 42;
            // 
            // imgLimpiar
            // 
            this.imgLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("imgLimpiar.Image")));
            this.imgLimpiar.Location = new System.Drawing.Point(1233, 39);
            this.imgLimpiar.Name = "imgLimpiar";
            this.imgLimpiar.Size = new System.Drawing.Size(39, 31);
            this.imgLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLimpiar.TabIndex = 41;
            this.imgLimpiar.TabStop = false;
            this.imgLimpiar.Click += new System.EventHandler(this.imgLimpiar_Click);
            this.imgLimpiar.MouseLeave += new System.EventHandler(this.imgLimpiar_MouseLeave);
            this.imgLimpiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgLimpiar_MouseMove);
            // 
            // txtFiltroA
            // 
            this.txtFiltroA.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroA.Location = new System.Drawing.Point(947, 39);
            this.txtFiltroA.Multiline = true;
            this.txtFiltroA.Name = "txtFiltroA";
            this.txtFiltroA.Size = new System.Drawing.Size(269, 31);
            this.txtFiltroA.TabIndex = 40;
            this.txtFiltroA.TextChanged += new System.EventHandler(this.txtFiltroA_TextChanged);
            // 
            // cbDatosA
            // 
            this.cbDatosA.BackColor = System.Drawing.Color.White;
            this.cbDatosA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDatosA.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.cbDatosA.FormattingEnabled = true;
            this.cbDatosA.Location = new System.Drawing.Point(633, 39);
            this.cbDatosA.Name = "cbDatosA";
            this.cbDatosA.Size = new System.Drawing.Size(289, 31);
            this.cbDatosA.TabIndex = 39;
            // 
            // lbBuscarA
            // 
            this.lbBuscarA.AutoSize = true;
            this.lbBuscarA.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbBuscarA.Location = new System.Drawing.Point(552, 42);
            this.lbBuscarA.Name = "lbBuscarA";
            this.lbBuscarA.Size = new System.Drawing.Size(75, 23);
            this.lbBuscarA.TabIndex = 38;
            this.lbBuscarA.Text = "Buscar por: ";
            // 
            // barra4
            // 
            this.barra4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barra4.Location = new System.Drawing.Point(530, 23);
            this.barra4.Name = "barra4";
            this.barra4.Size = new System.Drawing.Size(3, 590);
            this.barra4.TabIndex = 17;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIzquierdo.Controls.Add(this.panelAñadirAlmacen);
            this.panelIzquierdo.Location = new System.Drawing.Point(8, 20);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(321, 507);
            this.panelIzquierdo.TabIndex = 16;
            // 
            // panelAñadirAlmacen
            // 
            this.panelAñadirAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAñadirAlmacen.Controls.Add(this.lbErrorEstado);
            this.panelAñadirAlmacen.Controls.Add(this.richTextBox1);
            this.panelAñadirAlmacen.Controls.Add(this.btnAceptarAAdd);
            this.panelAñadirAlmacen.Controls.Add(this.cbAct2);
            this.panelAñadirAlmacen.Controls.Add(this.cbAct1);
            this.panelAñadirAlmacen.Controls.Add(this.textBox1);
            this.panelAñadirAlmacen.Controls.Add(this.lbErrorNom);
            this.panelAñadirAlmacen.Controls.Add(this.txtNombre);
            this.panelAñadirAlmacen.Controls.Add(this.lbNombre);
            this.panelAñadirAlmacen.Location = new System.Drawing.Point(9, 12);
            this.panelAñadirAlmacen.Name = "panelAñadirAlmacen";
            this.panelAñadirAlmacen.Size = new System.Drawing.Size(302, 480);
            this.panelAñadirAlmacen.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Reem Kufi", 9.7F);
            this.richTextBox1.Location = new System.Drawing.Point(13, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 139);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = "Una vez dado de alta el almacén, no se podrá modificar el ID del mismo.\n\nTampoco " +
    "se podrá eliminar a menos que tenga permisos de administrador.";
            // 
            // btnAceptarAAdd
            // 
            this.btnAceptarAAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptarAAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptarAAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptarAAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAAdd.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptarAAdd.ForeColor = System.Drawing.Color.White;
            this.btnAceptarAAdd.Location = new System.Drawing.Point(10, 433);
            this.btnAceptarAAdd.Name = "btnAceptarAAdd";
            this.btnAceptarAAdd.Size = new System.Drawing.Size(277, 30);
            this.btnAceptarAAdd.TabIndex = 44;
            this.btnAceptarAAdd.Text = "ACEPTAR";
            this.btnAceptarAAdd.UseVisualStyleBackColor = false;
            this.btnAceptarAAdd.Click += new System.EventHandler(this.btnAceptarAAdd_Click);
            this.btnAceptarAAdd.MouseLeave += new System.EventHandler(this.btnAceptarAAdd_MouseLeave);
            this.btnAceptarAAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAceptarAAdd_MouseMove);
            // 
            // cbAct2
            // 
            this.cbAct2.AutoSize = true;
            this.cbAct2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.cbAct2.Location = new System.Drawing.Point(154, 187);
            this.cbAct2.Name = "cbAct2";
            this.cbAct2.Size = new System.Drawing.Size(88, 32);
            this.cbAct2.TabIndex = 43;
            this.cbAct2.Text = "Inactivo";
            this.cbAct2.UseVisualStyleBackColor = true;
            this.cbAct2.CheckedChanged += new System.EventHandler(this.cbAct2_CheckedChanged);
            // 
            // cbAct1
            // 
            this.cbAct1.AutoSize = true;
            this.cbAct1.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.cbAct1.Location = new System.Drawing.Point(57, 187);
            this.cbAct1.Name = "cbAct1";
            this.cbAct1.Size = new System.Drawing.Size(76, 32);
            this.cbAct1.TabIndex = 42;
            this.cbAct1.Text = "Activo";
            this.cbAct1.UseVisualStyleBackColor = true;
            this.cbAct1.CheckedChanged += new System.EventHandler(this.cbAct1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(10, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 33);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "ID Autogenerado";
            // 
            // lbErrorNom
            // 
            this.lbErrorNom.AutoSize = true;
            this.lbErrorNom.BackColor = System.Drawing.Color.White;
            this.lbErrorNom.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorNom.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNom.Location = new System.Drawing.Point(9, 132);
            this.lbErrorNom.Name = "lbErrorNom";
            this.lbErrorNom.Size = new System.Drawing.Size(41, 23);
            this.lbErrorNom.TabIndex = 40;
            this.lbErrorNom.Text = "Error";
            this.lbErrorNom.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(10, 82);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 33);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(10, 107);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(273, 13);
            this.lbNombre.TabIndex = 38;
            this.lbNombre.Text = "______________________________________";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(234, 546);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 64);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(124, 546);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 64);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(17, 546);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(85, 64);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            this.btnAñadir.MouseLeave += new System.EventHandler(this.btnAñadir_MouseLeave);
            this.btnAñadir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAñadir_MouseMove);
            // 
            // barra3
            // 
            this.barra3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barra3.Location = new System.Drawing.Point(335, 20);
            this.barra3.Name = "barra3";
            this.barra3.Size = new System.Drawing.Size(3, 590);
            this.barra3.TabIndex = 12;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // lbErrorEstado
            // 
            this.lbErrorEstado.AutoSize = true;
            this.lbErrorEstado.BackColor = System.Drawing.Color.White;
            this.lbErrorEstado.Font = new System.Drawing.Font("Reem Kufi", 9.749999F);
            this.lbErrorEstado.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEstado.Location = new System.Drawing.Point(9, 232);
            this.lbErrorEstado.Name = "lbErrorEstado";
            this.lbErrorEstado.Size = new System.Drawing.Size(41, 23);
            this.lbErrorEstado.TabIndex = 46;
            this.lbErrorEstado.Text = "Error";
            this.lbErrorEstado.Visible = false;
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1505, 862);
            this.Controls.Add(this.panelAlmacenes);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.lbInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlmacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlmacenes";
            this.panelAlmacenes.ResumeLayout(false);
            this.panelAlmacenes.PerformLayout();
            this.panelMenuExcel.ResumeLayout(false);
            this.panelMenuJSON.ResumeLayout(false);
            this.panelMenuXml.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimpiar)).EndInit();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelAñadirAlmacen.ResumeLayout(false);
            this.panelAñadirAlmacen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Panel barra1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Panel panelAlmacenes;
        private System.Windows.Forms.Panel barra3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelAñadirAlmacen;
        private System.Windows.Forms.Label lbErrorNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbAct2;
        private System.Windows.Forms.CheckBox cbAct1;
        private System.Windows.Forms.Button btnAceptarAAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel barra4;
        private System.Windows.Forms.PictureBox imgLimpiar;
        private System.Windows.Forms.TextBox txtFiltroA;
        private System.Windows.Forms.ComboBox cbDatosA;
        private System.Windows.Forms.Label lbBuscarA;
        private System.Windows.Forms.Panel panelMenuXml;
        private System.Windows.Forms.Button btnMenuXml;
        private System.Windows.Forms.DataGridView dgvAlmacenes;
        private System.Windows.Forms.Button btnGenXML;
        private System.Windows.Forms.Button btnImpXML;
        private System.Windows.Forms.Panel panelMenuJSON;
        private System.Windows.Forms.Button btnListarJSON;
        private System.Windows.Forms.Button btnGenJSON;
        private System.Windows.Forms.Button btnImpJSON;
        private System.Windows.Forms.Button btnMenuJSON;
        private System.Windows.Forms.Button btnListarXML;
        private System.Windows.Forms.Panel panelMenuExcel;
        private System.Windows.Forms.Button btnListarEXCEL;
        private System.Windows.Forms.Button btnGenEXCEL;
        private System.Windows.Forms.Button btnImpEXCEL;
        private System.Windows.Forms.Button btnMenuExcel;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lbErrorEstado;
    }
}