using SistemaEscolar.Helper;
using SistemaEscolar.Models.Context;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                cursoBindingSource.DataSource = context.Cursos.ToList();
            }

            Models.Curso curso = cursoBindingSource.Current as Models.Curso;
            if (curso != null)
            {
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            pnlCadastro.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            cursoBindingSource.Add(new Models.Curso());
            cursoBindingSource.MoveLast();
            btnNovo.Enabled = true;
            txtNomeCurso.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            pnlCadastro.Enabled = true;
            txtNomeCurso.Focus();
            btnEditar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Tem certeza que deseja deletar este curso?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                using (Context context = new Context())
                {
                    Models.Curso curso = cursoBindingSource.Current as Models.Curso;
                    if (curso != null)
                    {
                        if (context.Entry<Models.Curso>(curso).State == EntityState.Detached)
                            context.Set<Models.Curso>().Attach(curso);
                        context.Entry<Models.Curso>(curso).State = EntityState.Deleted;
                        context.SaveChanges();
                        MessageBox.Show(this, "Curso deletado com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cursoBindingSource.RemoveCurrent();
                        dgvCurso.Refresh();
                        Curso_Load(new object(), new EventArgs());
                        pnlCadastro.Enabled = false;
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errCurso.Clear();
            cursoBindingSource.ResetBindings(false);
            Curso_Load(new object(), new EventArgs());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeCurso, errCurso)) return;
            if (FormHelper.CheckEmptyField(txtDescricao, errCurso)) return;
            if (FormHelper.CheckEmptyField(txtCargaHoraria, errCurso)) return;
            using (Context context = new Context())
            {
                Models.Curso curso = cursoBindingSource.Current as Models.Curso;
                if (curso != null)
                    if (context.Entry<Models.Curso>(curso).State == EntityState.Detached)
                    {
                        context.Set<Models.Curso>().Attach(curso);
                        if (curso.Id == 0)
                            context.Entry<Models.Curso>(curso).State = EntityState.Added;
                        else
                            context.Entry<Models.Curso>(curso).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show(this, "Curso adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCurso.Refresh();
                        Curso_Load(new object(), new EventArgs());
                        pnlCadastro.Enabled = false;
                    }
            }
        }

        #region Limpa os TextBoxes

        private void CleanForm()
        {
            FormHelper.SetTextEmpty(this);
        }

        #endregion

        #region Restringe caracteres da textbox a somente números

        private void txtCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }

        #endregion
    }
}
