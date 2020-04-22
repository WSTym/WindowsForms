using SistemaEscolar.Models;
using SistemaEscolar.Models.Context;
using SistemaEscolar.Views.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Views
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        private void CadastroTurma_Load(object sender, EventArgs e)
        {
            pnlCadTurma.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlCadTurma.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCadastrar.Enabled = true;
            cbCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
            CadastroTurma_Load(new object(), new EventArgs());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //if (FormHelper.CheckEmptyField(cbCurso, errTurma)) return;
            if (FormHelper.CheckEmptyField(txtAnoTurma, errTurma)) return;
            if (FormHelper.CheckEmptyField(rbSemestre1, errTurma)) return;
            if (FormHelper.CheckEmptyField(cbHorario, errTurma)) return;

            using (Context context = new Context())
            {
                context.Turmas.Add(new Turma()
                {
                    //Curso = cbCurso.Text,
                    Ano = int.Parse(txtAnoTurma.Text),
                    Horario = cbHorario.Text
                });
            }
        }

        #region Limpa os TextBoxes
        private void CleanForm()
        {
            FormHelper.SetTextEmpty(this);
        }

        #endregion

        private void txtAnoTurma_TextChanged(object sender, EventArgs e)
        {
            txtAnoTurma.Text = Regex.Replace(txtAnoTurma.Text, "[^0-9]", "");
        }
    }
}
