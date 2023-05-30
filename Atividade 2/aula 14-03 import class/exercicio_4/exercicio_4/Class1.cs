using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4_class
{
    public class Paciente
    {
        private string nome;
        private string[] vacinas;

        public string Nome { get => nome;}
        public string[] Vacinas {set => vacinas = value; }
        public Paciente(string nome) 
        {
            this.vacinas = new string[10];
            this.nome = nome;
        }
        public string mostrar()
        {
            string vacina = "";
            foreach (string v in vacinas)
            {
                vacina += v;
            }
            return $"Nome do paciente: {this.nome}\nVacinas tomadas: {vacina}";
        }
        
        
    }
}
