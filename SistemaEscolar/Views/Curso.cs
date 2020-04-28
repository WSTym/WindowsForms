using SistemaEscolar.Helper;
using SistemaEscolar.Models.Context;
using System;
using System.Collections.Generic;
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

        // Controles do CRUD

        #region Load
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
            cursoBindingSource.Add(new Models.Curso());
            cursoBindingSource.MoveLast();
        }
        #endregion

        #region Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadastro.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            txtNomeCurso.Focus();
        }
        #endregion

        #region Editar
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
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
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
                            //MessageBox.Show(this, "Curso deletado com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cursoBindingSource.RemoveCurrent();
                            dgvCurso.Refresh();
                            Curso_Load(new object(), new EventArgs());
                            pnlCadastro.Enabled = false;
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar uma linha vazia", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errCurso.Clear();
            cursoBindingSource.ResetBindings(false);
            Curso_Load(new object(), new EventArgs());
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeCurso, errCurso)) return;
            if (FormHelper.CheckEmptyField(txtDescricao, errCurso)) return;
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
        #endregion

        #region Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                List<Models.Curso> pesquisa = context.Cursos.Where(x => x.Nome.Contains(txtPesquisa.Text) || x.Descricao.Contains(txtPesquisa.Text)).ToList();
                Models.Curso curso = cursoBindingSource.Current as Models.Curso;

                if (curso != null && !string.IsNullOrEmpty(txtPesquisa.Text) && pesquisa.Count() != 0)
                {
                    cursoBindingSource.DataSource = pesquisa;
                    btnNovo.Enabled = false;
                    btnCancelar.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("Termo não encontrado ou campo vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar_Click(sender, e);
                }
            }
        } 
        #endregion

        // 

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
