namespace SistemaEscolar.Views
{
    partial class SistemaEscolar
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
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnCurso = new MetroFramework.Controls.MetroButton();
            this.btnTurma = new MetroFramework.Controls.MetroButton();
            this.btnDisciplina = new MetroFramework.Controls.MetroButton();
            this.btnProfessor = new MetroFramework.Controls.MetroButton();
            this.btnAluno = new MetroFramework.Controls.MetroButton();
            this.btnAvalicao = new MetroFramework.Controls.MetroButton();
            this.btnNotas = new MetroFramework.Controls.MetroButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblSistemaEscolar = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnNotas);
            this.pnlMenu.Controls.Add(this.btnAvalicao);
            this.pnlMenu.Controls.Add(this.btnAluno);
            this.pnlMenu.Controls.Add(this.btnProfessor);
            this.pnlMenu.Controls.Add(this.btnDisciplina);
            this.pnlMenu.Controls.Add(this.btnTurma);
            this.pnlMenu.Controls.Add(this.btnCurso);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(20, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMenu.Size = new System.Drawing.Size(200, 520);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(220, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 520);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::SistemaEscolar.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(5, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.picLogo.Size = new System.Drawing.Size(190, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 152);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(0, 197);
            this.btnCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(200, 40);
            this.btnCurso.TabIndex = 3;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseSelectable = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Location = new System.Drawing.Point(0, 242);
            this.btnTurma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(200, 40);
            this.btnTurma.TabIndex = 3;
            this.btnTurma.Text = "Turma";
            this.btnTurma.UseSelectable = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Location = new System.Drawing.Point(0, 287);
            this.btnDisciplina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(200, 40);
            this.btnDisciplina.TabIndex = 3;
            this.btnDisciplina.Text = "Disciplina";
            this.btnDisciplina.UseSelectable = true;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(0, 332);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(200, 40);
            this.btnProfessor.TabIndex = 3;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseSelectable = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(0, 377);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(200, 40);
            this.btnAluno.TabIndex = 3;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseSelectable = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnAvalicao
            // 
            this.btnAvalicao.Location = new System.Drawing.Point(0, 422);
            this.btnAvalicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvalicao.Name = "btnAvalicao";
            this.btnAvalicao.Size = new System.Drawing.Size(200, 40);
            this.btnAvalicao.TabIndex = 3;
            this.btnAvalicao.Text = "Avaliação";
            this.btnAvalicao.UseSelectable = true;
            this.btnAvalicao.Click += new System.EventHandler(this.btnAvalicao_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(0, 467);
            this.btnNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(200, 40);
            this.btnNotas.TabIndex = 3;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseSelectable = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblSistemaEscolar);
            this.pnlLogo.Controls.Add(this.lblAutor);
            this.pnlLogo.Controls.Add(this.imgLogo);
            this.pnlLogo.Location = new System.Drawing.Point(122, 96);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(516, 328);
            this.pnlLogo.TabIndex = 3;
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
            this.lblAutor.Size = new System.Drawing.Size(93, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "© 2020 Tym";
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
            // SistemaEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SistemaEscolar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SISTEMA ESCOLAR";
            this.Load += new System.EventHandler(this.SistemaEscolar_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroButton btnAluno;
        private MetroFramework.Controls.MetroButton btnProfessor;
        private MetroFramework.Controls.MetroButton btnDisciplina;
        private MetroFramework.Controls.MetroButton btnTurma;
        private MetroFramework.Controls.MetroButton btnCurso;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnNotas;
        private MetroFramework.Controls.MetroButton btnAvalicao;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblSistemaEscolar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}