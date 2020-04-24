using SistemaEscolar.Helper;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            pnlCadProfessor.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadProfessor.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNomeProfessor.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroProfessor_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeProfessor, errProfessor)) return;
            if (FormHelper.CheckEmptyField(txtDataNascProfessor, errProfessor)) return;
            if (FormHelper.CheckEmptyField(txtEnderecoProfessor, errProfessor)) return;
            if (FormHelper.CheckEmptyField(txtTelefoneProfessor, errProfessor)) return;
            if (FormHelper.CheckEmptyField(txtCapacitacao, errProfessor)) return;


            using (Context context = new Context())
            {
                context.Professores.Add(new Models.Professor()
                {
                    Nome = txtNomeProfessor.Text,
                    DataNascimento = txtDataNascProfessor.Text,
                    Edereco = txtEnderecoProfessor.Text,
                    Telefone = txtTelefoneProfessor.Text,
                    Capacitacao = txtCapacitacao.Text
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
