using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaEscolar.Views.Cadastro
{
    public partial class CadastroCurso : Form
    {
        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void CadastroCurso_Load(object sender, EventArgs e)
        {
            pnlCadCurso.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadCurso.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNomeCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroCurso_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeCurso, errCurso)) return;
            if (FormHelper.CheckEmptyField(txtCargaHoraria, errCurso)) return;
            using (Context context = new Context())
            {
                context.Cursos.Add(new Curso()
                {
                    Nome = txtNomeCurso.Text,
                    CargaHoaria = int.Parse(txtCargaHoraria.Text)
                });
            }
        }
        #region Limpa os TextBoxes
        private void CleanForm()
        {
            FormHelper.SetTextEmpty(this);
        }

        #endregion

        private void txtCargaHoraria_TextChanged(object sender, EventArgs e)
        {
            txtCargaHoraria.Text = Regex.Replace(txtCargaHoraria.Text, "[^0-9]", "");
        }
    }
}
