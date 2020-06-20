namespace SistemaEscolar.Views
{
    partial class FormAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoAluno = new System.Windows.Forms.TextBox();
            this.txtTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.errAluno = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ederecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Nasc.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 60);
            this.panel1.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPesquisa.Location = new System.Drawing.Point(744, 23);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 24);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Aluno";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = global::SistemaEscolar.Properties.Resources.search_2_16;
            this.btnPesquisar.Location = new System.Drawing.Point(950, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.White;
            this.pnlPesquisa.Controls.Add(this.dgvAluno);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlPesquisa.Location = new System.Drawing.Point(350, 60);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPesquisa.Size = new System.Drawing.Size(650, 390);
            this.pnlPesquisa.TabIndex = 2;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AutoGenerateColumns = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.ederecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.turmaDataGridViewTextBoxColumn});
            this.dgvAluno.DataSource = this.alunoBindingSource;
            this.dgvAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAluno.Location = new System.Drawing.Point(20, 20);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(610, 350);
            this.dgvAluno.TabIndex = 14;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Models.Aluno);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.White;
            this.pnlCadastro.Controls.Add(this.cbCurso);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.label6);
            this.pnlCadastro.Controls.Add(this.txtNomeAluno);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.txtCPFAluno);
            this.pnlCadastro.Controls.Add(this.txtDataNascAluno);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.txtEnderecoAluno);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.txtTelefoneAluno);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlCadastro.Location = new System.Drawing.Point(0, 60);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(350, 390);
            this.pnlCadastro.TabIndex = 4;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(130, 190);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(200, 24);
            this.cbCurso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(20, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turma:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtNomeAluno.Location = new System.Drawing.Point(130, 20);
            this.txtNomeAluno.MaxLength = 50;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(200, 21);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPF:";
            // 
            // txtCPFAluno
            // 
            this.txtCPFAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtCPFAluno.Location = new System.Drawing.Point(130, 88);
            this.txtCPFAluno.Mask = "000.000.000-00";
            this.txtCPFAluno.Name = "txtCPFAluno";
            this.txtCPFAluno.Size = new System.Drawing.Size(84, 21);
            this.txtCPFAluno.TabIndex = 3;
            // 
            // txtDataNascAluno
            // 
            this.txtDataNascAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtDataNascAluno.Location = new System.Drawing.Point(130, 54);
            this.txtDataNascAluno.Mask = "00/00/0000";
            this.txtDataNascAluno.Name = "txtDataNascAluno";
            this.txtDataNascAluno.Size = new System.Drawing.Size(63, 21);
            this.txtDataNascAluno.TabIndex = 2;
            this.txtDataNascAluno.ValidatingType = typeof(System.DateTime);
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtEnderecoAluno.Location = new System.Drawing.Point(130, 122);
            this.txtEnderecoAluno.MaxLength = 50;
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(200, 21);
            this.txtEnderecoAluno.TabIndex = 4;
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtTelefoneAluno.Location = new System.Drawing.Point(130, 156);
            this.txtTelefoneAluno.Mask = "(99) 00000-0000";
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(84, 21);
            this.txtTelefoneAluno.TabIndex = 5;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.White;
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnDeletar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 450);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1000, 100);
            this.pnlBotoes.TabIndex = 6;
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
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(682, 33);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 33);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // errAluno
            // 
            this.errAluno.ContainerControl = this;
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
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data Nasc.";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // ederecoDataGridViewTextBoxColumn
            // 
            this.ederecoDataGridViewTextBoxColumn.DataPropertyName = "Edereco";
            this.ederecoDataGridViewTextBoxColumn.HeaderText = "Edereco";
            this.ederecoDataGridViewTextBoxColumn.Name = "ederecoDataGridViewTextBoxColumn";
            this.ederecoDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // turmaDataGridViewTextBoxColumn
            // 
            this.turmaDataGridViewTextBoxColumn.DataPropertyName = "Turma";
            this.turmaDataGridViewTextBoxColumn.HeaderText = "Turma";
            this.turmaDataGridViewTextBoxColumn.Name = "turmaDataGridViewTextBoxColumn";
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aluno";
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.Aluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.MaskedTextBox txtTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox txtDataNascAluno;
        private System.Windows.Forms.TextBox txtEnderecoAluno;
        private System.Windows.Forms.ErrorProvider errAluno;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPFAluno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ederecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaDataGridViewTextBoxColumn;
    }
}