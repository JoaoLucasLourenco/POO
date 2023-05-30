using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicio_4_class;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Jao";
            string[] vacinas = new string[10];
            
            for (int i=0; i<vacinas.Length;i++)
            {
                vacinas[i] = i == 9 ?$" Vacina {i + 1}." :$" Vacina {i + 1},";
            }

            Paciente paci = new Paciente(nome);
            paci.Vacinas = vacinas;
            Console.WriteLine(paci.mostrar());
            Console.ReadKey();
        }
    }
}
