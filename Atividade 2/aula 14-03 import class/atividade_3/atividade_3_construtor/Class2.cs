using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3_const
{
    public class FormGeom
    {
        private double altura;
        private double largura;
        public FormGeom(double altura, double largura)
        {
            this.altura = (altura < 0) ? 0 : altura; 
            this.largura = (largura < 0) ? 0 : largura;
        }
        public double AreaTriangulo => altura * largura / 2;
    }
}
