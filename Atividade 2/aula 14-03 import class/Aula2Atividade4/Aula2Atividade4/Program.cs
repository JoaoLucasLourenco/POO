using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula2Atividade4Class;

namespace Aula2Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidade, nome;
            string[] fone = new string[3];
            int codigo;
            nome = Console.ReadLine();
            cidade = Console.ReadLine();
            codigo = int.Parse(Console.ReadLine());
            Agenda ag = new Agenda(nome, cidade);
            for(int i = 0; i < fone.Length; i++)
            {
                fone[i] = Console.ReadLine();
            }
            ag.Fone= fone;
            ag.Codigo= codigo;
            Console.WriteLine(ag.Mostra());
            Console.ReadKey();

        }
    }
}
