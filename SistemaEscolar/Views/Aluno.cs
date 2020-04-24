﻿using SistemaEscolar.Helper;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using SistemaEscolar.Views.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            pnlCadAluno.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadAluno.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNomeAluno.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errAluno.Clear();
            CadastroAluno_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeAluno, errAluno)) return;
            if (FormHelper.CheckEmptyField(txtDataNascAluno, errAluno)) return;
            if (FormHelper.CheckEmptyField(txtEnderecoAluno, errAluno)) return;
            if (FormHelper.CheckEmptyField(txtTelefoneAluno, errAluno)) return;

            using (Context context = new Context())
            {
                context.Alunos.Add(new Models.Aluno() { 
                    Nome = txtNomeAluno.Text,
                    DataNascimento = txtDataNascAluno.Text,
                    Edereco = txtEnderecoAluno.Text,
                    Telefone = txtTelefoneAluno.Text
                });
            }
        }

        #region Limpa os TextBoxes
        private void CleanForm()
        {
            FormHelper.SetTextEmpty(this);
        }
        
        #endregion
    }
}