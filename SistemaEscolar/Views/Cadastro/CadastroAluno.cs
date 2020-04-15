using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
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
            btnCancelar.Enabled = true;
            txtNomeAluno.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroAluno_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        #region Limpa os TextBoxes
        private void CleanForm()
        {
            traverseControlsAndSetTextEmpty(this);
        }
        private void traverseControlsAndSetTextEmpty(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = string.Empty;
                if (c is MaskedTextBox) ((MaskedTextBox)c).Text = string.Empty;
                traverseControlsAndSetTextEmpty(c);
            }
        }

        #endregion
    }
}
