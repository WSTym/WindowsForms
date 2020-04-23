using SistemaEscolar.Views;
using SistemaEscolar.Views.Busca;
using SistemaEscolar.Views.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Main : Form
    {
        Form _form;
        public Main()
        {
            InitializeComponent();
        }

        #region Opções da barra de munus

        // Cadastro
        private void menuHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(_form);
            pnlLogo.Show();
        }
        private void menuCadastroCurso_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroCurso());
            pnlLogo.Hide();
        }
        private void menuCadastroTurma_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroTurma());
            pnlLogo.Hide();
        }

        private void menuCadastroDisciplina_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroDisciplina());
            pnlLogo.Hide();
        }

        private void menuCadastroProfessor_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroProfessor());
            pnlLogo.Hide();
        }

        private void menuCadastroAluno_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroAluno());
            pnlLogo.Hide();
        }

        private void menuCadastroAvaliacao_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroAvalicacao());
            pnlLogo.Hide();
        }

        private void menuLancamentoDeNotas_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroNotas());
            pnlLogo.Hide();
        }


        // Busca
        private void menuBuscaCurso_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaCurso());
            pnlLogo.Hide();
        }

        private void menuBuscaTurma_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaTurma());
            pnlLogo.Hide();
        }
        private void menuBuscaDisciplina_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaDisciplina());
            pnlLogo.Hide();
        }

        private void menuBuscaProfessor_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaProfessor());
            pnlLogo.Hide();
        }

        private void menuBuscaAluno_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaAluno());
            pnlLogo.Hide();
        }

        private void menuBuscaAvaliacao_Click(object sender, EventArgs e)
        {
            OpenForm(new BuscaAvaliacao());
            pnlLogo.Hide();
        }

        // Sobre
        private void menuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "CRUD Sistema Escolar \n\nVersão 1.0 \n\n© 2020 Tym \n\nTodos os direitos reservados", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botões
        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Inserção de formulário no Panel principal

        private void OpenForm(Form form)
        {
            _form?.Close();
            _form = form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(_form);
            _form.Show();
        }

        #endregion

        #region Arrastar o Form sem borda 

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

        #endregion
    }
}
