using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Atividade4Class
{
    public class Agenda 
    {
        string cidade;
        int codigo;
        string[] fone;
        string nome;
        public Agenda(string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
            fone = new string[3];
        }

        public string Cidade { get => cidade;}
        public int Codigo { get => codigo; set => codigo = value<0?0:value; }
        public string[] Fone {set => fone = value; }    
        public string Nome { get => nome;}

        public string Mostra()
        {
            string mostra_fone = "";
            for(int i = 0;i<fone.Length; i++)
            {
                mostra_fone += $"{fone[i]}\n";
            }
            return $"Nome: {nome}\nCidade: {cidade}\nTelefones: {mostra_fone}\nCódigo: {codigo}";
        }
    }

}
