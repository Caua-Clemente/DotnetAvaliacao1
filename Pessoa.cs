using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAvaliacao1
{
    public abstract class Pessoa
    {
        private string nome;
        public string Nome {get; set;}

        private string cpf;
        public string Cpf {get; set;}

        private DateTime dataNascimento;
        public DateTime DataNascimento {get; set;}
        
    }
}