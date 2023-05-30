using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_18_04
{
    public class Paciente
    {
        private TEndereço end;
        private string nome;
        private int idade;
        public Paciente(string nome)
        {
            this.nome = nome;
            end = new TEndereço();
        }
        public TEndereço End{ get => end; }
        public int Idade { get => idade; set => idade = value; }

        public string Nome { get => nome;}
    }
}
