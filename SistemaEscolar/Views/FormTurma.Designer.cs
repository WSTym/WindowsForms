namespace SistemaEscolar.Views
{
    partial class FormTurma
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errTurma = new System.Windows.Forms.ErrorProvider(this.components);
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
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
            this.txtPesquisa.Location = new System.Drawing.Point(539, 36);
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
            this.btnPesquisar.Location = new System.Drawing.Point(736, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 28);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.UseVisualStyleBackColor = false;
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
            this.btnListar.Location = new System.Drawing.Point(772, 34);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar Turmas";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Turma";
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
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.txtCargaHoraria);
            this.pnlCadastro.Controls.Add(this.cboTurno);
            this.pnlCadastro.Controls.Add(this.cboSemestre);
            this.pnlCadastro.Controls.Add(this.cboCurso);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.txtAno);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlCadastro.Location = new System.Drawing.Point(0, 60);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(350, 390);
            this.pnlCadastro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carga Horária:";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "CargaHoraria", true));
            this.txtCargaHoraria.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtCargaHoraria.Location = new System.Drawing.Point(130, 156);
            this.txtCargaHoraria.MaxLength = 4;
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(40, 21);
            this.txtCargaHoraria.TabIndex = 6;
            this.txtCargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // cboTurno
            // 
            this.cboTurno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cboTurno.Location = new System.Drawing.Point(130, 123);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(100, 24);
            this.cboTurno.TabIndex = 5;
            // 
            // cboSemestre
            // 
            this.cboSemestre.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboSemestre.Location = new System.Drawing.Point(130, 88);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(40, 24);
            this.cboSemestre.TabIndex = 1;
            this.cboSemestre.Tag = "Semestre";
            // 
            // cboCurso
            // 
            this.cboCurso.DataSource = this.cursoBindingSource;
            this.cboCurso.DisplayMember = "Nome";
            this.cboCurso.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(130, 21);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(200, 24);
            this.cboCurso.TabIndex = 1;
            this.cboCurso.Tag = "Curso";
            this.cboCurso.ValueMember = "Id";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Models.Curso);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // txtAno
            // 
            this.txtAno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "Ano", true));
            this.txtAno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtAno.Location = new System.Drawing.Point(130, 54);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(40, 21);
            this.txtAno.TabIndex = 2;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Turno:";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.White;
            this.pnlPesquisa.Controls.Add(this.pnlCover);
            this.pnlPesquisa.Controls.Add(this.dgvTurma);
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
            // dgvTurma
            // 
            this.dgvTurma.AllowUserToAddRows = false;
            this.dgvTurma.AllowUserToDeleteRows = false;
            this.dgvTurma.AllowUserToOrderColumns = true;
            this.dgvTurma.AutoGenerateColumns = false;
            this.dgvTurma.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.cursoDataGridViewTextBoxColumn});
            this.dgvTurma.DataSource = this.turmaBindingSource;
            this.dgvTurma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTurma.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTurma.Location = new System.Drawing.Point(20, 20);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.ReadOnly = true;
            this.dgvTurma.Size = new System.Drawing.Size(610, 350);
            this.dgvTurma.TabIndex = 14;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 150;
            // 
            // errTurma
            // 
            this.errTurma.ContainerControl = this;
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataSource = typeof(Models.Turma);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Turno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CargaHoraria";
            this.dataGridViewTextBoxColumn3.HeaderText = "CargaHoraria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Semestre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Semestre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CursoId";
            this.dataGridViewTextBoxColumn5.HeaderText = "CursoId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turma";
            this.Text = "CadastroTurma";
            this.Load += new System.EventHandler(this.Turma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.ErrorProvider errTurma;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
    }
}