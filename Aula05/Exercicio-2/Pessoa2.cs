using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Pessoa2
    {
        private string cpf, nome;
        private int idade;
        
        public string Mostra() => $"\nNome: {nome}\nIdade: {idade}\nCPF: {cpf}";
        public Pessoa2(string cpf, string nome, int idade)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.idade = idade;
        }
    }
}
