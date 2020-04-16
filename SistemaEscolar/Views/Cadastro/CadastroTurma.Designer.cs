namespace SistemaEscolar.Views
{
    partial class CadastroTurma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlCadTurma = new System.Windows.Forms.Panel();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.rbSemestre1 = new System.Windows.Forms.RadioButton();
            this.rbSemestre2 = new System.Windows.Forms.RadioButton();
            this.txtAnoTurma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ano:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Turma";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBotoes);
            this.pnlMain.Controls.Add(this.pnlCadTurma);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 384);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 284);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(800, 100);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(363, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(460, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(266, 24);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlCadTurma
            // 
            this.pnlCadTurma.Controls.Add(this.cbCurso);
            this.pnlCadTurma.Controls.Add(this.cbHorario);
            this.pnlCadTurma.Controls.Add(this.rbSemestre1);
            this.pnlCadTurma.Controls.Add(this.rbSemestre2);
            this.pnlCadTurma.Controls.Add(this.txtAnoTurma);
            this.pnlCadTurma.Controls.Add(this.label1);
            this.pnlCadTurma.Controls.Add(this.label4);
            this.pnlCadTurma.Controls.Add(this.label3);
            this.pnlCadTurma.Controls.Add(this.label2);
            this.pnlCadTurma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadTurma.Location = new System.Drawing.Point(0, 0);
            this.pnlCadTurma.Name = "pnlCadTurma";
            this.pnlCadTurma.Size = new System.Drawing.Size(800, 384);
            this.pnlCadTurma.TabIndex = 8;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(153, 52);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(200, 21);
            this.cbCurso.TabIndex = 4;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbHorario.Location = new System.Drawing.Point(153, 168);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(88, 21);
            this.cbHorario.TabIndex = 4;
            // 
            // rbSemestre1
            // 
            this.rbSemestre1.AutoSize = true;
            this.rbSemestre1.Location = new System.Drawing.Point(153, 132);
            this.rbSemestre1.Name = "rbSemestre1";
            this.rbSemestre1.Size = new System.Drawing.Size(31, 17);
            this.rbSemestre1.TabIndex = 3;
            this.rbSemestre1.TabStop = true;
            this.rbSemestre1.Text = "1";
            this.rbSemestre1.UseVisualStyleBackColor = true;
            // 
            // rbSemestre2
            // 
            this.rbSemestre2.AutoSize = true;
            this.rbSemestre2.Location = new System.Drawing.Point(190, 132);
            this.rbSemestre2.Name = "rbSemestre2";
            this.rbSemestre2.Size = new System.Drawing.Size(31, 17);
            this.rbSemestre2.TabIndex = 3;
            this.rbSemestre2.TabStop = true;
            this.rbSemestre2.Text = "2";
            this.rbSemestre2.UseVisualStyleBackColor = true;
            // 
            // txtAnoTurma
            // 
            this.txtAnoTurma.Location = new System.Drawing.Point(153, 94);
            this.txtAnoTurma.MaxLength = 4;
            this.txtAnoTurma.Name = "txtAnoTurma";
            this.txtAnoTurma.Size = new System.Drawing.Size(40, 20);
            this.txtAnoTurma.TabIndex = 2;
            this.txtAnoTurma.TextChanged += new System.EventHandler(this.txtAnoTurma_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Semestre:";
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroTurma";
            this.Text = "CadastroTurma";
            this.Load += new System.EventHandler(this.CadastroTurma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadTurma.ResumeLayout(false);
            this.pnlCadTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtAnoTurma;
        private System.Windows.Forms.RadioButton rbSemestre1;
        private System.Windows.Forms.RadioButton rbSemestre2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadTurma;
        private System.Windows.Forms.ComboBox cbCurso;
    }
}