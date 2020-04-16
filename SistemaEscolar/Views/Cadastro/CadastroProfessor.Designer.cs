namespace SistemaEscolar.Views
{
    partial class CadastroProfessor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlCadProfessor = new System.Windows.Forms.Panel();
            this.txtTelefoneProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtCapacitacao = new System.Windows.Forms.TextBox();
            this.txtEnderecoProfessor = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlCadProfessor.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço:";
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
            this.label5.Size = new System.Drawing.Size(420, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Professor";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBotoes);
            this.pnlMain.Controls.Add(this.pnlCadProfessor);
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
            // pnlCadProfessor
            // 
            this.pnlCadProfessor.Controls.Add(this.txtTelefoneProfessor);
            this.pnlCadProfessor.Controls.Add(this.txtDataNascProfessor);
            this.pnlCadProfessor.Controls.Add(this.txtCapacitacao);
            this.pnlCadProfessor.Controls.Add(this.txtEnderecoProfessor);
            this.pnlCadProfessor.Controls.Add(this.txtNomeProfessor);
            this.pnlCadProfessor.Controls.Add(this.label1);
            this.pnlCadProfessor.Controls.Add(this.label4);
            this.pnlCadProfessor.Controls.Add(this.label6);
            this.pnlCadProfessor.Controls.Add(this.label2);
            this.pnlCadProfessor.Controls.Add(this.label3);
            this.pnlCadProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadProfessor.Location = new System.Drawing.Point(0, 0);
            this.pnlCadProfessor.Name = "pnlCadProfessor";
            this.pnlCadProfessor.Size = new System.Drawing.Size(800, 384);
            this.pnlCadProfessor.TabIndex = 8;
            // 
            // txtTelefoneProfessor
            // 
            this.txtTelefoneProfessor.Location = new System.Drawing.Point(153, 162);
            this.txtTelefoneProfessor.Mask = "(99) 00000-0000";
            this.txtTelefoneProfessor.Name = "txtTelefoneProfessor";
            this.txtTelefoneProfessor.Size = new System.Drawing.Size(84, 20);
            this.txtTelefoneProfessor.TabIndex = 2;
            // 
            // txtDataNascProfessor
            // 
            this.txtDataNascProfessor.Location = new System.Drawing.Point(153, 92);
            this.txtDataNascProfessor.Mask = "00/00/0000";
            this.txtDataNascProfessor.Name = "txtDataNascProfessor";
            this.txtDataNascProfessor.Size = new System.Drawing.Size(63, 20);
            this.txtDataNascProfessor.TabIndex = 2;
            this.txtDataNascProfessor.ValidatingType = typeof(System.DateTime);
            // 
            // txtCapacitacao
            // 
            this.txtCapacitacao.Location = new System.Drawing.Point(153, 197);
            this.txtCapacitacao.MaxLength = 50;
            this.txtCapacitacao.Name = "txtCapacitacao";
            this.txtCapacitacao.Size = new System.Drawing.Size(200, 20);
            this.txtCapacitacao.TabIndex = 1;
            // 
            // txtEnderecoProfessor
            // 
            this.txtEnderecoProfessor.Location = new System.Drawing.Point(153, 127);
            this.txtEnderecoProfessor.MaxLength = 50;
            this.txtEnderecoProfessor.Name = "txtEnderecoProfessor";
            this.txtEnderecoProfessor.Size = new System.Drawing.Size(200, 20);
            this.txtEnderecoProfessor.TabIndex = 1;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(153, 57);
            this.txtNomeProfessor.MaxLength = 50;
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(200, 20);
            this.txtNomeProfessor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Capacitação:";
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfesor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCadProfessor.ResumeLayout(false);
            this.pnlCadProfessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MaskedTextBox txtTelefoneProfessor;
        private System.Windows.Forms.MaskedTextBox txtDataNascProfessor;
        private System.Windows.Forms.TextBox txtEnderecoProfessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.TextBox txtCapacitacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadProfessor;
    }
}