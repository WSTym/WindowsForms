using SistemaEscolar.Views;
using SistemaEscolar.Views.Busca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //
        // Opções da barra de munus
        //
        private void menuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuCadastroAluno_Click(object sender, EventArgs e)
        {
            openForm(new CadastroAluno());
        }

        private void menuCadastroProfessor_Click(object sender, EventArgs e)
        {
            openForm(new CadastroProfessor());
        }

        private void menuCadastroTurma_Click(object sender, EventArgs e)
        {
            openForm(new CadastroTurma());
        }

        private void menuBuscaAluno_Click(object sender, EventArgs e)
        {
            openForm(new BuscaAluno());
        }

        private void menuBuscaProfessor_Click(object sender, EventArgs e)
        {
            openForm(new BuscaProfessor());
        }

        private void menuBuscaTurma_Click(object sender, EventArgs e)
        {
            openForm(new BuscaTurma());
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "CRUD Sistema Escolar \n\nVersão 1.0 \n\n© 2020 Tym \n\nTodos os direitos reservados", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Fim menu

        //
        // Insere um formulário num Panel 
        //
        Form _form;
        private void openForm(Form form)
        {
            _form?.Close();
            _form = form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(_form);
            _form.Show();
        }

        //
        // Arrastar o Form sem borda
        //
        private bool mover;
        private int cX, cY;

        private void menuStrip1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void menuStrip1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void pmenuStrip1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - menuStrip1.Left);
                this.Top += e.Y - (cY - menuStrip1.Top);
            }
        }
    }
}
