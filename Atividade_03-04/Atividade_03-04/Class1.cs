using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAtividade_03_04
{
    public class Aluno
    {
        private string nome;
        private string cidade;
        private int[] notas;
        public Aluno(string nome)
        {
            this.nome = nome;
            Notas = new int[3];
        }
        public string Nome { get => nome; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int[] Notas { set => notas = value; }
        public string MostraNotas()
        {
            string aux = "";
            for (int i = 0; i < 2; i++)
            {
                aux += notas[i] + "\t";
                int menor = i;
                for (int j = i + 1; j < 3; j++)
                {
                    if (notas[j] < notas[menor]) menor = j;
                }
                if (menor != i)
                {
                    int temp = notas[i];
                    notas[i] = notas[menor];
                    notas[menor] = temp;

                }
            }
            aux += notas[notas.Length - 1];
            double media = (notas[notas.Length - 1] + notas[notas.Length - 2]) / 2;
            aux += "\nMédia das duas maiores notas: " + media;
            return aux;
        }
    }
}
