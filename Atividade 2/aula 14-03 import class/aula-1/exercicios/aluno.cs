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
        public void GravaAluno()
        {
            Console.WriteLine("Entre com a matrícula do aluno:");
            matricula = Console.ReadLine();
            
            Console.WriteLine("Entre com o nome do aluno:");
            nome = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Entre com a {i + 1}.a nota do aluno:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public void MostraAluno()
        {
            Console.WriteLine(matricula == null ? "A matrícula ainda não foi declarada. Declare a matrícula antes!"
                : "Matrícula do aluno: " + matricula);

            Console.WriteLine(nome == null? "O nome ainda não foi declarado. Declare o nome antes!" :
                "Nome do aluno: " + nome);

            for (int i = 0; i < 4; i++)
                Console.WriteLine($"{i + 1}.a Nota: {vetor[i]}");            
        }
    }
}
