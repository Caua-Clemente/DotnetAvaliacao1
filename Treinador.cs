using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAvaliacao1
{
    public class Treinador : Pessoa
    {
        private string cref;
        public string Cref {get; set;}

        public Treinador(string nome, string cpf, DateTime data, string cref){
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = data;
            this.Cref = cref;
        }
    }
}