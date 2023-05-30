using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Pessoa
    {
        private string cpf, nome;
        private int idade;
        public string Cpf { set { value = cpf; } }
        public string Nome { set { value = nome; } }
        public int Idade { set { value = idade; } }
        public string Mostra() => $"\nNome: {nome}\nIdade: {idade}\nCPF: {cpf}";
    }
}
