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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaEscolar));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSobre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblSistemaEscolar = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnAvaliação = new System.Windows.Forms.Button();
            this.btnDisciplina = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSobre.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.Controls.Add(this.pnlMain);
            this.pnlContent.Controls.Add(this.pnlTitleBar);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 650);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlSobre);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 550);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlSobre
            // 
            this.pnlSobre.Controls.Add(this.label1);
            this.pnlSobre.Controls.Add(this.label2);
            this.pnlSobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSobre.Location = new System.Drawing.Point(0, 0);
            this.pnlSobre.Name = "pnlSobre";
            this.pnlSobre.Size = new System.Drawing.Size(1000, 550);
            this.pnlSobre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(352, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo(a)!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(32, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 259);
            this.label2.TabIndex = 1;
            this.label2.Text = "CRUD Sistema Escolar \r\n\r\nVersão 1.0 \r\n\r\n© 2020 Tym \r\n\r\nTodos os direitos reservad" +
    "os";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTitleBar.Controls.Add(this.lblSistemaEscolar);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 20);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1000, 80);
            this.pnlTitleBar.TabIndex = 3;
            // 
            // lblSistemaEscolar
            // 
            this.lblSistemaEscolar.AutoSize = true;
            this.lblSistemaEscolar.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEscolar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSistemaEscolar.Location = new System.Drawing.Point(278, 8);
            this.lblSistemaEscolar.Name = "lblSistemaEscolar";
            this.lblSistemaEscolar.Size = new System.Drawing.Size(444, 65);
            this.lblSistemaEscolar.TabIndex = 0;
            this.lblSistemaEscolar.Text = "Sistema Escolar";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlTopBar.Controls.Add(this.btnMinimizar);
            this.pnlTopBar.Controls.Add(this.btnFechar);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlTopBar.Size = new System.Drawing.Size(1000, 20);
            this.pnlTopBar.TabIndex = 5;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SistemaEscolar.Properties.Resources.minus_16;
            this.btnMinimizar.Location = new System.Drawing.Point(950, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::SistemaEscolar.Properties.Resources.x_mark_16;
            this.btnFechar.Location = new System.Drawing.Point(974, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(16, 16);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAutor.Location = new System.Drawing.Point(5, 610);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(190, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "© 2020 Tym";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMenu.Controls.Add(this.pnlIndicador);
            this.pnlMenu.Controls.Add(this.lblAutor);
            this.pnlMenu.Controls.Add(this.btnAluno);
            this.pnlMenu.Controls.Add(this.btnProfessor);
            this.pnlMenu.Controls.Add(this.btnNotas);
            this.pnlMenu.Controls.Add(this.btnAvaliação);
            this.pnlMenu.Controls.Add(this.btnDisciplina);
            this.pnlMenu.Controls.Add(this.btnTurma);
            this.pnlMenu.Controls.Add(this.btnCurso);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.imgLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.pnlMenu.Size = new System.Drawing.Size(200, 650);
            this.pnlMenu.TabIndex = 4;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlIndicador.Location = new System.Drawing.Point(8, 169);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(10, 40);
            this.pnlIndicador.TabIndex = 0;
            // 
            // btnAluno
            // 
            this.btnAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Image = global::SistemaEscolar.Properties.Resources.student_24;
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(20, 512);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(175, 40);
            this.btnAluno.TabIndex = 8;
            this.btnAluno.Text = "  Aluno";
            this.btnAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Image = global::SistemaEscolar.Properties.Resources.lady_teacher_24;
            this.btnProfessor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessor.Location = new System.Drawing.Point(20, 463);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(175, 40);
            this.btnProfessor.TabIndex = 7;
            this.btnProfessor.Text = "  Professor";
            this.btnProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Image = global::SistemaEscolar.Properties.Resources.a_24;
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(20, 414);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(175, 40);
            this.btnNotas.TabIndex = 6;
            this.btnNotas.Text = "  Notas";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnAvaliação
            // 
            this.btnAvaliação.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaliação.FlatAppearance.BorderSize = 0;
            this.btnAvaliação.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAvaliação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaliação.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliação.ForeColor = System.Drawing.Color.White;
            this.btnAvaliação.Image = global::SistemaEscolar.Properties.Resources.report_3_24;
            this.btnAvaliação.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvaliação.Location = new System.Drawing.Point(20, 365);
            this.btnAvaliação.Name = "btnAvaliação";
            this.btnAvaliação.Size = new System.Drawing.Size(175, 40);
            this.btnAvaliação.TabIndex = 5;
            this.btnAvaliação.Text = "  Avaliação";
            this.btnAvaliação.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvaliação.UseVisualStyleBackColor = true;
            this.btnAvaliação.Click += new System.EventHandler(this.btnAvaliacao_Click);
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisciplina.FlatAppearance.BorderSize = 0;
            this.btnDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisciplina.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisciplina.ForeColor = System.Drawing.Color.White;
            this.btnDisciplina.Image = global::SistemaEscolar.Properties.Resources.literature_24;
            this.btnDisciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisciplina.Location = new System.Drawing.Point(20, 316);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(175, 40);
            this.btnDisciplina.TabIndex = 4;
            this.btnDisciplina.Text = "  Disciplina";
            this.btnDisciplina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisciplina.UseVisualStyleBackColor = true;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.ForeColor = System.Drawing.Color.White;
            this.btnTurma.Image = global::SistemaEscolar.Properties.Resources.group_24;
            this.btnTurma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurma.Location = new System.Drawing.Point(20, 264);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(175, 40);
            this.btnTurma.TabIndex = 3;
            this.btnTurma.Text = "  Turma";
            this.btnTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurso.FlatAppearance.BorderSize = 0;
            this.btnCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso.ForeColor = System.Drawing.Color.White;
            this.btnCurso.Image = global::SistemaEscolar.Properties.Resources.capelo_24;
            this.btnCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurso.Location = new System.Drawing.Point(20, 218);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(175, 40);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "  Curso";
            this.btnCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::SistemaEscolar.Properties.Resources.home_5_24;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(20, 169);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(175, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "  Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Image = global::SistemaEscolar.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(5, 20);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(190, 130);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // SistemaEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SistemaEscolar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar";
            this.pnlContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlSobre.ResumeLayout(false);
            this.pnlSobre.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSistemaEscolar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnAvaliação;
        private System.Windows.Forms.Button btnDisciplina;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSobre;
    }
}