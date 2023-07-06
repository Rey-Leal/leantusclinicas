using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace LeantusClinicas
{
    class Conexao
    {
        //Access
        //---------------------------------------------------------------------------------------------------------------------------------------------------------

        public static OleDbConnection Conecta()
        {
            try
            {
                String mapa = Controle.DiretorioRaiz();
                String caminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + mapa + @"\LeantusClinicas.mdb";
                OleDbConnection conexao = new OleDbConnection(caminho);
                return conexao;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        //SQL
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //public static SqlConnection Conecta()
        //{
        //    try
        //    {
        //        String caminho = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Rey Leal\Documents\ReyProjects\LeantusClinicas\LeantusClinicas\LeantusClinicas.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //        SqlConnection conexao = new SqlConnection(caminho);
        //        return conexao;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
