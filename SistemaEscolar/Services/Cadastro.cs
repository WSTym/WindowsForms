using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Views;

namespace SistemaEscolar.Services
{
    public class Cadastro : ICadastro
    {
        public void Cadastrar(Panel panel, int tipo)
        {
            panel.Enabled = false;
        }
    }
}
