using SistemaEscolar.Services;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class FormNotas : Form
    {
        bool _pnlCoverEnable = true;
        public FormNotas()
        {
            InitializeComponent();
        }

        // Controles do CRUD

        #region Load
        private void Notas_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                context.Notas.Load();
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
                notaBindingSource.Add(new Nota());
                notaBindingSource.MoveLast();
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
            cboTurma.Focus();
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
            cboTurma.Focus();
            btnEditar.Enabled = false;
        }
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja deletar esta nota?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (Context context = new Context())
                    {
                        Nota nota = notaBindingSource.Current as Nota;

                        if (nota != null)
                        {
                            if (context.Entry(nota).State == EntityState.Detached)
                                context.Set<Nota>().Attach(nota);

                            context.Entry(nota).State = EntityState.Deleted;
                            context.SaveChanges();
                            //MessageBox.Show(this, "Nota deletada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            notaBindingSource.RemoveCurrent();
                            dgvNotas.Refresh();
                            Notas_Load(sender, e);
                            pnlCadastro.Enabled = false;
                            btnNovo.Enabled = false;
                            notaBindingSource.MoveLast();
                            notaBindingSource.RemoveCurrent();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar uma linha vazia", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Nota notaAux = notaBindingSource.Current as Nota;

            if (notaAux == null)
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
                errNotas.Clear();
                Notas_Load(sender, e);
            }
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                Nota nota = notaBindingSource.Current as Nota;

                if (nota != null)
                {
                    if (context.Entry(nota).State == EntityState.Detached)
                    {
                        context.Set<Nota>().Attach(nota);

                        if (nota.Id == 0)
                            context.Entry(nota).State = EntityState.Added;
                        else
                            context.Entry(nota).State = EntityState.Modified;

                        context.SaveChanges();
                        MessageBox.Show(this, "Nota adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            dgvNotas.Refresh();
            Notas_Load(sender, e);
            pnlCadastro.Enabled = false;
        }
        #endregion

        #region Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Todo 
        }
        #endregion

        #region Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                notaBindingSource.DataSource = context.Turmas.ToList();
                pnlCover.Hide();
                btnNovo.Enabled = false;
                btnListar.Enabled = false;
                btnLimpar.Enabled = true;
                Nota nota = notaBindingSource.Current as Nota;

                if (nota != null)
                {
                    if (nota.Valor != null && nota.Id != 0) // Todo
                    {
                        btnEditar.Enabled = true;
                        btnDeletar.Enabled = true;
                        notaBindingSource.MoveFirst();
                    }
                    else
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        MessageBox.Show("Não há notas cadastradas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Notas_Load(sender, e);
        }
        #endregion

        //

        #region Limpa os TextBoxes
        private void CleanForm()
        {
            Services.Services.SetTextEmpty(this);
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
