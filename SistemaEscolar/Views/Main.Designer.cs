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
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscaTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
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
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.menuArquivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(77, 25);
            this.menuArquivo.Text = "Arquivo";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 26);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroAluno,
            this.menuCadastroProfessor,
            this.menuCadastroTurma});
            this.menuCadastro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.ShortcutKeyDisplayString = "";
            this.menuCadastro.Size = new System.Drawing.Size(84, 25);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroAluno
            // 
            this.menuCadastroAluno.Name = "menuCadastroAluno";
            this.menuCadastroAluno.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroAluno.Text = "Aluno";
            this.menuCadastroAluno.Click += new System.EventHandler(this.menuCadastroAluno_Click);
            // 
            // menuCadastroProfessor
            // 
            this.menuCadastroProfessor.Name = "menuCadastroProfessor";
            this.menuCadastroProfessor.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroProfessor.Text = "Professor";
            this.menuCadastroProfessor.Click += new System.EventHandler(this.menuCadastroProfessor_Click);
            // 
            // menuCadastroTurma
            // 
            this.menuCadastroTurma.Name = "menuCadastroTurma";
            this.menuCadastroTurma.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroTurma.Text = "Turma";
            this.menuCadastroTurma.Click += new System.EventHandler(this.menuCadastroTurma_Click);
            // 
            // menuBusca
            // 
            this.menuBusca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBuscaAluno,
            this.menuBuscaProfessor,
            this.menuBuscaTurma});
            this.menuBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuBusca.Name = "menuBusca";
            this.menuBusca.Size = new System.Drawing.Size(62, 25);
            this.menuBusca.Text = "Busca";
            // 
            // menuBuscaAluno
            // 
            this.menuBuscaAluno.Name = "menuBuscaAluno";
            this.menuBuscaAluno.Size = new System.Drawing.Size(146, 26);
            this.menuBuscaAluno.Text = "Aluno";
            this.menuBuscaAluno.Click += new System.EventHandler(this.menuBuscaAluno_Click);
            // 
            // menuBuscaProfessor
            // 
            this.menuBuscaProfessor.Name = "menuBuscaProfessor";
            this.menuBuscaProfessor.Size = new System.Drawing.Size(146, 26);
            this.menuBuscaProfessor.Text = "Professor";
            this.menuBuscaProfessor.Click += new System.EventHandler(this.menuBuscaProfessor_Click);
            // 
            // menuBuscaTurma
            // 
            this.menuBuscaTurma.Name = "menuBuscaTurma";
            this.menuBuscaTurma.Size = new System.Drawing.Size(146, 26);
            this.menuBuscaTurma.Text = "Turma";
            this.menuBuscaTurma.Click += new System.EventHandler(this.menuBuscaTurma_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(180, 26);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 451);
            this.pnlMain.TabIndex = 2;
            // 
            // imgFechar
            // 
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
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.PictureBox imgFechar;
    }
}