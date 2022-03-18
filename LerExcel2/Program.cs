using System;
using System.Linq;
using ClosedXML.Excel;

namespace LerExcel2
{
    class Program
    {
        static void Main(string[] args)
        {                              
            var xls = new XLWorkbook(@"C:\Users\Openk\source\repos\Batch_ListaAluno\Batch_ListaAluno\bin\Debug\net5.0\ListaAluno.xlsx");
            var planilha = xls.Worksheets.First(w => w.Name == "Alunos"); // nome do rodape do excel
            var totalLinhas = planilha.Rows().Count();
            
            for (int l = 2; l <= totalLinhas; l++)
            {
                var nome = planilha.Cell($"A{l}").Value.ToString();
                var cpf = planilha.Cell($"B{l}").Value.ToString();
                var matricula = planilha.Cell($"C{l}").Value.ToString();
                var nota = planilha.Cell($"D{l}").Value.ToString();
                var situacao_planilha = planilha.Cell($"E{l}").Value.ToString();

                bool situacao;

                if (string.IsNullOrEmpty(nome)) break;
                if (string.IsNullOrEmpty(cpf)) break;
                if (string.IsNullOrEmpty(matricula)) break;
                if (string.IsNullOrEmpty(nota)) break;
                if (string.IsNullOrEmpty(situacao_planilha)) break;

                if (situacao_planilha.Equals("Aprovado"))
                {
                    situacao = true;
                }
                else
                {
                    situacao = false;
                }
                Sql sql = new Sql();

                sql.InserirAluno(nome, cpf);

                //Console.WriteLine($"{nome.PadRight(15)}  {cpf.PadRight(15)}  {matricula.PadRight(10)}  {nota.PadRight(10)}  {situacao}");
                //Console.WriteLine("".PadRight(90, '-'));
            }

        }

    }
}
//"ConnectionStrings": "DefaultConnection": "Host=192.168.1.248;Port = 3306;Database=treinamento_universidade;User ID=openkdbuser;Password=Homologa;Protocol=TCP;Compress=false;Pooling=true;Connection Reset=true;Min Pool Size=2; Max Pool Size=10; convert zero datetime=True;",