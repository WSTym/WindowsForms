﻿namespace SistemaEscolar.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCadastroAluno = new System.Windows.Forms.Panel();
            this.pnlCadAluno = new System.Windows.Forms.Panel();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtDataNascAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoAluno = new System.Windows.Forms.TextBox();
            this.txtTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.actionButtonsShort1 = new SistemaEscolar.ActionButtonsShort();
            this.panel1.SuspendLayout();
            this.pnlCadastroAluno.SuspendLayout();
            this.pnlCadAluno.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 165);
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
            this.pnlCadastroAluno.Controls.Add(this.actionButtonsShort1);
            this.pnlCadastroAluno.Controls.Add(this.pnlCadAluno);
            this.pnlCadastroAluno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCadastroAluno.Location = new System.Drawing.Point(0, 66);
            this.pnlCadastroAluno.Name = "pnlCadastroAluno";
            this.pnlCadastroAluno.Size = new System.Drawing.Size(800, 384);
            this.pnlCadastroAluno.TabIndex = 2;
            // 
            // pnlCadAluno
            // 
            this.pnlCadAluno.Controls.Add(this.label1);
            this.pnlCadAluno.Controls.Add(this.txtNomeAluno);
            this.pnlCadAluno.Controls.Add(this.label2);
            this.pnlCadAluno.Controls.Add(this.txtDataNascAluno);
            this.pnlCadAluno.Controls.Add(this.label3);
            this.pnlCadAluno.Controls.Add(this.txtEnderecoAluno);
            this.pnlCadAluno.Controls.Add(this.label4);
            this.pnlCadAluno.Controls.Add(this.txtTelefoneAluno);
            this.pnlCadAluno.Controls.Add(this.label6);
            this.pnlCadAluno.Controls.Add(this.txtMatricula);
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
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(200, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // txtDataNascAluno
            // 
            this.txtDataNascAluno.Location = new System.Drawing.Point(153, 92);
            this.txtDataNascAluno.Mask = "00/00/0000";
            this.txtDataNascAluno.Name = "txtDataNascAluno";
            this.txtDataNascAluno.Size = new System.Drawing.Size(63, 20);
            this.txtDataNascAluno.TabIndex = 2;
            this.txtDataNascAluno.ValidatingType = typeof(System.DateTime);
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.Location = new System.Drawing.Point(153, 127);
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(200, 20);
            this.txtEnderecoAluno.TabIndex = 1;
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Location = new System.Drawing.Point(153, 162);
            this.txtTelefoneAluno.Mask = "(99) 00000-0000";
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(84, 20);
            this.txtTelefoneAluno.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(153, 197);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // actionButtonsShort1
            // 
            this.actionButtonsShort1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionButtonsShort1.Location = new System.Drawing.Point(0, 284);
            this.actionButtonsShort1.Name = "actionButtonsShort1";
            this.actionButtonsShort1.Size = new System.Drawing.Size(800, 100);
            this.actionButtonsShort1.TabIndex = 3;
            this.actionButtonsShort1.Load += new System.EventHandler(this.actionButtonsShort1_Load);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCadastroAluno.ResumeLayout(false);
            this.pnlCadAluno.ResumeLayout(false);
            this.pnlCadAluno.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txtTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox txtDataNascAluno;
        private System.Windows.Forms.TextBox txtEnderecoAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label6;
        private ActionButtonsShort actionButtonsShort1;
        public System.Windows.Forms.Panel pnlCadAluno;
    }
}