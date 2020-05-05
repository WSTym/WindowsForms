using SistemaEscolar.Helper;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class Disciplina : Form
    {
        bool _pnlCoverEnable = true;
        public Disciplina()
        {
            InitializeComponent();
        }

        // Controles do CRUD

        #region Load
        private void Disciplina_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                disciplinaBindingSource.DataSource = context.Disciplinas.ToList();
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
                disciplinaBindingSource.Add(new Models.Disciplina());
                disciplinaBindingSource.MoveLast();
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
            txtNomeDisciplina.Focus();
            using (Context context = new Context())
            {
                context.Turmas.Load();
                turmaBindingSource.DataSource = context.Turmas.ToList();
            }
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
            txtNomeDisciplina.Focus();
            btnEditar.Enabled = false;
        }
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja deletar este disciplina?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (Context context = new Context())
                    {
                        Models.Disciplina disciplina = disciplinaBindingSource.Current as Models.Disciplina;

                        if (disciplina != null)
                        {
                            if (context.Entry(disciplina).State == EntityState.Detached)
                                context.Set<Models.Disciplina>().Attach(disciplina);

                            context.Entry(disciplina).State = EntityState.Deleted;
                            context.SaveChanges();
                            //MessageBox.Show(this, "Disciplina deletado com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            disciplinaBindingSource.RemoveCurrent();
                            dgvDisciplina.Refresh();
                            Disciplina_Load(sender, e);
                            pnlCadastro.Enabled = false;
                            btnNovo.Enabled = false;
                            disciplinaBindingSource.MoveLast();
                            disciplinaBindingSource.RemoveCurrent();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar uma linha vazia", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Models.Disciplina disciplinaAux = disciplinaBindingSource.Current as Models.Disciplina;

            if (disciplinaAux == null)
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_pnlCoverEnable == false)
            {
                pnlCadastro.Enabled = false;
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else
            {
                CleanForm();
                errDisciplina.Clear();
                disciplinaBindingSource.ResetBindings(false);
                Disciplina_Load(sender, e);
            }
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(txtNomeDisciplina, errDisciplina)) return;
            if (FormHelper.CheckEmptyField(txtNomeDisciplina, errDisciplina)) return;
            if (FormHelper.CheckEmptyField(txtCargaHoraria, errDisciplina)) return;

            using (Context context = new Context())
            {
                Models.Disciplina disciplina = disciplinaBindingSource.Current as Models.Disciplina;
                disciplina.TurmaId = ((Models.Avaliacao)cboTurma.SelectedItem).Id;

                if (disciplina != null)
                {
                    if (context.Entry(disciplina).State == EntityState.Detached)
                    {
                        context.Set<Models.Disciplina>().Attach(disciplina);

                        if (disciplina.Id == 0)
                            context.Entry(disciplina).State = EntityState.Added;
                        else
                            context.Entry(disciplina).State = EntityState.Modified;

                        context.SaveChanges();
                        MessageBox.Show(this, "Disciplina adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDisciplina.Refresh();
                        Disciplina_Load(new object(), new EventArgs());
                        pnlCadastro.Enabled = false;
                    }
                }
            }
        }
        #endregion

        #region Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                List<Models.Disciplina> pesquisa = context.Disciplinas.Where(x => x.Nome.Contains(txtPesquisa.Text) || x.Nome.Contains(txtPesquisa.Text)).ToList();
                Models.Disciplina disciplina = disciplinaBindingSource.Current as Models.Disciplina;

                if (disciplina != null && !string.IsNullOrEmpty(txtPesquisa.Text) && pesquisa.Count() != 0)
                {
                    disciplinaBindingSource.DataSource = pesquisa;
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

            Models.Disciplina disciplinaAux = disciplinaBindingSource.Current as Models.Disciplina;

            if (!_pnlCoverEnable)
            {
                btnLimpar.Enabled = true;
                disciplinaBindingSource.MoveLast();

                if (disciplinaAux.Id == 0)
                {
                    disciplinaBindingSource.RemoveCurrent();
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            else
            {
                disciplinaBindingSource.MoveLast();
            }
        }
        #endregion

        #region Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                disciplinaBindingSource.DataSource = context.Disciplinas.ToList();
                pnlCover.Hide();
                btnNovo.Enabled = false;
                btnListar.Enabled = false;
                btnLimpar.Enabled = true;
                Models.Disciplina disciplina = disciplinaBindingSource.Current as Models.Disciplina;

                if (disciplina != null)
                {
                    if (disciplina.Nome != null && disciplina.Id != 0)
                    {
                        btnEditar.Enabled = true;
                        btnDeletar.Enabled = true;
                        disciplinaBindingSource.MoveFirst();
                        //disciplinaBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        MessageBox.Show("Não há disciplinas cadastrados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Disciplina_Load(sender, e);
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
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }
        #endregion
    }
}
