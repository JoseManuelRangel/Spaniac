namespace Spaniac.Formularios
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbErrorDNI = new System.Windows.Forms.Label();
            this.lbErrorNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbErrorAp1 = new System.Windows.Forms.Label();
            this.txtAp1 = new System.Windows.Forms.TextBox();
            this.lbAp1 = new System.Windows.Forms.Label();
            this.lbErrorAp2 = new System.Windows.Forms.Label();
            this.txtAp2 = new System.Windows.Forms.TextBox();
            this.lbAp2 = new System.Windows.Forms.Label();
            this.lbErrorUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbErrorClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbErrorConfirma = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.lbConfirma = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lbErrorRol = new System.Windows.Forms.Label();
            this.lbErrorEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.lbErrorImg = new System.Windows.Forms.Label();
            this.btnCargaImg = new System.Windows.Forms.Button();
            this.btnQuitaImg = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgMuestra1 = new System.Windows.Forms.PictureBox();
            this.imgMuestra2 = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIzquierdo.BackgroundImage")));
            this.panelIzquierdo.Controls.Add(this.logoEmpresa);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(117, 706);
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
            this.logoEmpresa.TabIndex = 0;
            this.logoEmpresa.TabStop = false;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Reem Kufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(134, 9);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(416, 67);
            this.lbInicio.TabIndex = 0;
            this.lbInicio.Text = "REGISTRAR USUARIO";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDNI.Location = new System.Drawing.Point(155, 107);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(357, 33);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.Text = "DNI";
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.Enter += new System.EventHandler(this.txtDNI_Enter);
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(151, 132);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(364, 13);
            this.lbDNI.TabIndex = 4;
            this.lbDNI.Text = "___________________________________________________";
            // 
            // lbErrorDNI
            // 
            this.lbErrorDNI.AutoSize = true;
            this.lbErrorDNI.BackColor = System.Drawing.Color.White;
            this.lbErrorDNI.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorDNI.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDNI.Location = new System.Drawing.Point(151, 150);
            this.lbErrorDNI.Name = "lbErrorDNI";
            this.lbErrorDNI.Size = new System.Drawing.Size(41, 23);
            this.lbErrorDNI.TabIndex = 13;
            this.lbErrorDNI.Text = "Error";
            this.lbErrorDNI.Visible = false;
            // 
            // lbErrorNombre
            // 
            this.lbErrorNombre.AutoSize = true;
            this.lbErrorNombre.BackColor = System.Drawing.Color.White;
            this.lbErrorNombre.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombre.Location = new System.Drawing.Point(151, 236);
            this.lbErrorNombre.Name = "lbErrorNombre";
            this.lbErrorNombre.Size = new System.Drawing.Size(41, 23);
            this.lbErrorNombre.TabIndex = 16;
            this.lbErrorNombre.Text = "Error";
            this.lbErrorNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(155, 193);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 33);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(151, 218);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(364, 13);
            this.lbNombre.TabIndex = 14;
            this.lbNombre.Text = "___________________________________________________";
            // 
            // lbErrorAp1
            // 
            this.lbErrorAp1.AutoSize = true;
            this.lbErrorAp1.BackColor = System.Drawing.Color.White;
            this.lbErrorAp1.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorAp1.ForeColor = System.Drawing.Color.Red;
            this.lbErrorAp1.Location = new System.Drawing.Point(151, 322);
            this.lbErrorAp1.Name = "lbErrorAp1";
            this.lbErrorAp1.Size = new System.Drawing.Size(41, 23);
            this.lbErrorAp1.TabIndex = 19;
            this.lbErrorAp1.Text = "Error";
            this.lbErrorAp1.Visible = false;
            // 
            // txtAp1
            // 
            this.txtAp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAp1.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAp1.Location = new System.Drawing.Point(155, 279);
            this.txtAp1.Multiline = true;
            this.txtAp1.Name = "txtAp1";
            this.txtAp1.Size = new System.Drawing.Size(150, 32);
            this.txtAp1.TabIndex = 18;
            this.txtAp1.Text = "Apellido 1";
            this.txtAp1.TextChanged += new System.EventHandler(this.txtAp1_TextChanged);
            this.txtAp1.Enter += new System.EventHandler(this.txtAp1_Enter);
            this.txtAp1.Leave += new System.EventHandler(this.txtAp1_Leave);
            // 
            // lbAp1
            // 
            this.lbAp1.AutoSize = true;
            this.lbAp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAp1.Location = new System.Drawing.Point(151, 304);
            this.lbAp1.Name = "lbAp1";
            this.lbAp1.Size = new System.Drawing.Size(161, 13);
            this.lbAp1.TabIndex = 17;
            this.lbAp1.Text = "______________________";
            // 
            // lbErrorAp2
            // 
            this.lbErrorAp2.AutoSize = true;
            this.lbErrorAp2.BackColor = System.Drawing.Color.White;
            this.lbErrorAp2.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorAp2.ForeColor = System.Drawing.Color.Red;
            this.lbErrorAp2.Location = new System.Drawing.Point(358, 322);
            this.lbErrorAp2.Name = "lbErrorAp2";
            this.lbErrorAp2.Size = new System.Drawing.Size(41, 23);
            this.lbErrorAp2.TabIndex = 22;
            this.lbErrorAp2.Text = "Error";
            this.lbErrorAp2.Visible = false;
            // 
            // txtAp2
            // 
            this.txtAp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAp2.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAp2.Location = new System.Drawing.Point(362, 279);
            this.txtAp2.Multiline = true;
            this.txtAp2.Name = "txtAp2";
            this.txtAp2.Size = new System.Drawing.Size(150, 32);
            this.txtAp2.TabIndex = 21;
            this.txtAp2.Text = "Apellido 2";
            this.txtAp2.TextChanged += new System.EventHandler(this.txtAp2_TextChanged);
            this.txtAp2.Enter += new System.EventHandler(this.txtAp2_Enter);
            this.txtAp2.Leave += new System.EventHandler(this.txtAp2_Leave);
            // 
            // lbAp2
            // 
            this.lbAp2.AutoSize = true;
            this.lbAp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAp2.Location = new System.Drawing.Point(358, 304);
            this.lbAp2.Name = "lbAp2";
            this.lbAp2.Size = new System.Drawing.Size(154, 13);
            this.lbAp2.TabIndex = 20;
            this.lbAp2.Text = "_____________________";
            // 
            // lbErrorUsuario
            // 
            this.lbErrorUsuario.AutoSize = true;
            this.lbErrorUsuario.BackColor = System.Drawing.Color.White;
            this.lbErrorUsuario.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUsuario.Location = new System.Drawing.Point(151, 410);
            this.lbErrorUsuario.Name = "lbErrorUsuario";
            this.lbErrorUsuario.Size = new System.Drawing.Size(41, 23);
            this.lbErrorUsuario.TabIndex = 25;
            this.lbErrorUsuario.Text = "Error";
            this.lbErrorUsuario.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(155, 367);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(357, 32);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(151, 392);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(364, 13);
            this.lbUsuario.TabIndex = 23;
            this.lbUsuario.Text = "___________________________________________________";
            // 
            // lbErrorClave
            // 
            this.lbErrorClave.AutoSize = true;
            this.lbErrorClave.BackColor = System.Drawing.Color.White;
            this.lbErrorClave.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorClave.ForeColor = System.Drawing.Color.Red;
            this.lbErrorClave.Location = new System.Drawing.Point(150, 500);
            this.lbErrorClave.Name = "lbErrorClave";
            this.lbErrorClave.Size = new System.Drawing.Size(40, 22);
            this.lbErrorClave.TabIndex = 28;
            this.lbErrorClave.Text = "Error";
            this.lbErrorClave.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.Location = new System.Drawing.Point(154, 457);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(361, 24);
            this.txtClave.TabIndex = 27;
            this.txtClave.Text = "Contraseña";
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.Location = new System.Drawing.Point(150, 482);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(364, 13);
            this.lbClave.TabIndex = 26;
            this.lbClave.Text = "___________________________________________________";
            // 
            // lbErrorConfirma
            // 
            this.lbErrorConfirma.AutoSize = true;
            this.lbErrorConfirma.BackColor = System.Drawing.Color.White;
            this.lbErrorConfirma.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorConfirma.ForeColor = System.Drawing.Color.Red;
            this.lbErrorConfirma.Location = new System.Drawing.Point(151, 588);
            this.lbErrorConfirma.Name = "lbErrorConfirma";
            this.lbErrorConfirma.Size = new System.Drawing.Size(41, 23);
            this.lbErrorConfirma.TabIndex = 31;
            this.lbErrorConfirma.Text = "Error";
            this.lbErrorConfirma.Visible = false;
            // 
            // txtConfirma
            // 
            this.txtConfirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirma.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConfirma.Location = new System.Drawing.Point(155, 545);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(361, 24);
            this.txtConfirma.TabIndex = 30;
            this.txtConfirma.Text = "Confirmar contraseña";
            this.txtConfirma.TextChanged += new System.EventHandler(this.txtConfirma_TextChanged);
            this.txtConfirma.Enter += new System.EventHandler(this.txtConfirma_Enter);
            this.txtConfirma.Leave += new System.EventHandler(this.txtConfirma_Leave);
            // 
            // lbConfirma
            // 
            this.lbConfirma.AutoSize = true;
            this.lbConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirma.Location = new System.Drawing.Point(151, 570);
            this.lbConfirma.Name = "lbConfirma";
            this.lbConfirma.Size = new System.Drawing.Size(364, 13);
            this.lbConfirma.TabIndex = 29;
            this.lbConfirma.Text = "___________________________________________________";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.White;
            this.cbRol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRol.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Empleado"});
            this.cbRol.Location = new System.Drawing.Point(619, 104);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(321, 36);
            this.cbRol.TabIndex = 32;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // lbErrorRol
            // 
            this.lbErrorRol.AutoSize = true;
            this.lbErrorRol.BackColor = System.Drawing.Color.White;
            this.lbErrorRol.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorRol.ForeColor = System.Drawing.Color.Red;
            this.lbErrorRol.Location = new System.Drawing.Point(615, 150);
            this.lbErrorRol.Name = "lbErrorRol";
            this.lbErrorRol.Size = new System.Drawing.Size(41, 23);
            this.lbErrorRol.TabIndex = 33;
            this.lbErrorRol.Text = "Error";
            this.lbErrorRol.Visible = false;
            // 
            // lbErrorEmail
            // 
            this.lbErrorEmail.AutoSize = true;
            this.lbErrorEmail.BackColor = System.Drawing.Color.White;
            this.lbErrorEmail.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEmail.Location = new System.Drawing.Point(615, 236);
            this.lbErrorEmail.Name = "lbErrorEmail";
            this.lbErrorEmail.Size = new System.Drawing.Size(41, 23);
            this.lbErrorEmail.TabIndex = 36;
            this.lbErrorEmail.Text = "Error";
            this.lbErrorEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(619, 193);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 32);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.Text = "ejemplo123";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(615, 218);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(154, 13);
            this.lbEmail.TabIndex = 34;
            this.lbEmail.Text = "_____________________";
            // 
            // cbEmail
            // 
            this.cbEmail.BackColor = System.Drawing.Color.White;
            this.cbEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEmail.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Items.AddRange(new object[] {
            "",
            "@hotmail.es",
            "@hotmail.com",
            "@outlook.com",
            "@outlook.es",
            "@gmail.com"});
            this.cbEmail.Location = new System.Drawing.Point(775, 195);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(165, 36);
            this.cbEmail.TabIndex = 37;
            // 
            // imgPerfil
            // 
            this.imgPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgPerfil.Location = new System.Drawing.Point(618, 279);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(322, 212);
            this.imgPerfil.TabIndex = 38;
            this.imgPerfil.TabStop = false;
            // 
            // lbErrorImg
            // 
            this.lbErrorImg.AutoSize = true;
            this.lbErrorImg.BackColor = System.Drawing.Color.White;
            this.lbErrorImg.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorImg.ForeColor = System.Drawing.Color.Red;
            this.lbErrorImg.Location = new System.Drawing.Point(615, 559);
            this.lbErrorImg.Name = "lbErrorImg";
            this.lbErrorImg.Size = new System.Drawing.Size(41, 23);
            this.lbErrorImg.TabIndex = 39;
            this.lbErrorImg.Text = "Error";
            this.lbErrorImg.Visible = false;
            // 
            // btnCargaImg
            // 
            this.btnCargaImg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCargaImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargaImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCargaImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaImg.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaImg.ForeColor = System.Drawing.Color.White;
            this.btnCargaImg.Location = new System.Drawing.Point(618, 500);
            this.btnCargaImg.Name = "btnCargaImg";
            this.btnCargaImg.Size = new System.Drawing.Size(159, 40);
            this.btnCargaImg.TabIndex = 40;
            this.btnCargaImg.Text = "CARGAR";
            this.btnCargaImg.UseVisualStyleBackColor = false;
            this.btnCargaImg.Click += new System.EventHandler(this.btnCargaImg_Click);
            this.btnCargaImg.MouseLeave += new System.EventHandler(this.btnCargaImg_MouseLeave);
            this.btnCargaImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCargaImg_MouseMove);
            // 
            // btnQuitaImg
            // 
            this.btnQuitaImg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnQuitaImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitaImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuitaImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitaImg.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitaImg.ForeColor = System.Drawing.Color.White;
            this.btnQuitaImg.Location = new System.Drawing.Point(781, 500);
            this.btnQuitaImg.Name = "btnQuitaImg";
            this.btnQuitaImg.Size = new System.Drawing.Size(159, 40);
            this.btnQuitaImg.TabIndex = 41;
            this.btnQuitaImg.Text = "QUITAR";
            this.btnQuitaImg.UseVisualStyleBackColor = false;
            this.btnQuitaImg.Click += new System.EventHandler(this.btnQuitaImg_Click);
            this.btnQuitaImg.MouseLeave += new System.EventHandler(this.btnQuitaImg_MouseLeave);
            this.btnQuitaImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnQuitaImg_MouseMove);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Reem Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(153, 634);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(428, 60);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "REGISTRARSE";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            this.btnRegistrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistrar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Reem Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(587, 634);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(423, 60);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // imgMuestra1
            // 
            this.imgMuestra1.Image = ((System.Drawing.Image)(resources.GetObject("imgMuestra1.Image")));
            this.imgMuestra1.Location = new System.Drawing.Point(549, 457);
            this.imgMuestra1.Name = "imgMuestra1";
            this.imgMuestra1.Size = new System.Drawing.Size(32, 30);
            this.imgMuestra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMuestra1.TabIndex = 44;
            this.imgMuestra1.TabStop = false;
            this.imgMuestra1.Click += new System.EventHandler(this.imgMuestra1_Click);
            this.imgMuestra1.MouseLeave += new System.EventHandler(this.imgMuestra1_MouseLeave);
            this.imgMuestra1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMuestra1_MouseMove);
            // 
            // imgMuestra2
            // 
            this.imgMuestra2.Image = ((System.Drawing.Image)(resources.GetObject("imgMuestra2.Image")));
            this.imgMuestra2.Location = new System.Drawing.Point(549, 545);
            this.imgMuestra2.Name = "imgMuestra2";
            this.imgMuestra2.Size = new System.Drawing.Size(32, 30);
            this.imgMuestra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMuestra2.TabIndex = 45;
            this.imgMuestra2.TabStop = false;
            this.imgMuestra2.Click += new System.EventHandler(this.imgMuestra2_Click);
            this.imgMuestra2.MouseLeave += new System.EventHandler(this.imgMuestra2_MouseLeave);
            this.imgMuestra2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMuestra2_MouseMove);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 706);
            this.Controls.Add(this.imgMuestra2);
            this.Controls.Add(this.imgMuestra1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnQuitaImg);
            this.Controls.Add(this.btnCargaImg);
            this.Controls.Add(this.lbErrorImg);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.lbErrorEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbErrorRol);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lbErrorConfirma);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.lbConfirma);
            this.Controls.Add(this.lbErrorClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.lbErrorUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbErrorAp2);
            this.Controls.Add(this.txtAp2);
            this.Controls.Add(this.lbAp2);
            this.Controls.Add(this.lbErrorAp1);
            this.Controls.Add(this.txtAp1);
            this.Controls.Add(this.lbAp1);
            this.Controls.Add(this.lbErrorNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbErrorDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestra2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbErrorDNI;
        private System.Windows.Forms.Label lbErrorNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbErrorAp1;
        private System.Windows.Forms.TextBox txtAp1;
        private System.Windows.Forms.Label lbAp1;
        private System.Windows.Forms.Label lbErrorAp2;
        private System.Windows.Forms.TextBox txtAp2;
        private System.Windows.Forms.Label lbAp2;
        private System.Windows.Forms.Label lbErrorUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbErrorClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbErrorConfirma;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label lbConfirma;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lbErrorRol;
        private System.Windows.Forms.Label lbErrorEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Label lbErrorImg;
        private System.Windows.Forms.Button btnCargaImg;
        private System.Windows.Forms.Button btnQuitaImg;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox imgMuestra1;
        private System.Windows.Forms.PictureBox imgMuestra2;
    }
}