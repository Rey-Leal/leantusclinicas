using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeantusClinicas
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
              try
            {
                String relatorio = Controle.ImprimirRelatorio();
                String parametro = Controle.ParametroRelatorio();

                if (relatorio.Equals("RptPessoas"))
                {
                    RptPessoas rptPessoas = new RptPessoas();
                    crvRelatorios.ReportSource = rptPessoas;
                    if (parametro != "")
                    {
                        rptPessoas.RecordSelectionFormula = "{Pessoas.nivel} = " + parametro;
                    }
                    crvRelatorios.Show();
                    this.crvRelatorios.RefreshReport();
                }
                else if (relatorio.Equals("RptIndividual"))
                {
                    RptIndividual rptIndividual = new RptIndividual();
                    crvRelatorios.ReportSource = rptIndividual;
                    if (parametro != "")
                    {
                        rptIndividual.RecordSelectionFormula = "{Pessoas.cpf} = '" + parametro + "'";
                    }
                    crvRelatorios.Show();
                    crvRelatorios.RefreshReport();
                }
                else if (relatorio.Equals("RptConsultas"))
                {
                    RptConsultas rptConsultas = new RptConsultas();
                    crvRelatorios.ReportSource = rptConsultas;
                    if (parametro != "")
                    {
                        rptConsultas.RecordSelectionFormula = "{Consultas.id} = " + parametro;
                    }
                    crvRelatorios.Show();
                    crvRelatorios.RefreshReport();
                }
                else if (relatorio.Equals("RptConsultasPaciente"))
                {
                    RptConsultas rptConsultas = new RptConsultas();
                    crvRelatorios.ReportSource = rptConsultas;
                    if (parametro != "")
                    {
                        rptConsultas.RecordSelectionFormula = "{Consultas.codPaciente} = " + parametro;
                    }
                    crvRelatorios.Show();
                    crvRelatorios.RefreshReport();
                }
                // report
                else if (relatorio.Equals("RptTestes"))
                {
                    wrvRelatorios.LocalReport.ReportEmbeddedResource = "LeantusClinicas.RptTestes.rdlc";
                    wrvRelatorios.Show();
                    wrvRelatorios.RefreshReport();
                }
            }
            catch
            {
                MessageBox.Show("Erro na Impressão", "Leantus Clínicas");
            }
        }
    }
}
