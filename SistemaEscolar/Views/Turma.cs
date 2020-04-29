using SistemaEscolar.Helper;
using SistemaEscolar.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Turma : Form
    {
        bool _pnlCoverEnable = true;
        public Turma()
        {
            InitializeComponent();
        }

        // Controles do CRUD

        #region Load
        private void Turma_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                turmaBindingSource.DataSource = context.Turmas.ToList();
                btnNovo.Enabled = true;

                if (_pnlCoverEnable)
                {
                    btnEditar.Enabled = false;
                    btnDeletar.Enabled = false;
                    pnlCover.Show();
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnDeletar.Enabled = true;
                    pnlCover.Hide();
                }

                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
                pnlCadastro.Enabled = false;
                btnPesquisar.Enabled = true;
                btnListar.Enabled = true;
                txtPesquisa.Enabled = true;
                turmaBindingSource.Add(new Models.Turma());
                turmaBindingSource.MoveLast();
            }
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
            btnPesquisar.Enabled = false;
            btnListar.Enabled = false;
            txtPesquisa.Enabled = false;
            txtPesquisa.Text = string.Empty;
            cbCurso.Focus();
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
            cbCurso.Focus();
            btnEditar.Enabled = false;
        }
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja deletar este Turma?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (Context context = new Context())
                    {
                        Models.Turma Turma = turmaBindingSource.Current as Models.Turma;

                        if (Turma != null)
                        {
                            if (context.Entry<Models.Turma>(Turma).State == EntityState.Detached)
                                context.Set<Models.Turma>().Attach(Turma);

                            context.Entry<Models.Turma>(Turma).State = EntityState.Deleted;
                            context.SaveChanges();
                            //MessageBox.Show(this, "Turma deletado com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            turmaBindingSource.RemoveCurrent();
                            dgvTurma.Refresh();
                            Turma_Load(sender, e);
                            pnlCadastro.Enabled = false;
                            btnNovo.Enabled = false;
                            turmaBindingSource.MoveLast();
                            turmaBindingSource.RemoveCurrent();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar uma linha vazia", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Models.Turma TurmaAux = turmaBindingSource.Current as Models.Turma;

            if (TurmaAux == null)
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            errTurma.Clear();
            turmaBindingSource.ResetBindings(false);
            Turma_Load(sender, e);
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(cbCurso, errTurma)) return;
            if (FormHelper.CheckEmptyField(cbTurno, errTurma)) return;
            if (FormHelper.CheckEmptyField(rbSemestre1, errTurma) || FormHelper.CheckEmptyField(rbSemestre2, errTurma)) return;
            if (FormHelper.CheckEmptyField(cbTurno, errTurma)) return;
            if (FormHelper.CheckEmptyField(txtCargaHoraria, errTurma)) return;
            using (Context context = new Context())
            {
                Models.Turma Turma = turmaBindingSource.Current as Models.Turma;
                if (Turma != null)
                    if (context.Entry<Models.Turma>(Turma).State == EntityState.Detached)
                    {
                        context.Set<Models.Turma>().Attach(Turma);
                        if (Turma.Id == 0)
                            context.Entry<Models.Turma>(Turma).State = EntityState.Added;
                        else
                            context.Entry<Models.Turma>(Turma).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show(this, "Turma adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTurma.Refresh();
                        Turma_Load(new object(), new EventArgs());
                        pnlCadastro.Enabled = false;
                    }
            }
        }
        #endregion

        #region Pesquisa
        /*private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                List<Models.Turma> pesquisa = context.Turmas.Where(x => x.Ano.Contains(txtPesquisa.Text) || x.Alunos.Contains(txtPesquisa.Text)).ToList();
                Models.Turma curso = turmaBindingSource.Current as Models.Turma;

                if (curso != null && !string.IsNullOrEmpty(txtPesquisa.Text) && pesquisa.Count() != 0)
                {
                    turmaBindingSource.DataSource = pesquisa;
                    btnNovo.Enabled = false;
                    btnLimpar.Enabled = true;
                    pnlCover.Hide();
                }
                else
                {
                    MessageBox.Show("Termo não encontrado ou campo vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar_Click(sender, e);
                }
            }

            Models.Curso cursoAux = turmaBindingSource.Current as Models.Curso;

            if (!_pnlCoverEnable)
            {
                btnLimpar.Enabled = true;
                turmaBindingSource.MoveLast();

                if (cursoAux.Id == 0)
                {
                    turmaBindingSource.RemoveCurrent();
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            else
            {
                turmaBindingSource.MoveLast();
            }
        }*/
        #endregion

        #region Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                turmaBindingSource.DataSource = context.Cursos.ToList();
                pnlCover.Hide();
                btnNovo.Enabled = false;
                btnListar.Enabled = false;
                btnLimpar.Enabled = true;
                Models.Curso curso = turmaBindingSource.Current as Models.Curso;

                if (curso != null)
                {
                    if (curso.Descricao != null && curso.Id != 0)
                    {
                        btnEditar.Enabled = true;
                        btnDeletar.Enabled = true;
                        turmaBindingSource.MoveFirst();
                        //turmaBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        MessageBox.Show("Não há cursos cadastrados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnLimpar_Click(sender, e);
                    }
                }

                _pnlCoverEnable = false;
            }
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pnlCover.Show();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnListar.Enabled = true;
            _pnlCoverEnable = true;
            Turma_Load(sender, e);
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
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }

        private void txtCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }
        #endregion
    }
}
