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
        
        public Aluno()
        {
            vetor = new int[4];
        }
        public void GravaAluno(string matricula, string nome, int[] notas)
        {
            this.matricula = matricula;
            this.nome = nome;
            for (int i = 0; i < notas.Length; i++)
            {
                vetor[i] = notas[i];
            }

        }
        public string MostraAluno()
        {
            
            string notas = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                notas += $"{this.vetor[i]} ";
            }
            return $"Matrícula: {matricula}\nNome: {nome}\nNotas: {notas}";
            

        }
    }
    internal class atividade1
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            string matricula, nome,retornaaluno;
            int[] notas;
            
            notas = new int[4];
            
            int opcao;
            do
            {
                Console.Write("1 . Gravar nome do aluno\n2 . Mostrar aluno\n3 . Sair\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Entre com a matrícula do aluno:");
                        matricula = Console.ReadLine();
                        Console.WriteLine("Entre com o nome do aluno:");
                        nome = Console.ReadLine();
                        

                        
                        


                        
                            for (int i = 0; i < 4; i++)
                            {
                                Console.WriteLine($"Entre com a {i + 1}.a nota do aluno:");
                                notas[i] = int.Parse(Console.ReadLine());
                            }
                        aluno.GravaAluno(matricula,nome,notas);
                        break;
                    case 2:
                        retornaaluno = aluno.MostraAluno();
                        Console.WriteLine(retornaaluno);
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
