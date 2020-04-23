namespace SistemaEscolar.Views
{
    partial class CadastroAluno
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
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCadastroAluno = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlCadAluno = new System.Windows.Forms.Panel();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtDataNascAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoAluno = new System.Windows.Forms.TextBox();
            this.txtTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.errAluno = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCadastroAluno.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Aluno";
            // 
            // pnlCadastroAluno
            // 
            this.pnlCadastroAluno.Controls.Add(this.pnlBotoes);
            this.pnlCadastroAluno.Controls.Add(this.pnlCadAluno);
            this.pnlCadastroAluno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCadastroAluno.Location = new System.Drawing.Point(0, 66);
            this.pnlCadastroAluno.Name = "pnlCadastroAluno";
            this.pnlCadastroAluno.Size = new System.Drawing.Size(800, 384);
            this.pnlCadastroAluno.TabIndex = 2;
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
            this.pnlBotoes.TabIndex = 6;
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
            // pnlCadAluno
            // 
            this.pnlCadAluno.Controls.Add(this.cbCurso);
            this.pnlCadAluno.Controls.Add(this.label1);
            this.pnlCadAluno.Controls.Add(this.label6);
            this.pnlCadAluno.Controls.Add(this.txtNomeAluno);
            this.pnlCadAluno.Controls.Add(this.label7);
            this.pnlCadAluno.Controls.Add(this.label2);
            this.pnlCadAluno.Controls.Add(this.txtCPFAluno);
            this.pnlCadAluno.Controls.Add(this.txtDataNascAluno);
            this.pnlCadAluno.Controls.Add(this.label3);
            this.pnlCadAluno.Controls.Add(this.txtEnderecoAluno);
            this.pnlCadAluno.Controls.Add(this.label4);
            this.pnlCadAluno.Controls.Add(this.txtTelefoneAluno);
            this.pnlCadAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadAluno.Enabled = false;
            this.pnlCadAluno.Location = new System.Drawing.Point(0, 0);
            this.pnlCadAluno.Name = "pnlCadAluno";
            this.pnlCadAluno.Size = new System.Drawing.Size(800, 384);
            this.pnlCadAluno.TabIndex = 4;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(153, 57);
            this.txtNomeAluno.MaxLength = 50;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(200, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // txtDataNascAluno
            // 
            this.txtDataNascAluno.Location = new System.Drawing.Point(153, 91);
            this.txtDataNascAluno.Mask = "00/00/0000";
            this.txtDataNascAluno.Name = "txtDataNascAluno";
            this.txtDataNascAluno.Size = new System.Drawing.Size(63, 20);
            this.txtDataNascAluno.TabIndex = 2;
            this.txtDataNascAluno.ValidatingType = typeof(System.DateTime);
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.Location = new System.Drawing.Point(153, 159);
            this.txtEnderecoAluno.MaxLength = 50;
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(200, 20);
            this.txtEnderecoAluno.TabIndex = 1;
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Location = new System.Drawing.Point(153, 193);
            this.txtTelefoneAluno.Mask = "(99) 00000-0000";
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(84, 20);
            this.txtTelefoneAluno.TabIndex = 2;
            // 
            // errAluno
            // 
            this.errAluno.ContainerControl = this;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(153, 227);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(200, 21);
            this.cbCurso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turma:";
            // 
            // txtCPFAluno
            // 
            this.txtCPFAluno.Location = new System.Drawing.Point(153, 125);
            this.txtCPFAluno.Mask = "000.000.000-00";
            this.txtCPFAluno.Name = "txtCPFAluno";
            this.txtCPFAluno.Size = new System.Drawing.Size(84, 20);
            this.txtCPFAluno.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPF:";
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCadastroAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCadastroAluno.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadAluno.ResumeLayout(false);
            this.pnlCadAluno.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCadastroAluno;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.MaskedTextBox txtTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox txtDataNascAluno;
        private System.Windows.Forms.TextBox txtEnderecoAluno;
        private System.Windows.Forms.ErrorProvider errAluno;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPFAluno;
    }
}