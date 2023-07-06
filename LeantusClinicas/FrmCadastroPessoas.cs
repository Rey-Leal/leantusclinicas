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
    public partial class FrmCadastroPessoas : Form
    {
        public int nivel;
        public String nome, rg, cpf, rua, bairro, complemento, cidade, estado, cep;
        public String telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou;
        public String dtNascimento, dtCadastro, numero, logon, senha, dataInglesa;

        public FrmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void FrmCadastroPessoas_Load(object sender, EventArgs e)
        {
            dtpDataCadastro.Text = Controle.DataDeAgora().ToString();
            cbxEstadoCivil.SelectedIndex = 0;
            cbxComplemento.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void FrmCadastroPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmCadastroPessoas");
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtRg.Clear();
            mskCpf.Clear();
            txtRua.Clear();
            mskNumero.Clear();
            txtBairro.Clear();
            cbxComplemento.SelectedIndex = 0;
            txtCidade.Clear();
            cbxEstado.SelectedIndex = 0;
            mskCep.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            txtProfissao.Clear();
            txtConvenio.Clear();
            cbxEstadoCivil.SelectedIndex = 0;
            txtQuemIndicou.Clear();
            dtpDataNascimento.Text = Controle.DataDeAgora().ToShortDateString();
            txtLogon.Clear();
            mskSenha.Clear();
            rbtCliente.Checked = true;
            gbxLogon.Visible = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNome.Text != "") && (txtRg.Text != "") && (mskCpf.Text != "") && (txtRua.Text != "") && (mskNumero.Text != "") && (txtBairro.Text != "") && (txtCidade.Text != "") && (cbxEstado.Text != "") && (dtpDataNascimento.Text != "") && (dtpDataCadastro.Text != ""))
                {
                    if (rbtCliente.Checked)
                    {
                        nivel = (int)Enumeracoes.NivelUsuario.Paciente;
                    }
                    else
                    {
                        if (rbtMedico.Checked)
                        {
                            nivel = (int)Enumeracoes.NivelUsuario.Medico;
                        }
                        else
                        {
                            nivel = (int)Enumeracoes.NivelUsuario.Funcionario;
                        }
                    }
                    nome = txtNome.Text;
                    rg = txtRg.Text;
                    cpf = mskCpf.Text;
                    rua = txtRua.Text;
                    numero = mskNumero.Text;
                    bairro = txtBairro.Text;
                    complemento = cbxComplemento.Text;
                    cidade = txtCidade.Text;
                    estado = cbxEstado.Text;
                    cep = mskCep.Text;
                    telefone = mskTelefone.Text;
                    celular = mskCelular.Text;
                    email = txtEmail.Text;
                    profissao = txtProfissao.Text;
                    convenio = txtConvenio.Text;
                    estadoCivil = cbxEstadoCivil.Text;
                    quemIndicou = txtQuemIndicou.Text;
                    dtNascimento = Controle.ConverteFormatoData(dtpDataNascimento.Value.ToShortDateString());
                    dtCadastro = Controle.ConverteFormatoData(dtpDataCadastro.Value.ToShortDateString());
                    logon = txtLogon.Text;
                    senha = mskSenha.Text;
                    bool validaCpf = Controle.ValidaCpf(cpf);
                    if (validaCpf)
                    {
                        if (((nivel >= 1) && (logon != "") && (senha != "")) || (nivel == 0))
                        {
                            BoPessoas pessoa = new BoPessoas(nivel, nome, rg, cpf, rua, bairro, complemento, cidade, estado, cep, telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou, dtNascimento, dtCadastro, numero, logon, senha);
                            String salva = Controle.SalvaPessoa(pessoa);
                            MessageBox.Show(salva, "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimpar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Logon e senha são campos obrigatórios, para que você possa logar no sistema.", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLogon.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O CPF digitado é inválido ou está incorreto, verifique por favor.", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLogon.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Os campos marcados com '*' são de preenchimento obrigatório.", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
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

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = false;
            txtLogon.Clear();
            mskSenha.Clear();
        }

        private void rbtMedico_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = true;
        }

        private void rbtFuncionário_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = true;
        }
    }
}
