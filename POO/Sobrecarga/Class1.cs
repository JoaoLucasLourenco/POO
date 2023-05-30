using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Matematica
    {
        private int x, y, z;
        private double w;

        public Matematica(int x, double w) { this.x = x; this.w = w; }
        public Matematica(int x, int y) { this.x = x; this.y = y; }
        public Matematica(int x, int y, int z) { this.x = x; this.y = y; this.z = z; }
        public string Mostra() => $"FAZUELI - {x} - {y} - {z} - {w}";
    }

    
}
