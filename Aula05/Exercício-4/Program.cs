using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Funcionario F1 = new Funcionario();
            cadastro(F1);
            Docente D1 = new Docente();
            cadastro(D1);
            Pesquisador P1 = new Pesquisador();
            cadastro(P1);
            Mostra(F1);
            Mostra(D1);
            Mostra(P1);
            Console.ReadKey();
        }
        static void cadastro(Funcionario f)
        {
            string cpf;
            Console.WriteLine("Nome");
            f.Nome = Console.ReadLine();
            do {
                Console.WriteLine("CPF");
                cpf = Console.ReadLine();
            } while(!f.Cpf1.ValidaCpf(cpf));
            if (f is Docente)
            {
                Console.WriteLine("Formação: ");
                (f as Docente).Formacao = Console.ReadLine();

            }
            if (f is Pesquisador)
            {
                Console.WriteLine("Area de pesquisa: ");
                (f as Pesquisador).Areadepesquisa = Console.ReadLine();
            }
            
        }
        static void Mostra(Funcionario f)
        {
            string  aux = $"CPF: {f.Cpf1.MostraCPF()}\nNome: {f.Nome}\n";
            if (f is Docente)
                aux += $"Formação: {(f as Docente).Formacao}\n";
            
            if (f is Pesquisador)
                aux += $"Area de pesquisa: {(f as Pesquisador).Areadepesquisa}";
            
            Console.WriteLine(aux);
        }
    }
}
