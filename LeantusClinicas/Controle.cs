using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LeantusClinicas
{
    class Controle
    {
        public static ArrayList arrayRelatorio = new ArrayList();
        public static ArrayList arrayParametro = new ArrayList();
        public static ArrayList arrayFormAberto = new ArrayList();
        public static ArrayList arrayConsultas = new ArrayList();

        //realiza logon
        public static bool Logon(String logon, String senha)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.Logon(logon, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //retorna diretorio raiz
        public static String DiretorioRaiz()
        {
            try
            {
                String diretorioRaiz = System.IO.Directory.GetCurrentDirectory().ToString();
                return diretorioRaiz;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //controla abertura de forms
        public static void AbriuForm(String frm)
        {
            arrayFormAberto.Add(frm);
        }

        //controla fechamento de forms
        public static void FechouForm(String frm)
        {
            arrayFormAberto.Remove(frm);
        }

        //testa se form esta aberto
        public static bool FormsAbertos(String frm)
        {
            for (int i = 0; i < arrayFormAberto.Count; i++)
            {
                if (arrayFormAberto[i].Equals(frm))
                {
                    return true;
                }
            }
            return false;
        }

        //abre form cadastro
        public static void AbreFormCadastroPessoa()
        {
            FrmCadastroPessoas frmCadastroPessoas = new FrmCadastroPessoas();
            frmCadastroPessoas.Show();
        }

        //salva uma nova pessoa
        public static String SalvaPessoa(BoPessoas pessoa)
        {
            try
            {
                String salva = DaoPessoas.SalvaPessoas(pessoa);
                return salva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //salva uma nova consuta
        public static String SalvaConsulta(BoConsultas consulta)
        {
            try
            {
                String salva = DaoConsultas.SalvaConsulta(consulta);
                return salva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //traz a data de hoje
        public static DateTime DataDeAgora()
        {
            //Access
            return System.DateTime.Now;

            //SQL
            //DaoPessoas daoPessoas = new DaoPessoas();
            //return daoPessoas.DataDeAgora();
        }

        //converte data portuguesa para formato ingles
        public static String ConverteFormatoData(String dataPortuguesa)
        {
            try
            {
                DateTime data = DateTime.Parse(dataPortuguesa);
                String dia = data.Day.ToString();
                String mes = data.Month.ToString();
                String ano = data.Year.ToString();
                String dataInglesa = mes + "/" + dia + "/" + ano;
                return dataInglesa;
            }
            catch
            {
                return "01/01/1900";
            }
        }

        //busca todos os nomes de pessoas
        public static ArrayList BuscaTodosNomes()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosNomes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca ultima consulta
        public static String BuscaConsultas()
        {
            try
            {
                DaoConsultas daoConsultas = new DaoConsultas();
                return daoConsultas.BuscaConsultas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca todos dados de uma pessoa por nome
        public static BoPessoas BuscaDadosPorNome(String nome)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaDadosPorNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca todos dados de uma pessoa por cpf
        public static BoPessoas BuscaDadosPorCpf(String cpf)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaDadosPorCpf(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //lista todos dados de todas pessoas
        public static List<BoPessoas> BuscaTodasPessoas()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodasPessoas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos medicos
        public static List<BoPessoas> BuscaTodosMedicos()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosMedicos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos clientes
        public static List<BoPessoas> BuscaTodosClientes()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos funcionarios
        public static List<BoPessoas> BuscaTodosFuncionarios()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosFuncionarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //lista consultas de uma pessoa
        public static List<String> ListaConsultasCliente(String nome)
        {
            try
            {
                DaoConsultas daoConsultas = new DaoConsultas();
                return daoConsultas.ListaConsultasCliente(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca id pelo cpf
        public static String BuscaIdPeloCpf(String cpf)
        {
            try
            {
                DaoConsultas daoConsultas = new DaoConsultas();
                return daoConsultas.BuscaIdPeloCpf(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //salva assinaturas
        public static String SalvaAssinaturas(String consultas, String recibos, String outros)
        {
            DaoConsultas daoConsultas = new DaoConsultas();
            return daoConsultas.SalvaAssinaturas(consultas, recibos, outros);
        }

        //busca assinaturas
        public static List<String> BuscaAssinaturas()
        {
            DaoConsultas daoConsultas = new DaoConsultas();
            return daoConsultas.BuscaAssinaturas();
        }

        //valida cpf
        public static bool ValidaCpf(String cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            String tempCpf;
            String digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        //abre vizualizador de relatórios
        public static void AbreRelatorio(String relatorio, String parametro)
        {
            arrayRelatorio.Clear();
            arrayParametro.Clear();
            arrayRelatorio.Add(relatorio);
            arrayParametro.Add(parametro);
            FrmRelatorios frmRelatorios = new FrmRelatorios();
            frmRelatorios.MdiParent = FrmPrincipal.ActiveForm;
            frmRelatorios.Show();
        }

        //busca relatorio a imprimir
        public static String ImprimirRelatorio()
        {
            return arrayRelatorio[arrayRelatorio.Count - 1].ToString();
        }

        //retorna parametro do relatorio a imprimir
        public static String ParametroRelatorio()
        {
            return arrayParametro[arrayParametro.Count - 1].ToString();
        }
    }
}
