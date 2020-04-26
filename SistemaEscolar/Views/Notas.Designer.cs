namespace SistemaEscolar.Views
{
    partial class Notas
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
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCadNotas = new System.Windows.Forms.Panel();
            this.txtNotaAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkFalta = new System.Windows.Forms.CheckBox();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.cbAvaliacao = new System.Windows.Forms.ComboBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCadNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTurma
            // 
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(153, 57);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(200, 21);
            this.cbTurma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lançamento de Notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Avaliação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Disciplina:";
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
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBotoes);
            this.pnlMain.Controls.Add(this.pnlCadNotas);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 384);
            this.pnlMain.TabIndex = 8;
            // 
            // pnlCadNotas
            // 
            this.pnlCadNotas.Controls.Add(this.txtNotaAluno);
            this.pnlCadNotas.Controls.Add(this.label7);
            this.pnlCadNotas.Controls.Add(this.chkFalta);
            this.pnlCadNotas.Controls.Add(this.cbAluno);
            this.pnlCadNotas.Controls.Add(this.cbAvaliacao);
            this.pnlCadNotas.Controls.Add(this.cbDisciplina);
            this.pnlCadNotas.Controls.Add(this.cbTurma);
            this.pnlCadNotas.Controls.Add(this.label1);
            this.pnlCadNotas.Controls.Add(this.label4);
            this.pnlCadNotas.Controls.Add(this.label6);
            this.pnlCadNotas.Controls.Add(this.label2);
            this.pnlCadNotas.Controls.Add(this.label3);
            this.pnlCadNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadNotas.Location = new System.Drawing.Point(0, 0);
            this.pnlCadNotas.Name = "pnlCadNotas";
            this.pnlCadNotas.Size = new System.Drawing.Size(800, 384);
            this.pnlCadNotas.TabIndex = 8;
            // 
            // txtNotaAluno
            // 
            this.txtNotaAluno.Location = new System.Drawing.Point(153, 189);
            this.txtNotaAluno.MaxLength = 50;
            this.txtNotaAluno.Name = "txtNotaAluno";
            this.txtNotaAluno.Size = new System.Drawing.Size(35, 20);
            this.txtNotaAluno.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nota:";
            // 
            // chkFalta
            // 
            this.chkFalta.AutoSize = true;
            this.chkFalta.Location = new System.Drawing.Point(153, 225);
            this.chkFalta.Name = "chkFalta";
            this.chkFalta.Size = new System.Drawing.Size(15, 14);
            this.chkFalta.TabIndex = 6;
            this.chkFalta.UseVisualStyleBackColor = true;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(153, 156);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(200, 21);
            this.cbAluno.TabIndex = 5;
            // 
            // cbAvaliacao
            // 
            this.cbAvaliacao.FormattingEnabled = true;
            this.cbAvaliacao.Location = new System.Drawing.Point(153, 123);
            this.cbAvaliacao.Name = "cbAvaliacao";
            this.cbAvaliacao.Size = new System.Drawing.Size(200, 21);
            this.cbAvaliacao.TabIndex = 5;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(153, 90);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(200, 21);
            this.cbDisciplina.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Falta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aluno:";
            // 
            // errNotas
            // 
            this.errNotas.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 7;
            // 
            // CadastroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroNotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.CadastroNotas_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlCadNotas.ResumeLayout(false);
            this.pnlCadNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCadNotas;
        private System.Windows.Forms.CheckBox chkFalta;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.ComboBox cbAvaliacao;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errNotas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNotaAluno;
        private System.Windows.Forms.Label label7;
    }
}