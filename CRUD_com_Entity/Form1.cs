using CRUD_com_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Com_Entity
{
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                pessoaBindingSource.DataSource = db.Pessoas.ToList();
            }

            Pessoa pessoa = pessoaBindingSource.Current as Pessoa;
            if (pessoa != null)
            {
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            metroPanel1.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            metroPanel1.Enabled = true;
            pessoaBindingSource.Add(new Pessoa());
            pessoaBindingSource.MoveLast();
            txtNome.Focus();
            btnCadastrar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            metroPanel1.Enabled = true;
            txtNome.Focus();
            btnEditar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Certeza que deseja deletar esta pessoa?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                using (Context db = new Context())
                {
                    Pessoa pessoa = pessoaBindingSource.Current as Pessoa;
                    if (pessoa != null)
                    {
                        if (db.Entry<Pessoa>(pessoa).State == EntityState.Detached)
                            db.Set<Pessoa>().Attach(pessoa);  
                        db.Entry<Pessoa>(pessoa).State = EntityState.Deleted;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Pessoa deletada com sucesso!",";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pessoaBindingSource.RemoveCurrent();
                        metroPanel1.Enabled = false;
                        metroGrid1.Refresh();
                        Form1_Load(sender, e);
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = false;
            pessoaBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Pessoa pessoa = pessoaBindingSource.Current as Pessoa;
                if (txtNome.Text.Length == 0 || txtEmail.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Todos os campos devem ser preenchidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
                else if (pessoa != null)
                    if (db.Entry<Pessoa>(pessoa).State == EntityState.Detached)
                    {
                        db.Set<Pessoa>().Attach(pessoa);
                        if (pessoa.Id == 0)
                            db.Entry<Pessoa>(pessoa).State = EntityState.Added;
                        else
                            db.Entry<Pessoa>(pessoa).State = EntityState.Modified;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Pessoa adicionada com sucesso!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGrid1.Refresh();
                        Form1_Load(sender, e);
                        metroPanel1.Enabled = false;
                    }
            }
        }
    }
}
