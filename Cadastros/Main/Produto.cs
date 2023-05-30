using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Produto
    {
        private string nome;
        private double valor;
        private int identificador;
        private string descricao;
        private int codigodebarra;

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Identificador { get => identificador; set => identificador = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Codigodebarra { get => codigodebarra; set => codigodebarra = value; }
        
        public void MudarProduto(int id, int op)
        {
            switch (op) 
            {
                case 1://Mudar nome
                    
                    break;
                case 2://Mudar Valor
                    break;
                case 3://Mudar Descrição
                    break;
                case 4://Mudar codigo de barra
                    break;
                case 5://Mudar tudo
                    break;
            }
        }
    }
}
