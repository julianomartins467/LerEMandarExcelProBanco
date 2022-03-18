using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerExcel2
{
    public class Sql
    {
        public string ConString { get; set; }
        public Sql()
        {
            this.ConString = "server = localhost; user id = root; password = ju10203040; database = treinamento_universidade";

        }

        public void InserirAluno(string nome, string cpf)
        {
           
            var conexao = new MySqlConnection(this.ConString);

            var strSql = @" INSERT INTO aluno (nome,cpf) values (@nome, @cpf)";

            conexao.Open();
            MySqlCommand comm = conexao.CreateCommand();
            comm.CommandText = strSql;
            comm.Parameters.AddWithValue("@nome", nome);
            comm.Parameters.AddWithValue("@cpf", cpf);
            comm.ExecuteNonQuery();
            conexao.Close();

        }
        //public void InserirAluno_Disciplina(string nota, string matricula_id)
        //{
           
        //    var conexao = new MySqlConnection(this.ConString);

        //    var strSql = @" INSERT INTO aluno_disciplina (nota,matricula_id) values (@nota, @matricula_id)";

        //    conexao.Open();
        //    MySqlCommand comm = conexao.CreateCommand();
        //    comm.CommandText = strSql;
        //    comm.Parameters.AddWithValue("@nota", nota);
        //    comm.Parameters.AddWithValue("@matricula_id", matricula_id);
        //    comm.ExecuteNonQuery();
        //    conexao.Close();

        //}

    }
}
