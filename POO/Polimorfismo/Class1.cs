using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Animal {
        private string name;
        public string Name { get => name; set => name = value; }
        virtual public string QuemSou() => "Sou da classe ";
    }
    class Cachorro:Animal
    {
        override public string QuemSou() =>base.QuemSou() + $"Dog me chamo {Name}";
    }
    class Gato : Animal { override public string QuemSou() => base.QuemSou() + $"Gato me chamo {Name}";}

}
