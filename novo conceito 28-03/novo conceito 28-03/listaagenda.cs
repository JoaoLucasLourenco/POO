using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace novo_conceito_28_03
{
    public class Pessoa 
    {
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public string Mostra() => $"Nome: {Nome}\nIdade: {Idade}";

    }

    internal class listaagenda
    {
        static void Main(string[] args)
        {
            Pessoa p_aux;
            List <Pessoa> Lista_Pessoa = new List<Pessoa>();
            do
            {
                p_aux = new Pessoa();
                p_aux.Nome = Console.ReadLine();
                p_aux.Idade = int.Parse(Console.ReadLine());
            } while (Console.ReadLine()=="s");
            Lista_Pessoa.Add(p_aux);
            Console.WriteLine(Lista_Pessoa[0].Mostra());
            Console.ReadKey();
        }
    }
}
