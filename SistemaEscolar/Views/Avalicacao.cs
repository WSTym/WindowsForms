using SistemaEscolar.Helper;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Avalicacao : Form
    {
        public Avalicacao()
        {
            InitializeComponent();
        }

        private void CadastroAvalicacao_Load(object sender, EventArgs e)
        {
            pnlCadAvaliacao.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadAvaliacao.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            cbDisciplina.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errAvaliacao.Clear();
            CadastroAvalicacao_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(cbDisciplina, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtTemaAvalicao, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtDataAvaliacao, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtValorAvaliacao, errAvaliacao)) return;

            using (Context context = new Context())
            {
                context.Avaliacoes.Add(new Avaliacao()
                {
                    //Disciplina = cbDisciplina.SelectedItem.ToString(),
                    Tema = txtTemaAvalicao.Text,
                    Data = txtDataAvaliacao.Text,
                    Valor = float.Parse(txtValorAvaliacao.Text)
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
