using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Medico2:Pessoa2
    {
        private string crm, especialidade;
       
        public string MostraMedico() => $"{base.Mostra()}\nCRM: {crm}\nEspecialidade: {especialidade}";

        public Medico2(string cpf, string nome, int idade, string crm, string especialidade):base(cpf,nome,idade) 
        {
            this.crm = crm;
            this.especialidade = especialidade;
        }
    }
}
