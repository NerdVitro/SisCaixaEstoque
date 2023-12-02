﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios.Base
{
    public partial class FrmCadastroBase : FrmBaseVazio
    {
        public FrmCadastroBase()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }


        public virtual void Sair()
        {

        }

        public virtual void Salvar()
        {

        }
    }
}