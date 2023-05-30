using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSala
{
    internal class Tdata
    {
        private int dia, mes, ano;
        public bool GravaData(int d, int m, int a)
        {
            if (m < 1 || m > 12)
                return false;
            else if (d < 1 || d > 30)
                return false;
            if (m == 2 && d > 28)
                return false;
            else
            {
                dia = d; mes = m; ano = a;
            }
            return true;
        }
        public string MostraData()
        {
            string msg = "";
            string sauxd = dia < 10 ? $"0{dia}" : dia.ToString();
            string sauxm = mes < 10 ? $"0{mes}" : mes.ToString();
            string sauxa = ano.ToString();
            msg = $"{sauxd}/{sauxm}/{sauxa}";

            return msg;
        }
    }
    class Combustivel
    {
        private string fornecedor;
        private double preço;
        private Tdata validade;

        public string Fornecedor { get => fornecedor;}

        internal Tdata Validade { get => validade; set => validade = value; }
        public double Preço { get => preço; set => preço = value; }

        public Combustivel(string fornecedor)
        {
            Validade = new Tdata();
            this.fornecedor=fornecedor;
        }
        public string Dados() => $"\nFornecedor: {Fornecedor}\tPreço: {Preço}\tValidade: {Validade.MostraData()}";
        

    }
    class Gasolina : Combustivel
    {
        private string tipo;
        public Gasolina(string fornecedor, string tipo):base(fornecedor)
        {
            this.tipo = tipo;
        }
        public double PrecoBombaGasolina() => Preço * 1.2;
        
        public string Tipo { get => tipo;}
    }
    class Diesel:Combustivel
    {
        public Diesel(string fornecedor) : base(fornecedor) { }
        public double PrecoBombaDiesel() => Preço * 1.1510791367;
    }
}
