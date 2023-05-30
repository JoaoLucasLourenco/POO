using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atividade_3;
using Microsoft.SqlServer.Server;

namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormGeom geom= new FormGeom();
            Console.Write("Entre com a altura: ");
            geom.Altura = double.Parse(Console.ReadLine());
            Console.Write("Entre com a largura: ");
            geom.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine($"A área do triangulo é: {geom.AreaTriangulo}");
            Console.ReadKey();
        }
    }
}
