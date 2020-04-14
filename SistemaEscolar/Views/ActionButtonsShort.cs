using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Services;

namespace SistemaEscolar
{
    public partial class ActionButtonsShort : UserControl
    {
        private readonly ICadastro _cadastro;
        public int TipoCadastro;
        public Panel panel;
        public ActionButtonsShort()
        {
            InitializeComponent();
        }

        private void ActionButtonsShort_Load(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            _cadastro.Cadastrar(panel, TipoCadastro);  
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActionButtonsShort_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ActionButtonsShort_Load(new object(), new EventArgs());

        }
    }
}
