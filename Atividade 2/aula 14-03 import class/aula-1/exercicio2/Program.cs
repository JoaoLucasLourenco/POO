using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aluno;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            string m = "123", n = "jao"; int[] vetor = new int[4] { 1,2,3,4};
            a1.GravaAluno(m, n, vetor);
            Console.WriteLine(a1.MostraAluno());
            Console.ReadLine();
        }
    }
}
