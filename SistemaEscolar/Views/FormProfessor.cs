using SistemaEscolar.Services;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = true;
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
            if (Services.Services.CheckEmptyField(txtNomeProfessor, errProfessor)) return;
            if (Services.Services.CheckEmptyField(txtDataNascProfessor, errProfessor)) return;
            if (Services.Services.CheckEmptyField(txtEnderecoProfessor, errProfessor)) return;
            if (Services.Services.CheckEmptyField(txtTelefoneProfessor, errProfessor)) return;
            if (Services.Services.CheckEmptyField(txtCapacitacao, errProfessor)) return;


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
            Services.Services.SetTextEmpty(this);
        }

        #endregion
    }
}
