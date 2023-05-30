using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atividade_3_const;
namespace atividade_3_construtor
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Entre com a largura: ");
            double largura = double.Parse(Console.ReadLine());
            FormGeom geom = new FormGeom(altura, largura);
            
            Console.WriteLine($"A área do triangulo é: {geom.AreaTriangulo}");

            Console.ReadKey();
        }
    }
}
