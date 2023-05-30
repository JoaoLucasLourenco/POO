using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listF = new List<Funcionario>();
            List<Docente> listD = new List<Docente>();
            List<Pesquisador> listP = new List<Pesquisador>();
            Funcionario F1 = null;
            Docente D1 = null;
            Pesquisador P1 = null;
            int op = 0;
            do
            {
                Console.WriteLine("Cadastrar 1-Funcionario, 2-Docente, 3-Pesquisador");
                Console.WriteLine("Mostrar 4-Funcionario, 5-Docente, 6-Pesquisador");
                Console.WriteLine("7-Sair");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        F1 = new Funcionario();
                        cadastro(F1);
                        listF.Add(F1);
                        break;
                    case 2:
                        D1 = new Docente();
                        cadastro(D1);
                        listD.Add(D1);
                        break;
                    case 3:
                        P1 = new Pesquisador();
                        cadastro(P1);
                        listP.Add(P1);
                        break;
                    case 4:
                        foreach (var f in listF)
                            Mostra(f);
                        break;
                    case 5:
                        foreach (var d in listD)
                            Mostra(d);
                        break;
                    case 6:
                        foreach (var p in listP)
                            Mostra(p);
                        break;

                }
            } while (op != 7);
        }
        static void cadastro(Funcionario f)
        {
            string cpf;
            Console.WriteLine("Nome");
            f.Nome = Console.ReadLine();
            do
            {
                Console.WriteLine("CPF");
                cpf = Console.ReadLine();
            } while (!f.Cpf1.ValidaCpf(cpf));
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
            string aux = $"CPF: {f.Cpf1.MostraCPF()}\nNome: {f.Nome}\n";
            if (f is Docente)
                aux += $"Formação: {(f as Docente).Formacao}\n";

            if (f is Pesquisador)
                aux += $"Area de pesquisa: {(f as Pesquisador).Areadepesquisa}";

            Console.WriteLine(aux);
        }
    }
}
