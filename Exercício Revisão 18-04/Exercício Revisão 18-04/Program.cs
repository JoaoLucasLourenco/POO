using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_18_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p1;
            List<Paciente> listapaciente = new List<Paciente>();
            string nome;
            int op=0;
            do
            {
                Console.Write("1 . Criar paciente\n2 . Pesquisar endereço de um determinado paciente pelo seu nome\n" +
                    "3 . Pesquisar o nome dos pacientes idosos (>60) de uma determinada cidade\n4 . Sair\nEscolha sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        
                        Console.WriteLine("Entre com o nome do paciente: ");
                        nome = Console.ReadLine();
                        p1 = new Paciente(nome);
                        Console.WriteLine("Entre com a idade do paciente: ");
                        p1.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre com a cidade do paciente: ");
                        p1.End.Cidade = Console.ReadLine();
                        Console.WriteLine("Entre com a rua do paciente: ");
                        p1.End.Rua = Console.ReadLine();
                        Console.WriteLine("Entre com o número da casa do paciente: ");
                        p1.End.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre com o bairro do paciente: ");
                        p1.End.Bairro = Console.ReadLine();
                        Console.WriteLine("Entre com o cep do paciente: ");
                        p1.End.Cep = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre com o estado do paciente: ");
                        p1.End.Estado = Console.ReadLine();
                        listapaciente.Add(p1);
                        break;
                    case 2:
                        Console.WriteLine("Entre com o nome do paciente: ");
                        nome = Console.ReadLine();
                        foreach(var paciente in listapaciente)
                        {
                            if (nome == paciente.Nome)
                                Console.WriteLine($"Endereço de {nome}:\n{paciente.End.MostraEndereco()}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Entre com a cidade:");
                        nome = Console.ReadLine();
                        foreach(var paciente in listapaciente)
                        {
                            if (paciente.End.Cidade == nome)
                            {
                                if (paciente.Idade > 60)
                                    Console.WriteLine(paciente.Nome);
                            }
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (op != 4);
        }
    }
}
