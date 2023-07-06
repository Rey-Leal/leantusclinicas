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
    public partial class FrmAssinaturas : Form
    {
        public String consultas, recibos, outros;

        public FrmAssinaturas()
        {
            InitializeComponent();
        }

        private void FrmAssinaturas_Load(object sender, EventArgs e)
        {
            try
            {
                List<String> assinaturas = new List<string>();
                assinaturas = Controle.BuscaAssinaturas();
                txtConsultas.Text = assinaturas[0];
                txtRecibos.Text = assinaturas[1];
                txtOutros.Text = assinaturas[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LimparCampos()
        {
            txtConsultas.Clear();
            txtRecibos.Clear();
            txtOutros.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!((txtConsultas.Text.Equals("")) && (txtRecibos.Text.Equals("")) && (txtOutros.Text.Equals(""))))
            {
                try
                {
                    consultas = txtConsultas.Text;
                    recibos = txtRecibos.Text;
                    outros = txtOutros.Text;
                    String salva = Controle.SalvaAssinaturas(consultas, recibos, outros);
                    MessageBox.Show(salva, "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha todas assinaturas", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAssinaturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmAssinaturas");
        }
    }
}
