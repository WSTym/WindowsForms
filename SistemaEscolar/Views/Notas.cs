using SistemaEscolar.Helper;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void CadastroNotas_Load(object sender, EventArgs e)
        {
            pnlCadNotas.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadNotas.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            cbTurma.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errNotas.Clear();
            CadastroNotas_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(cbTurma, errNotas)) return;
            if (FormHelper.CheckEmptyField(cbDisciplina, errNotas)) return;
            if (FormHelper.CheckEmptyField(cbAvaliacao, errNotas)) return;
            if (FormHelper.CheckEmptyField(cbAluno, errNotas)) return;
            if (FormHelper.CheckEmptyField(txtNotaAluno, errNotas)) return;


            using (Context context = new Context())
            {
                context.Notas.Add(new Nota()
                {
                    Valor = float.Parse(txtNotaAluno.Text),
                    Falta = chkFalta.Checked
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
