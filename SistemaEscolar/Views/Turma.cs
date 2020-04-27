using SistemaEscolar.Helper;
using SistemaEscolar.Models.Context;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Turma : Form
    {
        public Turma()
        {
            InitializeComponent();
        }

        private void CadastroTurma_Load(object sender, EventArgs e)
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
            cbCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroTurma_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //if (FormHelper.CheckEmptyField(cbCurso, errTurma)) return;
            if (FormHelper.CheckEmptyField(txtAno, errTurma)) return;
            if (FormHelper.CheckEmptyField(rbSemestre1, errTurma)) return;
            if (FormHelper.CheckEmptyField(cbHorario, errTurma)) return;

            using (Context context = new Context())
            {
                context.Turmas.Add(new Models.Turma()
                {
                    //Curso = cbCurso.Text,
                    Ano = int.Parse(txtAno.Text),
                    Turno = cbHorario.Text
                });
            }
        }

        #region Limpa os TextBoxes
        private void CleanForm()
        {
            FormHelper.SetTextEmpty(this);
        }

        #endregion

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            txtAno.Text = Regex.Replace(txtAno.Text, "[^0-9]", "");
        }
    }
}
