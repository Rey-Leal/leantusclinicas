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
    public partial class FrmListagemIndividual : Form
    {
        public FrmListagemIndividual()
        {
            InitializeComponent();
        }

        private void FrmListagemIndividual_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList todosNomes = new ArrayList();
                todosNomes = Controle.BuscaTodosNomes();
                for (int i = 0; i < todosNomes.Count; i++)
                {
                    cbxNome.Items.Add(todosNomes[i]);
                }
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmListagemIndividual_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmListagemIndividual");
        }

        public void LimparCampos()
        {
            cbxNome.Text = "";
            txtNome.Clear();
            txtRg.Clear();
            mskCpf.Clear();
            mskCpfPesquisa.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            mskCep.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            txtProfissao.Clear();
            txtConvenio.Clear();
            txtEstadoCivil.Clear();
            txtQuemIndicou.Clear();
            mskDataNascimento.Clear();
            dtpDataCadastro.Clear();
            cbxNome.Focus();
        }

        public void PreencheCampos(BoPessoas pessoa)
        {
            txtNome.Text = pessoa.Nome;
            txtRg.Text = pessoa.Rg;
            mskCpf.Text = pessoa.Cpf;
            mskCpfPesquisa.Text = pessoa.Cpf;
            txtRua.Text = pessoa.Rua;
            txtNumero.Text = pessoa.Numero;
            txtBairro.Text = pessoa.Bairro;
            txtComplemento.Text = pessoa.Complemento;
            txtCidade.Text = pessoa.Cidade;
            txtEstado.Text = pessoa.Estado;
            mskCep.Text = pessoa.Cep;
            mskTelefone.Text = pessoa.Telefone;
            mskCelular.Text = pessoa.Celular;
            txtEmail.Text = pessoa.Email;
            txtProfissao.Text = pessoa.Profissao;
            txtConvenio.Text = pessoa.Convenio;
            txtEstadoCivil.Text = pessoa.EstadoCivil;
            txtQuemIndicou.Text = pessoa.QuemIndicou;
            mskDataNascimento.Text = pessoa.DtNascimento;
            dtpDataCadastro.Text = pessoa.DtCadastro;
        }

        private void cbxNome_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                String nome = cbxNome.Text;
                BoPessoas pessoa = Controle.BuscaDadosPorNome(nome);
                PreencheCampos(pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCpfPesquisa.Text.Length == 14)
                {
                    String cpf = mskCpfPesquisa.Text;
                    BoPessoas pessoa = Controle.BuscaDadosPorCpf(cpf);
                    PreencheCampos(pessoa);
                }
                else
                {
                    MessageBox.Show("Preencha o campo CPF corretamente, antes de efetuar a busca.", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCpfPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            String parametro = mskCpf.Text;
            try
            {
                Controle.AbreRelatorio("RptIndividual", parametro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }               
    }
}
