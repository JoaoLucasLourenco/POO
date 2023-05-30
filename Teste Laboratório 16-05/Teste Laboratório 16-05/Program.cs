using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Laboratório_16_05
{
    internal class Program
    {
        static void cadastro(Pessoa p) 
        {
            Console.WriteLine("Entre com o nome do cadastrado:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade do cadastrado:");
            p.Idade = int.Parse(Console.ReadLine());
            string cpf;
            do
            {
                Console.WriteLine("CPF");
                cpf = Console.ReadLine();
            } while (!p.Cpf1.ValidaCpf(cpf));
            if (p is Aluno)
            {
                Console.WriteLine("Entre com a matrícula do aluno: ");
                (p as Aluno).Matricula = Console.ReadLine();
            }
            else if(p is Professor)
            {
                Console.WriteLine("Entre com a titulação do professor");
                (p as Professor).Titulacao = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Professor professor = new Professor();
            List<Aluno> listaaluno = new List<Aluno>();
            List<Professor> listaprofessor = new List<Professor>();
            int op = 1;
            do
            {
                Console.WriteLine("Menu\n1 - Cadastrar Aluno\n2 - Cadastrar Professor\n3 - Pesquisar aluno por matrícula" +
                "\n4 - Pesquisar todos os professores de uma determinada titulação\n5 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cadastro(aluno);
                        listaaluno.Add(aluno);
                        break;
                    case 2:
                        cadastro(professor);
                        listaprofessor.Add(professor);
                        break;
                    case 3:
                        Console.WriteLine("Entre com a matrícula do aluno:");
                        string mat = Console.ReadLine();
                        foreach(var a in listaaluno)
                        {
                            if (a.Matricula == mat)
                                Console.WriteLine(a.MostraAluno());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Entre com a titulaçao do professor:");
                        string tit = Console.ReadLine();
                        foreach(var p in listaprofessor)
                        {
                            if (tit == p.Titulacao)
                                Console.WriteLine(p.MostraProfessor());
                        }
                        break;
                    case 5:
                        break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            } while (op != 5);
        }
    }
}
