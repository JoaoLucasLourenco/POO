using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ListaAgenda
{
    public class Agenda
    {
        string cidade;
        int codigo;
        string[] fone;
        string nome;
        public Agenda(string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
            fone = new string[3];
        }

        public string Cidade { get => cidade; }
        public int Codigo { get => codigo; set => codigo = value < 0 ? 0 : value; }
        public string[] Fone { set => fone = value; }
        public string Nome { get => nome; }

        public string Mostra()
        {
            string mostra_fone = "";
            for (int i = 0; i < fone.Length; i++)
            {
                mostra_fone += $"{fone[i]}\n";
            }
            return $"Nome: {nome}\nCidade: {cidade}\nTelefones: {mostra_fone}\nCódigo: {codigo}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Agenda> lista_ag = new List<Agenda>();
            Agenda ag;
            string nome, cidade;
            string[] fone = new string[3];
            string op = "s";
            while (op == "s")
            {
                Console.WriteLine("Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Cidade:");
                cidade = Console.ReadLine();
                ag = new Agenda(nome, cidade);
                Console.WriteLine("Código:");
                ag.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Telefones:");
                for (int i = 0; i < fone.Length; i++)
                    fone[i] = Console.ReadLine();
                ag.Fone = fone;
                lista_ag.Add(ag);
                Console.WriteLine("Continuar? s/n");
                op = Console.ReadLine();
            }
            
            foreach(var i in  lista_ag)           
                Console.WriteLine(i.Mostra());
            Console.ReadKey();
        }
    }
}
