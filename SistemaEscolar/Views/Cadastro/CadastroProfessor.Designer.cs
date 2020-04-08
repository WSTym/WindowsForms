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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelefoneProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoProfessor = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTelefoneProfessor);
            this.panel2.Controls.Add(this.txtDataNascProfessor);
            this.panel2.Controls.Add(this.txtEnderecoProfessor);
            this.panel2.Controls.Add(this.txtNomeProfessor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 384);
            this.panel2.TabIndex = 4;
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
            // txtEnderecoProfessor
            // 
            this.txtEnderecoProfessor.Location = new System.Drawing.Point(153, 127);
            this.txtEnderecoProfessor.Name = "txtEnderecoProfessor";
            this.txtEnderecoProfessor.Size = new System.Drawing.Size(200, 20);
            this.txtEnderecoProfessor.TabIndex = 1;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(153, 57);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(200, 20);
            this.txtNomeProfessor.TabIndex = 1;
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtTelefoneProfessor;
        private System.Windows.Forms.MaskedTextBox txtDataNascProfessor;
        private System.Windows.Forms.TextBox txtEnderecoProfessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
    }
}