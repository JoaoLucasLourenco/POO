using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace aluno
    {
        public class Aluno
        {
            private string matricula = null;
            private string nome = null;
            private int[] vetor;
            public Aluno()
            {
                vetor = new int[4];
            }
            public void GravaAluno(string matricula,string nome, int[] v)
            {
                this.matricula = matricula;
                this.nome = nome;
                vetor = v;
            }
            public string MostraAluno()
            {
                string notas = "";
                for(int i = 0;i < vetor.Length; i++)       
                    notas += $" {vetor[i]}";
                return $"Matrícula: {matricula}\nNome: {nome}\nNotas: {notas}";
            }
        }
    }


