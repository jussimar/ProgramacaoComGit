using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoComGit
{
    internal class Aluno
    {

        //Atributos
        public string nome;
        public int anoNascimento;

        //métodos
        public int calcularIdade()
        {
            return 2026 - this.anoNascimento;
        } 
    }
}
