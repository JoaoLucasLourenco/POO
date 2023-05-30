using ClassAtividade_03_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atividade_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAluno = new List<Aluno>();
            Aluno A1;
            string nome;
            string cidade;
            int[] notas = new int[3];
            int op = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Gravar Aluno");
                Console.WriteLine("2. Mostrar Notas e Média por Aluno");
                Console.WriteLine("3. Mostrar nomes dos alunos por cidade");
                Console.WriteLine("4. Sair");
                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Entre com o nome do aluno: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Entre com a cidade do aluno: ");
                        cidade = Console.ReadLine();
                        foreach(var i in  notas)
                        {
                            Console.WriteLine($"Entre com a {i+1}.a nota do aluno: ");
                            notas[i] = int.Parse( Console.ReadLine());
                        }
                        A1 = new Aluno(nome);
                        A1.Cidade = cidade;
                        A1.Notas = notas;
                        listaAluno.Add(A1);

                        break;
                    case 2:
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        foreach (Aluno aluno in listaAluno)

                        {
                            if (aluno.Nome == nome)
                            {
                                Console.WriteLine(aluno.MostraNotas());
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Cidade: ");
                        cidade = Console.ReadLine();
                        foreach (Aluno aluno in listaAluno)

                        {
                            if (aluno.Cidade == cidade)
                            {
                                Console.WriteLine(aluno.Nome);
                                Console.ReadKey();
                            }
                        }
                        break;

                }
            } while (op != 4);
        }
    }
    }

