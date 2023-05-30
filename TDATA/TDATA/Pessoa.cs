using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDATA;

namespace TDATA
{
    internal class Pessoa
    {
        private string nome;
        private Tdata dn;
        public Pessoa(string nome)
        {
            this.nome = nome;
            dn = new Tdata();
        }
        public string Nome { get => nome; }
        public Tdata Dn { get => dn;}
    }
}
