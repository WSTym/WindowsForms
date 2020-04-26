namespace SistemaEscolar.Views
{
    partial class Avalicacao
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
            this.errAvaliacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDataAvaliacao = new System.Windows.Forms.MaskedTextBox();
            this.txtValorAvaliacao = new System.Windows.Forms.TextBox();
            this.txtTemaAvalicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlCadAvaliacao = new System.Windows.Forms.Panel();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errAvaliacao)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadAvaliacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errAvaliacao
            // 
            this.errAvaliacao.ContainerControl = this;
            // 
            // txtDataAvaliacao
            // 
            this.txtDataAvaliacao.Location = new System.Drawing.Point(153, 124);
            this.txtDataAvaliacao.Mask = "00/00/0000";
            this.txtDataAvaliacao.Name = "txtDataAvaliacao";
            this.txtDataAvaliacao.Size = new System.Drawing.Size(63, 20);
            this.txtDataAvaliacao.TabIndex = 2;
            this.txtDataAvaliacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorAvaliacao
            // 
            this.txtValorAvaliacao.Location = new System.Drawing.Point(153, 159);
            this.txtValorAvaliacao.MaxLength = 50;
            this.txtValorAvaliacao.Name = "txtValorAvaliacao";
            this.txtValorAvaliacao.Size = new System.Drawing.Size(35, 20);
            this.txtValorAvaliacao.TabIndex = 1;
            // 
            // txtTemaAvalicao
            // 
            this.txtTemaAvalicao.Location = new System.Drawing.Point(153, 91);
            this.txtTemaAvalicao.MaxLength = 50;
            this.txtTemaAvalicao.Name = "txtTemaAvalicao";
            this.txtTemaAvalicao.Size = new System.Drawing.Size(200, 20);
            this.txtTemaAvalicao.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor:";
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
            this.pnlMain.Controls.Add(this.pnlCadAvaliacao);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 384);
            this.pnlMain.TabIndex = 6;
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
            // pnlCadAvaliacao
            // 
            this.pnlCadAvaliacao.Controls.Add(this.cbDisciplina);
            this.pnlCadAvaliacao.Controls.Add(this.txtDataAvaliacao);
            this.pnlCadAvaliacao.Controls.Add(this.txtValorAvaliacao);
            this.pnlCadAvaliacao.Controls.Add(this.txtTemaAvalicao);
            this.pnlCadAvaliacao.Controls.Add(this.label1);
            this.pnlCadAvaliacao.Controls.Add(this.label6);
            this.pnlCadAvaliacao.Controls.Add(this.label2);
            this.pnlCadAvaliacao.Controls.Add(this.label3);
            this.pnlCadAvaliacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadAvaliacao.Location = new System.Drawing.Point(0, 0);
            this.pnlCadAvaliacao.Name = "pnlCadAvaliacao";
            this.pnlCadAvaliacao.Size = new System.Drawing.Size(800, 384);
            this.pnlCadAvaliacao.TabIndex = 8;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(153, 57);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(200, 21);
            this.cbDisciplina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Avaliação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 5;
            // 
            // CadastroAvalicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroAvalicacao";
            this.Text = "CadastroAvalicacao";
            this.Load += new System.EventHandler(this.CadastroAvalicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errAvaliacao)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadAvaliacao.ResumeLayout(false);
            this.pnlCadAvaliacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errAvaliacao;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadAvaliacao;
        private System.Windows.Forms.MaskedTextBox txtDataAvaliacao;
        private System.Windows.Forms.TextBox txtValorAvaliacao;
        private System.Windows.Forms.TextBox txtTemaAvalicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDisciplina;
    }
}