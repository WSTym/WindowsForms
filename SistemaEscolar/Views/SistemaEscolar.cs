using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class SistemaEscolar : MetroForm
    {
        Form _form;
        public SistemaEscolar()
        {
            InitializeComponent();
        }

        private void SistemaEscolar_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(_form);
            pnlLogo.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroCurso());
            pnlLogo.Hide();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
             OpenForm(new Turma());
            pnlLogo.Hide();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroDisciplina());
            pnlLogo.Hide();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            OpenForm(new Professor());
            pnlLogo.Hide();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            OpenForm(new Aluno());
            pnlLogo.Hide();
        }

        private void btnAvalicao_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroAvalicacao());
            pnlLogo.Hide();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            OpenForm(new CadastroNotas());
            pnlLogo.Hide();
        }

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
    }
}
