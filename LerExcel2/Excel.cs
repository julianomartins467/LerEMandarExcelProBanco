//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;
//using MySql.Data.MySqlClient;
//using MySqlConnector;

//namespace LerExcel2
//{
//    internal class Excel
//    {
//        public static DataTable ListaAlunos()
//        {
//            try
//            {
//                var arquivo = @"C:\Users\Openk\source\repos\Batch_ListaAluno\Batch_ListaAluno\bin\Debug\net5.0\ListaAluno.xlsx";

//                var conexao = new MySqlConnection("server=localhost;user id=root;password=ju10203040;database=treinamento_universidade");

//                var strSql = @" INSERT INTO aluno (nome,cpf) values (@nome, @cpf)";

//                comando = new MySqlConnection(strSql, conexao);
//                comando.Parameters.AddWithValue(@nome);
//                comando.Parameters.AddWithValue(@cpf);
//                comando.Parameters.AddWithValue(@nota);
//                comando.Parameters.AddWithValue(@situacao);

//                var dt = new DataTable();
//                return dt;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}
