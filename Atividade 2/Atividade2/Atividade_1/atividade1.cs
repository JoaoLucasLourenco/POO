using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private int[] vetor;
        private int opcaonotas;
        public Aluno()
        {
            vetor = new int[4];
        }
        public void GravaAluno()
        {
            Console.WriteLine("Entre com a matrícula do aluno:");
            matricula = Console.ReadLine();
            Console.WriteLine("Entre com o nome do aluno:");
            nome = Console.ReadLine();
            int opcaonotas;

            Console.WriteLine("As notas do aluno são iguais a 0?\n'1' (sim) '2' (Não)\nQual a opção: ");
            opcaonotas = int.Parse(Console.ReadLine());
            switch (opcaonotas)
            {
                case 1:
                    for (int i = 0; i < 4; i++)
                    {
                        vetor[i] = 0;
                    }
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }


            if (opcaonotas == 2)
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Entre com a {i + 1}.a nota do aluno:");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

        }
        public void MostraAluno()
        {
            if (matricula == null)
                Console.WriteLine("A matrícula ainda não foi declarada. Declare a matrícula antes!");
            else
                Console.WriteLine("Matrícula do aluno: " + matricula);

            if (nome == null)
                Console.WriteLine("O nome ainda não foi declarado. Declare o nome antes!");
            else
                Console.WriteLine("Nome do aluno: " + nome);

            int somavetor = 0;
            if (opcaonotas == 1)
            {
                Console.WriteLine("Notas iguais a 0");
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    somavetor += vetor[i];
                }
                if (somavetor == 0)
                    Console.WriteLine("As notas ainda não foram declaradas ou são iguais a 0!" +
                        " Declare as notas antes!");
                else
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{i + 1}.a Nota: {vetor[i]}");
                    }
            }

        }
    }
    internal class atividade1
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            int opcao;
            do
            {
                Console.Write("1 . Gravar nome do aluno\n2 . Mostrar aluno\n3 . Sair\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        aluno.GravaAluno();
                        break;
                    case 2:
                        aluno.MostraAluno();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 3);
        }
    }
}

