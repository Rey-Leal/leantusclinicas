﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeantusClinicas
{
    public partial class FrmLogon : Form
    {
        public String logon, senha;

        public FrmLogon()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtLogon.Clear();
            mskSenha.Clear();
            txtLogon.Focus();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtLogon.Text != "") && (mskSenha.Text != ""))
                {
                    logon = txtLogon.Text;
                    senha = mskSenha.Text;
                    if (Controle.Logon(logon, senha))
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Logon e/ou senha inválidas", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Os dois campos são obrigatórios", "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Leantus Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            int tempo = Controle.DataDeAgora().Hour;
            if ((tempo >= 5)&&(tempo < 12))
            {
                label3.Text = "Bom dia, seja bem vindo!";
            }
            else if ((tempo >= 12) && (tempo < 19))
            {
                label3.Text = "Boa tarde, vamos continuar?";
            }
            else if ((tempo >= 19) && (tempo < 23))
            {
                label3.Text = "Boa noite, sempre em serviço.";
            }            
        }
    }
}
