namespace SistemaEscolar.Views
{
    partial class FormNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.txtNotaAluno = new System.Windows.Forms.TextBox();
            this.chkFalta = new System.Windows.Forms.CheckBox();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.cboAvaliacao = new System.Windows.Forms.ComboBox();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errNotas
            // 
            this.errNotas.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 60);
            this.panel1.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPesquisa.Location = new System.Drawing.Point(539, 36);
            this.txtPesquisa.MaxLength = 20;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 24);
            this.txtPesquisa.TabIndex = 17;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = global::SistemaEscolar.Properties.Resources.search_2_16;
            this.btnPesquisar.Location = new System.Drawing.Point(736, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 28);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(880, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListar.Location = new System.Drawing.Point(772, 34);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar Notas";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Notas";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.White;
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnDeletar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 450);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1000, 100);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(334, 33);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 33);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Location = new System.Drawing.Point(450, 33);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 33);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(566, 33);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(682, 33);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 33);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Location = new System.Drawing.Point(218, 33);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 33);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.White;
            this.pnlCadastro.Controls.Add(this.txtNotaAluno);
            this.pnlCadastro.Controls.Add(this.chkFalta);
            this.pnlCadastro.Controls.Add(this.cboAluno);
            this.pnlCadastro.Controls.Add(this.cboAvaliacao);
            this.pnlCadastro.Controls.Add(this.cboDisciplina);
            this.pnlCadastro.Controls.Add(this.cboTurma);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.label6);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlCadastro.Location = new System.Drawing.Point(0, 60);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(350, 390);
            this.pnlCadastro.TabIndex = 8;
            // 
            // txtNotaAluno
            // 
            this.txtNotaAluno.Location = new System.Drawing.Point(130, 157);
            this.txtNotaAluno.MaxLength = 4;
            this.txtNotaAluno.Name = "txtNotaAluno";
            this.txtNotaAluno.Size = new System.Drawing.Size(40, 21);
            this.txtNotaAluno.TabIndex = 4;
            this.txtNotaAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // chkFalta
            // 
            this.chkFalta.AutoSize = true;
            this.chkFalta.Location = new System.Drawing.Point(130, 195);
            this.chkFalta.Name = "chkFalta";
            this.chkFalta.Size = new System.Drawing.Size(15, 14);
            this.chkFalta.TabIndex = 10;
            this.chkFalta.UseVisualStyleBackColor = true;
            // 
            // cboAluno
            // 
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(130, 122);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(200, 24);
            this.cboAluno.TabIndex = 4;
            // 
            // cboAvaliacao
            // 
            this.cboAvaliacao.FormattingEnabled = true;
            this.cboAvaliacao.Location = new System.Drawing.Point(130, 88);
            this.cboAvaliacao.Name = "cboAvaliacao";
            this.cboAvaliacao.Size = new System.Drawing.Size(200, 24);
            this.cboAvaliacao.TabIndex = 3;
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.Location = new System.Drawing.Point(130, 54);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(200, 24);
            this.cboDisciplina.TabIndex = 2;
            // 
            // cboTurma
            // 
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(130, 20);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(200, 24);
            this.cboTurma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(20, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Falta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Avaliação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota:";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.White;
            this.pnlPesquisa.Controls.Add(this.pnlCover);
            this.pnlPesquisa.Controls.Add(this.dgvNotas);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlPesquisa.Location = new System.Drawing.Point(350, 60);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPesquisa.Size = new System.Drawing.Size(650, 390);
            this.pnlPesquisa.TabIndex = 9;
            // 
            // pnlCover
            // 
            this.pnlCover.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCover.Location = new System.Drawing.Point(21, 21);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(608, 348);
            this.pnlCover.TabIndex = 16;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AutoGenerateColumns = false;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.avaliacaoDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.faltaDataGridViewCheckBoxColumn});
            this.dgvNotas.DataSource = this.notaBindingSource;
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNotas.Location = new System.Drawing.Point(20, 20);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(610, 350);
            this.dgvNotas.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // avaliacaoDataGridViewTextBoxColumn
            // 
            this.avaliacaoDataGridViewTextBoxColumn.DataPropertyName = "Avaliacao";
            this.avaliacaoDataGridViewTextBoxColumn.HeaderText = "Avaliação";
            this.avaliacaoDataGridViewTextBoxColumn.Name = "avaliacaoDataGridViewTextBoxColumn";
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // faltaDataGridViewCheckBoxColumn
            // 
            this.faltaDataGridViewCheckBoxColumn.DataPropertyName = "Falta";
            this.faltaDataGridViewCheckBoxColumn.HeaderText = "Falta";
            this.faltaDataGridViewCheckBoxColumn.Name = "faltaDataGridViewCheckBoxColumn";
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataSource = typeof(Models.Nota);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errNotas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.ComboBox cboAvaliacao;
        private System.Windows.Forms.ComboBox cboDisciplina;
        private System.Windows.Forms.TextBox txtNotaAluno;
        private System.Windows.Forms.CheckBox chkFalta;
        private System.Windows.Forms.BindingSource notaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn faltaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel pnlCover;
    }
}