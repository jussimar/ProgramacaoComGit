using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoComGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "Maria";
            a1.anoNascimento = 1993;

            Console.WriteLine("A Idade da "+a1.nome+" é: " +a1.calcularIdade());

            Console.ReadKey();
            
        }
    }
}
