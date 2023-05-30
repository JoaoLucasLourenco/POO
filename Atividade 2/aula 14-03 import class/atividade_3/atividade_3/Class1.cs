using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3
{
    public class FormGeom
    {
        private double altura;
        private double largura;
        
        public double Largura
        {
            get => largura;
            set => largura = (value < 0) ? 0 : value;
        }
        public double Altura
        {
            get => altura;
            set => altura = (value < 0) ? 0 : value;
        }
        public double AreaTriangulo => altura * largura / 2;
    }
}
