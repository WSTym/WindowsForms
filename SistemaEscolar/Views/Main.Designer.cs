namespace SistemaEscolar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLancamentoDeNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblSistemaEscolar = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuCadastro,
            this.menuBusca,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pmenuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // menuHome
            // 
            this.menuHome.Image = global::SistemaEscolar.Properties.Resources.home;
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(80, 25);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroCurso,
            this.menuCadastroTurma,
            this.menuCadastroDisciplina,
            this.menuCadastroAvaliacao,
            this.menuCadastroProfessor,
            this.menuCadastroAluno,
            this.menuLancamentoDeNotas});
            this.menuCadastro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuCadastro.Image = global::SistemaEscolar.Properties.Resources.plus;
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.ShortcutKeyDisplayString = "";
            this.menuCadastro.Size = new System.Drawing.Size(100, 25);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroCurso
            // 
            this.menuCadastroCurso.Name = "menuCadastroCurso";
            this.menuCadastroCurso.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroCurso.Text = "Curso";
            this.menuCadastroCurso.Click += new System.EventHandler(this.menuCadastroCurso_Click);
            // 
            // menuCadastroTurma
            // 
            this.menuCadastroTurma.Name = "menuCadastroTurma";
            this.menuCadastroTurma.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroTurma.Text = "Turma";
            this.menuCadastroTurma.Click += new System.EventHandler(this.menuCadastroTurma_Click);
            // 
            // menuCadastroDisciplina
            // 
            this.menuCadastroDisciplina.Name = "menuCadastroDisciplina";
            this.menuCadastroDisciplina.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroDisciplina.Text = "Disciplina";
            this.menuCadastroDisciplina.Click += new System.EventHandler(this.menuCadastroDisciplina_Click);
            // 
            // menuCadastroAvaliacao
            // 
            this.menuCadastroAvaliacao.Name = "menuCadastroAvaliacao";
            this.menuCadastroAvaliacao.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroAvaliacao.Text = "Avaliação";
            this.menuCadastroAvaliacao.Click += new System.EventHandler(this.menuCadastroAvaliacao_Click);
            // 
            // menuCadastroProfessor
            // 
            this.menuCadastroProfessor.Name = "menuCadastroProfessor";
            this.menuCadastroProfessor.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroProfessor.Text = "Professor";
            this.menuCadastroProfessor.Click += new System.EventHandler(this.menuCadastroProfessor_Click);
            // 
            // menuCadastroAluno
            // 
            this.menuCadastroAluno.Name = "menuCadastroAluno";
            this.menuCadastroAluno.Size = new System.Drawing.Size(231, 26);
            this.menuCadastroAluno.Text = "Aluno";
            this.menuCadastroAluno.Click += new System.EventHandler(this.menuCadastroAluno_Click);
            // 
            // menuLancamentoDeNotas
            // 
            this.menuLancamentoDeNotas.Name = "menuLancamentoDeNotas";
            this.menuLancamentoDeNotas.Size = new System.Drawing.Size(231, 26);
            this.menuLancamentoDeNotas.Text = "Lançamento de Notas";
            this.menuLancamentoDeNotas.Click += new System.EventHandler(this.menuLancamentoDeNotas_Click);
            // 
            // menuBusca
            // 
            this.menuBusca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBuscaCurso,
            this.menuBuscaTurma,
            this.menuBuscaDisciplina,
            this.menuBuscaAvaliacao,
            this.menuBuscaProfessor,
            this.menuBuscaAluno});
            this.menuBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuBusca.Image = global::SistemaEscolar.Properties.Resources.find;
            this.menuBusca.Name = "menuBusca";
            this.menuBusca.Size = new System.Drawing.Size(78, 25);
            this.menuBusca.Text = "Busca";
            // 
            // menuBuscaCurso
            // 
            this.menuBuscaCurso.Name = "menuBuscaCurso";
            this.menuBuscaCurso.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaCurso.Text = "Curso";
            this.menuBuscaCurso.Click += new System.EventHandler(this.menuBuscaCurso_Click);
            // 
            // menuBuscaTurma
            // 
            this.menuBuscaTurma.Name = "menuBuscaTurma";
            this.menuBuscaTurma.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaTurma.Text = "Turma";
            this.menuBuscaTurma.Click += new System.EventHandler(this.menuBuscaTurma_Click);
            // 
            // menuBuscaDisciplina
            // 
            this.menuBuscaDisciplina.Name = "menuBuscaDisciplina";
            this.menuBuscaDisciplina.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaDisciplina.Text = "Disciplina";
            this.menuBuscaDisciplina.Click += new System.EventHandler(this.menuBuscaDisciplina_Click);
            // 
            // menuBuscaAvaliacao
            // 
            this.menuBuscaAvaliacao.Name = "menuBuscaAvaliacao";
            this.menuBuscaAvaliacao.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaAvaliacao.Text = "Avaliação";
            this.menuBuscaAvaliacao.Click += new System.EventHandler(this.menuBuscaAvaliacao_Click);
            // 
            // menuBuscaProfessor
            // 
            this.menuBuscaProfessor.Name = "menuBuscaProfessor";
            this.menuBuscaProfessor.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaProfessor.Text = "Professor";
            this.menuBuscaProfessor.Click += new System.EventHandler(this.menuBuscaProfessor_Click);
            // 
            // menuBuscaAluno
            // 
            this.menuBuscaAluno.Name = "menuBuscaAluno";
            this.menuBuscaAluno.Size = new System.Drawing.Size(180, 26);
            this.menuBuscaAluno.Text = "Aluno";
            this.menuBuscaAluno.Click += new System.EventHandler(this.menuBuscaAluno_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSobre});
            this.ajudaToolStripMenuItem.Image = global::SistemaEscolar.Properties.Resources.help;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(121, 26);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 451);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.Controls.Add(this.lblSistemaEscolar);
            this.pnlLogo.Controls.Add(this.lblAutor);
            this.pnlLogo.Controls.Add(this.imgLogo);
            this.pnlLogo.Location = new System.Drawing.Point(142, 58);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(516, 328);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblSistemaEscolar
            // 
            this.lblSistemaEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEscolar.Location = new System.Drawing.Point(0, 147);
            this.lblSistemaEscolar.Name = "lblSistemaEscolar";
            this.lblSistemaEscolar.Size = new System.Drawing.Size(516, 76);
            this.lblSistemaEscolar.TabIndex = 0;
            this.lblSistemaEscolar.Text = "Sistema Escolar ";
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAutor.Location = new System.Drawing.Point(229, 242);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(58, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "by Tym";
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogo.Image = global::SistemaEscolar.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(191, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(135, 130);
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.BackColor = System.Drawing.Color.White;
            this.imgMinimizar.Image = global::SistemaEscolar.Properties.Resources.mnimize;
            this.imgMinimizar.Location = new System.Drawing.Point(735, 2);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMinimizar.TabIndex = 3;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // imgFechar
            // 
            this.imgFechar.BackColor = System.Drawing.Color.White;
            this.imgFechar.Image = global::SistemaEscolar.Properties.Resources.close;
            this.imgFechar.Location = new System.Drawing.Point(765, 2);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(24, 24);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFechar.TabIndex = 3;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroAluno;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProfessor;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroTurma;
        private System.Windows.Forms.ToolStripMenuItem menuBusca;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaAluno;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaProfessor;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaTurma;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.Label lblSistemaEscolar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCurso;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaCurso;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDisciplina;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaDisciplina;
        private System.Windows.Forms.ToolStripMenuItem menuBuscaAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem menuLancamentoDeNotas;
    }
}