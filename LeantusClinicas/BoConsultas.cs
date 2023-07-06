using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeantusClinicas
{
    class BoConsultas
    {
        //construtores
        public BoConsultas(String paciente, String medico, String dtConsulta, String descConsulta, String observacoes, String receita, String valor)
        {
            this.Paciente = paciente;
            this.Medico = medico;
            this.DtConsulta = dtConsulta;
            this.DescConsulta = descConsulta;
            this.Observacoes = observacoes;
            this.Receita = receita;
            this.Valor = valor;
        }

        //atributos
        private int codPaciente, codMedico;
        private String paciente, medico;
        private String dtConsulta, descConsulta;
        private String observacoes, receita, valor;


        //propriedades
        public int Cod_Paciente
        {
            get { return codPaciente; }
            set { codPaciente = value; }
        }

        public int Cod_Medico
        {
            get { return codMedico; }
            set { codMedico = value; }
        }

        public String Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public String Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public String DtConsulta
        {
            get { return dtConsulta; }
            set { dtConsulta = value; }
        }

        public String DescConsulta
        {
            get { return descConsulta; }
            set
            {
                if (value.Length > 100)
                {
                    descConsulta = value.Substring(0, 100);
                }
                else
                {
                    descConsulta = value;
                }
            }
        }

        public String Observacoes
        {
            get { return observacoes; }
            set
            {
                if (value.Length > 200)
                {
                    observacoes = value.Substring(0, 200);
                }
                else
                {
                    observacoes = value;
                }
            }
        }

        public String Receita
        {
            get { return receita; }
            set
            {
                if (value.Length > 200)
                {
                    receita = value.Substring(0, 200);
                }
                else
                {
                    receita = value;
                }
            }
        }

        public String Valor
        {
            get { return valor; }
            set
            {
                if (value.Length > 10)
                {
                    valor = value.Substring(0, 10);
                }
                else
                {
                    valor = value;
                }
            }
        }
    }
}
