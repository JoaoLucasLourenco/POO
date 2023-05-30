using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Paciente:Pessoa
    {
        private string plano;

        public string Plano { get => plano; set => plano = value; }
        public string MostraPaciente()=>$"{base.Mostra()}\nPlano:{Plano}";
    }
}
