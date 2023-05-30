using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Laboratório_16_05
{
    class TCPF
    {
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
        }
        public bool ValidaCpf(string cpf)
        {
            this.cpf = cpf;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        public string MostraCPF()
        {
            string msg = "";
            long auxCPF = long.Parse(cpf);
            string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", auxCPF);
            msg = CPFFormatado;
            return msg;
        }
    }
    class Pessoa
    {
        private TCPF cpf1;
        private int idade;
        private string nome;

        public int Idade { set => idade = value; }
        public string Nome { set => nome = value; }
        internal TCPF Cpf1 { get => cpf1; set => cpf1 = value; }
        public string MostraPessoa() => $"Nome: {nome}\nIdade: {idade}\nCPF: {cpf1.MostraCPF()}\n";
        public Pessoa()
        {
            cpf1 = new TCPF();
        }
    }
    class Aluno : Pessoa 
    {
        private string matricula;

        public string Matricula { get => matricula; set => matricula = value; }

        public string MostraAluno() => $"{base.MostraPessoa()}Matrícula: {Matricula}";
    }
    class Professor : Pessoa
    {
        private string titulacao;

        public string Titulacao { get => titulacao; set => titulacao = value; }
        public string MostraProfessor() => $"{base.MostraPessoa()}Titulação: {Titulacao}";
    }
}
