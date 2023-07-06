using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace LeantusClinicas
{
    public partial class FrmCadastroConsultas : Form
    {
        public String paciente, medico;
        public int codPaciente, codMedico;
        public String descConsulta, observacoes, receita;
        public String valor, dtConsulta;

        public FrmCadastroConsultas()
        {
            InitializeComponent();
        }

        private void FrmCadastroConsultas_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList todosNomes = new ArrayList();
                List<BoPessoas> todosMedicos = new List<BoPessoas>();
                todosNomes = Controle.BuscaTodosNomes();
                todosMedicos = Controle.BuscaTodosMedicos();
                for (int i = 0; i < todosNomes.Count; i++)
                {
                    cbxNome.Items.Add(todosNomes[i]);
                }
                for (int i = 0; i < todosMedicos.Count; i++)
                {
                    cbxMedico.Items.Add(todosMedicos[i].Nome);
                }
                dtpDataCadastro.Text = Controle.DataDeAgora().ToString();
                cbxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnImprimir.Enabled = false;
        }

        public void LimparCampos()
        {
            cbxNome.Text = "";
            cbxMedico.Text = "";
            txtDescConsulta.Clear();
            txtObservacoes.Clear();
            txtReceita.Clear();
            mskValor.Clear();
            btnSalvar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmCadastroConsultas");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cbxNome.Text != "") && (cbxMedico.Text != "") && (txtDescConsulta.Text != "") && (txtReceita.Text != "") && (mskValor.Text != ""))
                {
                    paciente = cbxNome.Text;
                    medico = cbxMedico.Text;
                    descConsulta = txtDescConsulta.Text;
                    observacoes = txtObservacoes.Text;
                    receita = txtReceita.Text;
                    valor = mskValor.Text;
                    dtConsulta = Controle.ConverteFormatoData(dtpDataCadastro.Value.ToShortDateString());
                    BoConsultas consulta = new BoConsultas(paciente, medico, dtConsulta, descConsulta, observacoes, receita, valor);
                    String salva = Controle.SalvaConsulta(consulta);
                    MessageBox.Show(salva, "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnImprimir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnImprimir.Focus();
                }
                else
                {
                    MessageBox.Show("Os campos marcados com '*' são de preenchimento obrigatório.", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {            
            try
            {
                String parametro = Controle.BuscaConsultas();
                Controle.AbreRelatorio("RptConsultas", parametro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
