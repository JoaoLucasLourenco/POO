using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Paciente2:Pessoa2
    {
        
        private string plano;
 
        public string MostraPaciente() => $"{base.Mostra()}\nPlano:{plano}";
        public Paciente2(string cpf, string nome, int idade, string plano):base(cpf,nome,idade) => this.plano = plano;
        
    }
}
