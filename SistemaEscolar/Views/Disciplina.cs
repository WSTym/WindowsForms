using SistemaEscolar.Helper;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void CadastroDisciplina_Load(object sender, EventArgs e)
        {
            pnlCadDisciplina.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadDisciplina.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNomeDisciplina.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errDisciplina.Clear();
            CadastroDisciplina_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeDisciplina, errDisciplina)) return;
            if (FormHelper.CheckEmptyField(txtCargaHoraria, errDisciplina)) return;
            if (FormHelper.CheckEmptyField(txtAulasSemanais, errDisciplina)) return;

            using (Context context = new Context())
            {
                context.Disciplinas.Add(new Models.Disciplina()
                {
                    Nome = txtNomeDisciplina.Text,
                    CargaHoraria = int.Parse(txtCargaHoraria.Text),
                    AulasSemanais = int.Parse(txtAulasSemanais.Text)
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
