using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            Gato g2 = new Gato();
            g1.Name = "GATO1";g2.Name = "Gato2";
            Cachorro c1 = new Cachorro();
            Cachorro c2 = new Cachorro();
            c1.Name = "DOG1";c2.Name = "DOG2";
            List<Animal>a = new List<Animal>();
            a.Add(g1); a.Add(c1); a.Add(g2); a.Add(c2);
            foreach (var i in a)
                Dados(i);
            Console.ReadKey();
        }
        static void Dados(Animal A)
        {
            Console.WriteLine(A.QuemSou());
        }
    }
}
