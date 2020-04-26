using System;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class SistemaEscolar : Form
    {
        Form _form;
        public SistemaEscolar()
        {
            InitializeComponent();
            pnlIndicador.Height = btnInicio.Height;
            pnlIndicador.Top = btnInicio.Top;
        }

        #region Opções da barra de munus

        // Cadastro
        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(_form);
            pnlIndicador.Height = btnInicio.Height;
            pnlIndicador.Top = btnInicio.Top;
            pnlSobre.Show();
        }
        private void btnCurso_Click(object sender, EventArgs e)
        {
            OpenForm(new Curso());
            pnlIndicador.Height = btnCurso.Height;
            pnlIndicador.Top = btnCurso.Top;
            pnlSobre.Hide();
        }
        private void btnTurma_Click(object sender, EventArgs e)
        {
            OpenForm(new Turma());
            pnlIndicador.Height = btnTurma.Height;
            pnlIndicador.Top = btnTurma.Top;
            pnlSobre.Hide();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            OpenForm(new Disciplina());
            pnlIndicador.Height = btnDisciplina.Height;
            pnlIndicador.Top = btnDisciplina.Top;
            pnlSobre.Hide();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            OpenForm(new Avalicacao());
            pnlIndicador.Height = btnAvaliação.Height;
            pnlIndicador.Top = btnAvaliação.Top;
            pnlSobre.Hide();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            OpenForm(new Notas());
            pnlIndicador.Height = btnNotas.Height;
            pnlIndicador.Top = btnNotas.Top;
            pnlSobre.Hide();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            OpenForm(new Views.Professor());
            pnlIndicador.Height = btnProfessor.Height;
            pnlIndicador.Top = btnProfessor.Top;
            pnlSobre.Hide();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            OpenForm(new Aluno());
            pnlIndicador.Height = btnAluno.Height;
            pnlIndicador.Top = btnAluno.Top;
            pnlSobre.Hide();
        }

        // Botões
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
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

        private void pnlTopBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void pnlTopBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTopBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlTopBar.Left);
                this.Top += e.Y - (cY - pnlTopBar.Top);
            }
        } 

        #endregion
    }
}
