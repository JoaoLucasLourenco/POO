using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_18_04
{
    public class TEndereço
    {
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        private int cep;

        public string Rua {set => rua = value; }
        public int Numero {set => numero = value; }
        public string Bairro {set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Cep {set => cep = value; }
        public string MostraEndereco()
        {
            string aux = "";
            aux = $"Rua: {rua}\nNumero: {numero}\nBairro: {bairro}\nCidade: {Cidade}\nCep: {cep}\nEstado: {Estado}";
            return aux;
        }
    }
}
