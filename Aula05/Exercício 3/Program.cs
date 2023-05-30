using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Pesquisador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Formação: ");
            string formacao = Console.ReadLine();
            Console.Write("Área de Pesquisa: ");
            string area = Console.ReadLine();
            Pesquisador p = new Pesquisador(nome, formacao, area);
            Console.WriteLine("\n" + p.MostraPesquisador());
            Console.ReadKey();
        }
    }
}
