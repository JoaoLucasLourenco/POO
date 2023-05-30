using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDATA
{
    internal class Tdata
    {
        private int dia, mes, ano;
        public bool GravaData(int d,int m,int a)
        {
            if(m<1 || m>12)
                return false;
            else if(d < 1 || d>30)
                return false;
            if (m == 2 && d > 28)
                return false;
            else
            {
                dia = d; mes = m; ano = a;
            }
            return true;
        }
        public string MostraData()
        {
            string msg = "";
            string sauxd = dia<10?$"0{dia}": dia.ToString();
            string sauxm = mes < 10 ? $"0{mes}" : mes.ToString();
            string sauxa = ano.ToString();
            msg = $"{sauxd}/{sauxm}/{sauxa}";

            return msg;
        }
    }
}
