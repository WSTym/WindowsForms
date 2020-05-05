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
    public partial class Avaliacao : Form
    {
        bool _pnlCoverEnable = true;
        public Avaliacao()
        {
            InitializeComponent();
        }

        // Controles do CRUD

        #region Load
        private void Avaliacao_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
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
                avaliacaoBindingSource.Add(new Models.Avaliacao());
                avaliacaoBindingSource.MoveLast();
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
            cboDisciplina.Focus();
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
            cboDisciplina.Focus();
            btnEditar.Enabled = false;
        }
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja deletar esta avaliação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (Context context = new Context())
                    {
                        Models.Avaliacao avaliacao = avaliacaoBindingSource.Current as Models.Avaliacao;

                        if (avaliacao != null)
                        {
                            if (context.Entry(avaliacao).State == EntityState.Detached)
                                context.Set<Models.Avaliacao>().Attach(avaliacao);

                            context.Entry(avaliacao).State = EntityState.Deleted;
                            context.SaveChanges();
                            avaliacaoBindingSource.RemoveCurrent();
                            dgvAvaliacao.Refresh();
                            Avaliacao_Load(sender, e);
                            pnlCadastro.Enabled = false;
                            btnNovo.Enabled = false;
                            avaliacaoBindingSource.MoveLast();
                            avaliacaoBindingSource.RemoveCurrent();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar uma linha vazia", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Models.Avaliacao avaliacaoAux = avaliacaoBindingSource.Current as Models.Avaliacao;

            if (avaliacaoAux == null)
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
                errAvaliacao.Clear();
                avaliacaoBindingSource.ResetBindings(false);
                Avaliacao_Load(sender, e);
            }
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormHelper.CheckEmptyField(cboDisciplina, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtTemaAvaliacao, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtDataAvaliacao, errAvaliacao)) return;
            if (FormHelper.CheckEmptyField(txtValorAvaliacao, errAvaliacao)) return;

            using (Context context = new Context())
            {
                Models.Avaliacao avaliacao = avaliacaoBindingSource.Current as Models.Avaliacao;
                avaliacao.DisciplinaId = ((Models.Curso)cboDisciplina.SelectedItem).Id;

                if (avaliacao != null)
                {
                    if (context.Entry(avaliacao).State == EntityState.Detached)
                    {
                        context.Set<Models.Avaliacao>().Attach(avaliacao);

                        if (avaliacao.Id == 0)
                            context.Entry(avaliacao).State = EntityState.Added;
                        else
                            context.Entry(avaliacao).State = EntityState.Modified;

                        context.SaveChanges();
                        MessageBox.Show(this, "Avaliação adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            dgvAvaliacao.Refresh();
            Avaliacao_Load(sender, e);
            pnlCadastro.Enabled = false;
        }
        #endregion

        #region Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                List<Models.Avaliacao> pesquisa = context.Avaliacoes.Where(x => x.Tema.Contains(txtPesquisa.Text) || x.Valor.Contains(txtPesquisa.Text)).ToList();
                Models.Avaliacao avaliacao= avaliacaoBindingSource.Current as Models.Avaliacao;

                if (avaliacao != null && !string.IsNullOrEmpty(txtPesquisa.Text) && pesquisa.Count() != 0)
                {
                    avaliacaoBindingSource.DataSource = pesquisa;
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

            Models.Avaliacao avaliacaoAux = avaliacaoBindingSource.Current as Models.Avaliacao;

            if (!_pnlCoverEnable)
            {
                btnLimpar.Enabled = true;
                avaliacaoBindingSource.MoveLast();

                if (avaliacaoAux.Id == 0)
                {
                    avaliacaoBindingSource.RemoveCurrent();
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            else
            {
                avaliacaoBindingSource.MoveLast();
            }
        }
        #endregion

        #region Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                avaliacaoBindingSource.DataSource = context.Turmas.ToList();
                pnlCover.Hide();
                btnNovo.Enabled = false;
                btnListar.Enabled = false;
                btnLimpar.Enabled = true;
                Models.Avaliacao avaliacao = avaliacaoBindingSource.Current as Models.Avaliacao;

                if (avaliacao != null)
                {
                    if (avaliacao.Tema  != null && avaliacao.Id != 0)
                    {
                        btnEditar.Enabled = true;
                        btnDeletar.Enabled = true;
                        avaliacaoBindingSource.MoveFirst();
                        //avaliacaoBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        MessageBox.Show("Não há avaliações cadastradas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Avaliacao_Load(sender, e);
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
