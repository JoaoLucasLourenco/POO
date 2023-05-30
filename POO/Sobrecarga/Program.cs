using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica m1 = new Matematica(3,1);
            Console.WriteLine(m1.Mostra());
            Console.ReadKey();
        }
    }
}
