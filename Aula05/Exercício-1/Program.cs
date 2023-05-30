using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void cadastraPessoa(Pessoa p)
        {
            Console.WriteLine("CPF: ");
            p.Cpf = Console.ReadLine();
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p.Idade = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Medico medico = new Medico();
            cadastraPessoa(medico);
            Console.WriteLine("CRM: ");
            medico.Crm = Console.ReadLine();
            Console.WriteLine("Especialidade: ");
            medico.Especialidade = Console.ReadLine();
            Paciente paciente = new Paciente();
            cadastraPessoa(paciente);
            Console.WriteLine("Plano: ");
            paciente.Plano = Console.ReadLine();
            Console.WriteLine($"Dados do médico: {medico.MostraMedico()}");
            Console.WriteLine($"Dados do paciente: {paciente.MostraPaciente()}");
            Console.ReadKey();
            
        }
        
    }
}
