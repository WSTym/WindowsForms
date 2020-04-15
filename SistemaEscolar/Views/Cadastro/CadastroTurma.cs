using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        private void CadastroTurma_Load(object sender, EventArgs e)
        {
            pnlCadTurma.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadTurma.Enabled = true;
            btnCancelar.Enabled = true;
            txtCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroTurma_Load(new object(), new EventArgs());
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
                if (c is RadioButton) ((RadioButton)c).Checked = false;
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = -1;
                traverseControlsAndSetTextEmpty(c);
            }
        }

        #endregion
    }
}
