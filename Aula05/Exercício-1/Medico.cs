using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Medico:Pessoa
    {
        private string crm, especialidade;

        public string Crm { set => crm = value; }
        public string Especialidade { set => especialidade = value; }
        public string MostraMedico() => $"{base.Mostra()}\nCRM: {crm}\nEspecialidade: {especialidade}";
    }
}
