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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }
        
        private void actionButtonsShort1_Load(object sender, EventArgs e)
        {
            actionButtonsShort1.TipoCadastro = 0;
            actionButtonsShort1.panel = pnlCadAluno;
        }
    }
}
