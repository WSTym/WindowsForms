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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
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
            btnCancelar.Enabled = true;
            txtNomeProfessor.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroProfessor_Load(new object(), new EventArgs());
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
