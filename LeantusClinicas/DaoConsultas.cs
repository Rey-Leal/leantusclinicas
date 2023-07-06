using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;

namespace LeantusClinicas
{
    class DaoConsultas
    {
        public ApplicationException ErroConexao()
        {
            System.ApplicationException ex = new ApplicationException("Erro na conexão com o banco de dados, ou SQL inválida");
            return ex;
        }

        public ApplicationException DadoInexistente()
        {
            System.ApplicationException ex = new ApplicationException("O dado utilizado na pesquisa não existe no banco de dados");
            return ex;
        }

        public static ApplicationException ConsultaJaCadastrada()
        {
            System.ApplicationException ex = new ApplicationException("Este CPF já existe no sistema, verifique nas listagens se esta pessoa já foi cadastrada anteriormente");
            return ex;
        }

        //conexao 1 - salva consulta
        public static String SalvaConsulta(BoConsultas consulta)
        {
            try
            {
                int medico = 0;
                int paciente = 0;
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Pessoas WHERE nome = '" + consulta.Paciente + "'", conexao);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    paciente = Int32.Parse(dr["id"].ToString());
                }
                conexao.Close();

                OleDbConnection conexao2 = Conexao.Conecta();
                conexao2.Open();
                OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM Pessoas WHERE nome = '" + consulta.Medico + "'", conexao2);
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    medico = (int)dr2["id"];
                }
                conexao2.Close();

                OleDbConnection conexao3 = Conexao.Conecta();
                conexao3.Open();
                OleDbCommand cmd3 = new OleDbCommand("INSERT INTO Consultas (codPaciente, codMedico, dtConsulta, descConsulta, observacoes, receita, valor) VALUES (" + paciente + ", " + medico + ",'" + consulta.DtConsulta + "','" + consulta.DescConsulta + "','" + consulta.Observacoes + "','" + consulta.Receita + "','" + consulta.Valor + "')", conexao3);
                cmd3.ExecuteScalar();
                conexao3.Close();

                OleDbConnection conexao4 = Conexao.Conecta();
                conexao4.Open();
                OleDbCommand cmd4 = new OleDbCommand("UPDATE Relatorios SET ultimo = " + (int.Parse(Controle.BuscaConsultas()) + 1) + " WHERE relatorio = 'Consultas'", conexao4);
                cmd4.ExecuteScalar();
                conexao4.Close();

                return "Consulta Cadastrada com sucesso";
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //conexao 2 - busca ultima consulta
        public String BuscaConsultas()
        {
            try
            {
                String consulta = "erro";
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT ultimo FROM RELATORIOS WHERE relatorio = 'Consultas'", conexao);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    consulta = dr["ultimo"].ToString();
                }
                conexao.Close();
                return consulta;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //conexao 3 - busca consultas de um cliente
        public List<String> ListaConsultasCliente(String nome)
        {
            try
            {
                List<String> todasConsultas = new List<String>();
                todasConsultas.Clear();
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT descConsulta FROM Consultas WHERE codPaciente = (SELECT id FROM Pessoas WHERE nome = '" + nome + "')", conexao);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    todasConsultas.Add(dr["descConsulta"].ToString());
                }
                conexao.Close();
                return todasConsultas;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //conexao 4 - busca id pelo cpf         
        public String BuscaIdPeloCpf(String cpf)
        {
            try
            {
                String consulta = "";
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT id FROM Pessoas WHERE Pessoas.cpf = '" + cpf + "'", conexao);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    consulta = dr["id"].ToString();
                }
                conexao.Close();
                return consulta;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //conexao 5 - salva assinaturas
        public String SalvaAssinaturas(String consultas, String recibos, String outros)
        {
            try
            {
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Assinaturas SET consultas='" + consultas + "', recibos='" + recibos + "', outros = '" + outros + "' WHERE id=1", conexao);
                cmd.ExecuteScalar();
                conexao.Close();

                return "Assinaturas salvas com sucesso";
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //conexao 6 - busca assinaturas        
        public List<String> BuscaAssinaturas()
        {
            try
            {
                List<String> assinaturas = new List<string>();
                assinaturas.Clear();
                OleDbConnection conexao = Conexao.Conecta();
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Assinaturas", conexao);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    assinaturas.Add(dr["consultas"].ToString());
                    assinaturas.Add(dr["recibos"].ToString());
                    assinaturas.Add(dr["outros"].ToString());
                }
                conexao.Close();
                return assinaturas;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }
    }
}
