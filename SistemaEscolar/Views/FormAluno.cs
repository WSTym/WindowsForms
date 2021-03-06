﻿using SistemaEscolar.Services;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNomeAluno.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errAluno.Clear();
            Aluno_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Services.Services.CheckEmptyField(txtNomeAluno, errAluno)) return;
            if (Services.Services.CheckEmptyField(txtDataNascAluno, errAluno)) return;
            if (Services.Services.CheckEmptyField(txtEnderecoAluno, errAluno)) return;
            if (Services.Services.CheckEmptyField(txtTelefoneAluno, errAluno)) return;

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
            Services.Services.SetTextEmpty(this);
        }

        #endregion

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
