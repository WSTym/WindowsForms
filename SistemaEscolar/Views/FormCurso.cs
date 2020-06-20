using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class FormCurso : Form
    {
        DataTable dt = new DataTable();
        string textoPesquisa;
        bool edit;
        bool search;
        public FormCurso()
        {
            InitializeComponent();
        }

        // Controles do CRUD

        #region Load
        private void Curso_Load(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            pnlCadastro.Enabled = false;
            btnListar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtPesquisa.Enabled = true;

            SetUpDataGridViewData();
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
            btnLimpar.Enabled = false;
            txtPesquisa.Enabled = false;
            txtNomeCurso.Focus();
            dgvCurso.Enabled = false;
            textoPesquisa = txtPesquisa.Text;            
        }
        #endregion
         
        #region Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            edit = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            pnlCadastro.Enabled = true;
            txtPesquisa.Enabled = false;
            txtNomeCurso.Focus();

            txtNomeCurso.Text = dgvCurso.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvCurso.CurrentRow.Cells[2].Value.ToString();

            dgvCurso.Enabled = false;
        } 
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Tem certeza que deseja deletar este curso?", "Atenção!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (Context context = new Context())
                {
                    int id = (int)dgvCurso.CurrentRow.Cells[0].Value;
                    var curso = context.Cursos.First(x => x.Id == id);
                    context.Cursos.Remove(curso);
                    context.SaveChanges();

                    MessageBox.Show(this, "Curso deletado com sucesso!", ";)", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    if (search)
                    {
                        var pesquisa = context.Cursos
                        .Where(x => x.Nome.Contains(textoPesquisa) || x.Descricao.Contains(textoPesquisa)).ToList();

                        FillDataGridView(pesquisa);
                    }
                    else
                    {
                        var cursos = context.Cursos.ToList();
                        FillDataGridView(cursos);
                    }

                    pnlCadastro.Enabled = false;
                    btnNovo.Enabled = false;
                    search = false;
                }
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            edit = false;

            if (dgvCurso.Rows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                btnListar.Enabled = true;
                btnLimpar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
                btnLimpar.Enabled = true;
            }

            pnlCadastro.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnPesquisar.Enabled = true;
            txtPesquisa.Enabled = true;
            errCurso.Clear();
            Services.Services.SetTextEmpty(this);
            dgvCurso.Enabled = true;
            txtPesquisa.Text = textoPesquisa;
        }
        #endregion

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Services.Services.CheckEmptyField(txtNomeCurso, errCurso)) return;
            if (Services.Services.CheckEmptyField(txtDescricao, errCurso)) return;

            Cursor = Cursors.WaitCursor;

            using (Context context = new Context())
            {
                int id = 0;
                var curso = context.Set<Curso>();

                if (edit)
                {
                    id = (int)dgvCurso.CurrentRow.Cells[0].Value;
                    var editaCurso = context.Cursos.Where(x => x.Id == id);

                    if (editaCurso.Count() > 0)
                    {
                        editaCurso.First().Nome = txtNomeCurso.Text;
                        editaCurso.First().Descricao = txtDescricao.Text;
                    }

                    MessageBox.Show(this, "Curso editado com sucesso!", ";)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    edit = false;
                }
                else
                {
                    curso.Add(new Curso
                    {
                        Nome = txtNomeCurso.Text,
                        Descricao = txtDescricao.Text
                    }); 

                    MessageBox.Show(this, "Curso adicionado com sucesso!", ";)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                context.SaveChanges();

                if (search)
                {
                    var pesquisa = context.Cursos
                    .Where(x => x.Nome.Contains(textoPesquisa) || x.Descricao.Contains(textoPesquisa)).ToList();

                    foreach (var item in pesquisa)
                    {
                        FillDataGridView(pesquisa);
                    }
                }
                else
                {
                    var cursos = context.Cursos.ToList();
                    foreach (var item in curso)
                    {
                        FillDataGridView(cursos);
                    }
                }                

                dgvCurso.ClearSelection();

                foreach (DataGridViewRow row in dgvCurso.Rows)
                {
                    if ((int)row.Cells[0].Value == id)
                    {
                        row.Cells[0].Selected = true;
                    }                    
                }

                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = true;
                btnPesquisar.Enabled = true;
                txtPesquisa.Enabled = true;
                Services.Services.SetTextEmpty(this);
                pnlCadastro.Enabled = false;
                dgvCurso.Enabled = true;
                txtPesquisa.Text = search ? textoPesquisa : string.Empty;
                search = false;
            }

            Cursor = Cursors.Default;
        }
        #endregion

        #region Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            textoPesquisa = txtPesquisa.Text;

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                MessageBox.Show("Campo de pesquisa vazio", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            search = true;
            Cursor = Cursors.WaitCursor;

            using (Context context = new Context())
            {
                var pesquisa = context.Cursos
                    .Where(x => x.Nome.Contains(textoPesquisa) || x.Descricao.Contains(textoPesquisa)).ToList();

                if (pesquisa.Count() > 0)
                {
                    FillDataGridView(pesquisa);

                    btnEditar.Enabled = true;
                    btnDeletar.Enabled = true;
                    btnListar.Enabled = false;
                    btnLimpar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Termo não encontrado", "Atenção", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);

                    txtPesquisa.Text = string.Empty;
                    txtPesquisa.Focus();
                    Cancel();
                }
            }

            Cursor = Cursors.Default;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                btnListar.Enabled = false;
                btnLimpar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }
        #endregion

        #region Listar
        private void btnListar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnListar.Enabled = false;
            txtPesquisa.Text = string.Empty;

            using (Context context = new Context())
            {
                var curso = context.Cursos.ToList();
                if (curso.Count() > 0)
                {
                    FillDataGridView(curso);

                    btnEditar.Enabled = true;
                    btnDeletar.Enabled = true;
                    btnLimpar.Enabled = true;
                }
                else
                {
                    btnEditar.Enabled = false;
                    btnDeletar.Enabled = false;

                    MessageBox.Show("Não há cursos cadastrados", "Atenção", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);

                    CleanUp();
                }

                Cursor = Cursors.Default;
            }
        } 
        #endregion

        #region Limpar 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void CleanUp()
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnListar.Enabled = true;
            txtPesquisa.Text = string.Empty;
            CleanUpDatagridViewRows();
            search = false;
        }
        #endregion

        // 

        #region Configura o DataGridView
        private void SetUpDataGridViewData()
        {
            if (dgvCurso.ColumnCount == 0)
            {
                dt.Columns.Add("Cód.", typeof(int)).ReadOnly = true;
                dt.Columns.Add("Nome", typeof(string)).ReadOnly = true;
                dt.Columns.Add("Descrição", typeof(string)).ReadOnly = true;

                dgvCurso.DataSource = dt;

                dgvCurso.Columns[0].Width = 50;
                dgvCurso.Columns[1].Width = 200;
                dgvCurso.Columns[2].Width = 316;

                dgvCurso.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        #endregion

        #region Remove as linhas do DataGridView
        private void CleanUpDatagridViewRows()
        {
            while (dgvCurso.Rows.Count > 0)
            {
                dgvCurso.Rows.RemoveAt(0);
            }
        }
        #endregion

        #region Preenche o DataGridView
        private void FillDataGridView(List<Curso> cursos)
        {
            CleanUpDatagridViewRows();

            foreach (var curso in cursos)
            {
                DataRow dr = dt.NewRow();
                dr["Cód."] = curso.Id;
                dr["Nome"] = curso.Nome;
                dr["Descrição"] = curso.Descricao;
                dt.Rows.Add(dr);
            }
        }
        #endregion
    }
}
