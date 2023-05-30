using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDATA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("jao");
            p1.Dn.GravaData(24,5,2004);
            Console.WriteLine(p1.Dn.MostraData());
            Console.ReadLine();
        }
    }
}
