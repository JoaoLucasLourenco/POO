using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program2
    {
        static string[] cadastraPessoa1() 
        {
            string[] s = new string[3];
            Console.WriteLine("CPF: ");
            s[0] = Console.ReadLine();
            Console.WriteLine("Nome: ");
            s[1] = Console.ReadLine();
            Console.WriteLine("Idade: ");
            s[2] = Console.ReadLine();
            return s;
        }
        static void cadastraPessoa2(ref string cpf, ref string nome, ref int idade) 
        {
            Console.WriteLine("CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            string[] s = new string[3];
            string cpf="", nome="";
            int idade=0;
            Console.WriteLine("Médico");
            cadastraPessoa2(ref cpf, ref nome, ref idade);
            Console.WriteLine("CRM: ");
            string crm = Console.ReadLine();
            Console.WriteLine("Especialidade: ");
            string especialidade = Console.ReadLine();
            Medico2 medico2 = new Medico2(cpf, nome, idade, crm,especialidade);
            Console.WriteLine("Paciente");
            cadastraPessoa2(ref cpf, ref nome, ref idade);
            Console.WriteLine("Plano: ");
            string plano = Console.ReadLine();
            Paciente2 paciente2 = new Paciente2(cpf, nome , idade, plano);
            Console.WriteLine("Mostra médico");
            Console.WriteLine(medico2.MostraMedico());
            Console.WriteLine("Mostra paciente");
            Console.WriteLine(paciente2.MostraPaciente());
            Console.ReadKey();
        }
    }
}
