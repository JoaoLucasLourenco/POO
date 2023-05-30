using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gasolina G1 = new Gasolina("Petrobrás","Aditivada");
            G1.Preço = 3.65;
            G1.Validade.GravaData(12, 12, 2020);
            Diesel D1 = new Diesel("Shell");
            D1.Preço = 2.78;
            D1.Validade.GravaData(13,11,2019);
            Mostrar(G1);
            Mostrar(D1);
            Console.ReadKey();
        }
        static void Mostrar(Combustivel C)
        {
            Console.WriteLine(C.Dados());
            if (C is Gasolina)
                Console.WriteLine($"Tipo: {(C as Gasolina).Tipo}\nPreço Bomba Gasolina: {(C as Gasolina).PrecoBombaGasolina().ToString("0.00")}");
            if(C is Diesel)
                Console.WriteLine($"Preço Bomba Diesel: { (C as Diesel).PrecoBombaDiesel().ToString("0.00")}");
        }
    }
}
