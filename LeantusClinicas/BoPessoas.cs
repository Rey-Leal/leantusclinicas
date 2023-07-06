using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeantusClinicas
{
    public class BoPessoas
    {
        //construtores
        public BoPessoas(int nivel, String nome, String rg, String cpf, String rua, String bairro, String complemento, String cidade, String estado, String cep, String telefone, String celular, String email, String profissao, String convenio, String estadoCivil, String quemIndicou, String dtNascimento, String dtCadastro, String numero, String logon, String senha)
        {
            this.Nivel = nivel;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Profissao = profissao;
            this.Convenio = convenio;
            this.EstadoCivil = estadoCivil;
            this.QuemIndicou = quemIndicou;
            this.DtNascimento = dtNascimento;
            this.DtCadastro = dtCadastro;
            this.Numero = numero;
            this.Logon = logon;
            this.Senha = senha;
        }

        public BoPessoas()
        {
        }

        //atributos
        private int nivel;
        private String nome, rg, cpf, rua, bairro, complemento, cidade, estado, cep;
        private String telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou;
        private String dtNascimento, dtCadastro, numero, logon, senha;

        //propriedades
        public int Nivel
        {
            get { return nivel; }
            set
            {
                if (value > 3)
                {
                    nivel = 3;
                }
                else
                {
                    nivel = value;
                }
            }
        }

        public String Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 50)
                {
                    nome = value.Substring(0, 50);
                }
                else
                {
                    nome = value;
                }
            }
        }

        public String Rg
        {
            get { return rg; }
            set
            {
                if (value.Length > 15)
                {
                    rg = value.Substring(0, 15);
                }
                else
                {
                    rg = value;
                }
            }
        }

        public String Cpf
        {
            get { return cpf; }
            set
            {
                if (value.Length > 15)
                {
                    cpf = value.Substring(0, 15);
                }
                else
                {
                    cpf = value;
                }
            }
        }

        public String Rua
        {
            get { return rua; }
            set
            {
                if (value.Length > 30)
                {
                    rua = value.Substring(0, 30);
                }
                else
                {
                    rua = value;
                }
            }
        }

        public String Bairro
        {
            get { return bairro; }
            set
            {
                if (value.Length > 20)
                {
                    bairro = value.Substring(0, 20);
                }
                else
                {
                    bairro = value;
                }
            }
        }

        public String Complemento
        {
            get { return complemento; }
            set
            {
                if (value.Length > 15)
                {
                    complemento = value.Substring(0, 15);
                }
                else
                {
                    complemento = value;
                }
            }
        }

        public String Cidade
        {
            get { return cidade; }
            set
            {
                if (value.Length > 30)
                {
                    cidade = value.Substring(0, 30);
                }
                else
                {
                    cidade = value;
                }
            }
        }

        public String Estado
        {
            get { return estado; }
            set
            {
                if (value.Length > 2)
                {
                    estado = value.Substring(0, 2);
                }
                else
                {
                    estado = value;
                }
            }
        }

        public String Cep
        {
            get { return cep; }
            set
            {
                if (value.Length > 9)
                {
                    cep = value.Substring(0, 9);
                }
                else
                {
                    cep = value;
                }
            }
        }

        public String Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length > 15)
                {
                    telefone = value.Substring(0, 15);
                }
                else
                {
                    telefone = value;
                }
            }
        }

        public String Celular
        {
            get { return celular; }
            set
            {
                if (value.Length > 15)
                {
                    celular = value.Substring(0, 15);
                }
                else
                {
                    celular = value;
                }
            }
        }

        public String Email
        {
            get { return email; }
            set
            {
                if (value.Length > 50)
                {
                    email = value.Substring(0, 50);
                }
                else
                {
                    email = value;
                }
            }
        }

        public String Profissao
        {
            get { return profissao; }
            set
            {
                if (value.Length > 20)
                {
                    profissao = value.Substring(0, 20);
                }
                else
                {
                    profissao = value;
                }
            }
        }

        public String Convenio
        {
            get { return convenio; }
            set
            {
                if (value.Length > 30)
                {
                    convenio = value.Substring(0, 30);
                }
                else
                {
                    convenio = value;
                }
            }
        }

        public String EstadoCivil
        {
            get { return estadoCivil; }
            set
            {
                if (value.Length > 10)
                {
                    estadoCivil = value.Substring(0, 10);
                }
                else
                {
                    estadoCivil = value;
                }
            }
        }

        public String QuemIndicou
        {
            get { return quemIndicou; }
            set
            {
                if (value.Length > 50)
                {
                    quemIndicou = value.Substring(0, 50);
                }
                else
                {
                    quemIndicou = value;
                }
            }
        }

        public String DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }

        public String DtCadastro
        {
            get { return dtCadastro; }
            set { dtCadastro = value; }
        }

        public String Numero
        {
            get { return numero; }
            set
            {
                if (value.Length > 5)
                {
                    numero = value.Substring(0, 5);
                }
                else
                {
                    numero = value;
                }
            }
        }

        public String Logon
        {
            get { return logon; }
            set
            {
                if (value.Length > 15)
                {
                    logon = value.Substring(0, 15);
                }
                else
                {
                    logon = value;
                }
            }
        }

        public String Senha
        {
            get { return senha; }
            set
            {
                if (value.Length > 15)
                {
                    senha = value.Substring(0, 15);
                }
                else
                {
                    senha = value;
                }
            }
        }
    }
}