﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Formularios
{
    public partial class FormCarga : Form
    {
        string user;
        FormInicio login;

        public FormCarga(FormInicio formInicio, string usuario)
        {
            InitializeComponent();

            login = formInicio;
            user = usuario;

            aparece.Start();
        }

        private void aparece_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.02;
            }

            barra.Value += 1;
            
            if(barra.Value == 100)
            {
                aparece.Stop();
                this.Visible = false;

                FormMenu form = new FormMenu(this, user);
                form.Show();
            }
        }

        private void desaparece_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                desaparece.Stop();
                this.Close();
            }
        }
    }
}
