namespace SistemaEscolar.Views
{
    partial class FormDisciplina
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
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulasSemanaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errDisciplina = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDisciplina)).BeginInit();
            this.SuspendLayout();
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
            this.txtPesquisa.Location = new System.Drawing.Point(538, 35);
            this.txtPesquisa.MaxLength = 20;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 24);
            this.txtPesquisa.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = global::SistemaEscolar.Properties.Resources.search_2_16;
            this.btnPesquisar.Location = new System.Drawing.Point(735, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 28);
            this.btnPesquisar.TabIndex = 14;
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
            this.btnLimpar.Location = new System.Drawing.Point(879, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 16;
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
            this.btnListar.Location = new System.Drawing.Point(771, 33);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar discip.";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Disciplina";
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
            this.pnlCadastro.Controls.Add(this.cboTurma);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.textBox1);
            this.pnlCadastro.Controls.Add(this.txtCargaHoraria);
            this.pnlCadastro.Controls.Add(this.txtNomeDisciplina);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlCadastro.Location = new System.Drawing.Point(0, 60);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(350, 390);
            this.pnlCadastro.TabIndex = 8;
            // 
            // cboTurma
            // 
            this.cboTurma.DataSource = this.turmaBindingSource;
            this.cboTurma.DisplayMember = "Ano";
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(130, 20);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(200, 24);
            this.cboTurma.TabIndex = 4;
            this.cboTurma.ValueMember = "Id";
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataSource = typeof(Models.Avaliacao);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aulas Semanais:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Carga Horária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "AulasSemanais", true));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(130, 122);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataSource = typeof(Models.Disciplina);
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "CargaHoraria", true));
            this.txtCargaHoraria.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtCargaHoraria.Location = new System.Drawing.Point(130, 88);
            this.txtCargaHoraria.MaxLength = 4;
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(40, 21);
            this.txtCargaHoraria.TabIndex = 3;
            this.txtCargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "Nome", true));
            this.txtNomeDisciplina.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtNomeDisciplina.Location = new System.Drawing.Point(130, 54);
            this.txtNomeDisciplina.MaxLength = 50;
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(200, 21);
            this.txtNomeDisciplina.TabIndex = 2;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.White;
            this.pnlPesquisa.Controls.Add(this.pnlCover);
            this.pnlPesquisa.Controls.Add(this.dgvDisciplina);
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
            this.pnlCover.TabIndex = 15;
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.AllowUserToAddRows = false;
            this.dgvDisciplina.AllowUserToDeleteRows = false;
            this.dgvDisciplina.AutoGenerateColumns = false;
            this.dgvDisciplina.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cargaHorariaDataGridViewTextBoxColumn,
            this.aulasSemanaisDataGridViewTextBoxColumn});
            this.dgvDisciplina.DataSource = this.disciplinaBindingSource;
            this.dgvDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisciplina.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDisciplina.Location = new System.Drawing.Point(20, 20);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.Size = new System.Drawing.Size(610, 350);
            this.dgvDisciplina.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // cargaHorariaDataGridViewTextBoxColumn
            // 
            this.cargaHorariaDataGridViewTextBoxColumn.DataPropertyName = "CargaHoraria";
            this.cargaHorariaDataGridViewTextBoxColumn.HeaderText = "Carga Horaria";
            this.cargaHorariaDataGridViewTextBoxColumn.Name = "cargaHorariaDataGridViewTextBoxColumn";
            this.cargaHorariaDataGridViewTextBoxColumn.Width = 75;
            // 
            // aulasSemanaisDataGridViewTextBoxColumn
            // 
            this.aulasSemanaisDataGridViewTextBoxColumn.DataPropertyName = "AulasSemanais";
            this.aulasSemanaisDataGridViewTextBoxColumn.HeaderText = "Aulas Semanais";
            this.aulasSemanaisDataGridViewTextBoxColumn.Name = "aulasSemanaisDataGridViewTextBoxColumn";
            this.aulasSemanaisDataGridViewTextBoxColumn.Width = 75;
            // 
            // errDisciplina
            // 
            this.errDisciplina.ContainerControl = this;
            // 
            // Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Disciplina";
            this.Text = "CadastroDisciplina";
            this.Load += new System.EventHandler(this.Disciplina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDisciplina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.DataGridView dgvDisciplina;
        private System.Windows.Forms.ErrorProvider errDisciplina;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulasSemanaisDataGridViewTextBoxColumn;
    }
}