﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           Usuario user = new Usuario();
            user.Login = txbUsuario.Text;
            user.Senha = txbSenha.Text;

            if (user.Login=="Daniel" && user.Senha=="123")
                {
                frmPaginaInicial p = new frmPaginaInicial();
                p.Show();
                this.Close();
                }
                else
                {
                    MessageBox.Show ("Usuario ou Senha inválidos!!!");
                }
        }
    }
}
