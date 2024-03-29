﻿using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Validacoes;
using SisCaixaEstoque.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios
{
    public partial class FrmCadastroCliente : FrmCadastroBase
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                string ssxRetorno = BncValidacoesCadastros.ValidarCliente(TbxNomeCompleto.Text, TbxCpfCnpj.Text);
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarCliente(
                        TbxNomeCompleto.Text,
                        TbxCpfCnpj.Text,
                        TbxEndereco.Text,
                        TbxCidade.Text,
                        TbxEstado.Text,
                        TbxEmail.Text,
                        TbxTelefone.Text,
                        TbxCelular.Text,
                        TbxWhats.Text);

                    TbxNomeCompleto.Text = "";
                    TbxCpfCnpj.Text = "";
                    TbxEndereco.Text = "";
                    TbxCidade.Text = "";
                    TbxEstado.Text = "";
                    TbxEmail.Text = "";
                    TbxTelefone.Text = "";
                    TbxCelular.Text = "";
                    TbxWhats.Text = "";
                }
                else
                {
                    MessageBox.Show(ssxRetorno);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
