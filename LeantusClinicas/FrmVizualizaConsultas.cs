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
    public partial class FrmVizualizaConsultas : Form
    {
        public String nome, nomeCpf, dtConsulta, id;

        public FrmVizualizaConsultas()
        {
            InitializeComponent();
        }

        private void FrmVizualizaConsultas_Load(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
            try
            {
                List<BoPessoas> todasPessoas = new List<BoPessoas>();
                todasPessoas = Controle.BuscaTodasPessoas();
                for (int i = 0; i < todasPessoas.Count; i++)
                {
                    cbxNome.Items.Add(todasPessoas[i].Nome + " - " + todasPessoas[i].Cpf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVizualizaConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmVizualizaConsultas");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!cbxNome.Equals(""))
            {
                try
                {
                    clbDescConsultas.Items.Clear();
                    nomeCpf = cbxNome.Text;
                    nome = nomeCpf.Substring(0, nomeCpf.Length - 17);
                    btnImprimir.Enabled = true;
                    List<String> consultasCliente = new List<string>();
                    consultasCliente = Controle.ListaConsultasCliente(nome);
                    for (int i = 0; i < consultasCliente.Count; i++)
                    {
                        clbDescConsultas.Items.Add(consultasCliente[i]);
                    }
                    if (clbDescConsultas.Items.Count == 0)
                    {
                        MessageBox.Show("Sem histórico de consultas", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nome é obrigatório!", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clbDescConsultas.Items.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Controle.AbreRelatorio("RptConsultasPaciente", Controle.BuscaIdPeloCpf(nomeCpf.Substring(nomeCpf.Length - 14)));
        }
    }
}
