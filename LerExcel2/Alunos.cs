//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LerExcel2
//{
//    internal class Alunos
//    {
//        public string nome { get; set; }
//        public string cpf { get; set; }
//        public string matricula { get; set; }
//        public string nota { get; set; }
//        public string situacao { get; set; }

//        public Alunos() { }

//        public Alunos(string nome, string cpf, int matricula, int nota, bool situacao) 
//        {
//            nome= nome;
//            cpf= cpf;
//            matricula= matricula;
//            nota= nota;
//            situacao= situacao;
        
//        }
//        public DataTable ListaAlunos()
//        {
//            return Excel.ListaAlunos();
//        }
//        public bool AdicionarAluno()
//        {
//            return true;
//        }
//    }
//}
