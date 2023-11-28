using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAvaliacao1
{
    public class Cliente : Pessoa
    {
        private float peso;
        public float Peso{get; set;}

        private float altura;
        public float Altura{get; set;}

        public Cliente(string nome, string cpf, DateTime data, float altura, float peso){
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = data;
            this.Altura = altura;
            this.Peso = peso;
        }
    }
}