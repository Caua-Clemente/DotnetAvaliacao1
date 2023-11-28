using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAvaliacao1
{
    public static class Academia
    {
        public static void linqIdadeMinMax(List<Treinador> lista){
            Console.WriteLine($"Idade minima: ");
            int idadeMin = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Idade maxima: ");
            int idadeMax = int.Parse(Console.ReadLine());

            DateTime dataMinima = DateTime.Now;
            DateTime dataMaxima = DateTime.Now;

            dataMinima.AddYears(-idadeMin);
            dataMaxima.AddYears(-idadeMax);
            
            var novaLista = lista.Where(x => (x.DataNascimento <= dataMinima && x.DataNascimento >= dataMaxima));
            Console.WriteLine($"Lista de treinadores com idade entre {idadeMin} e {idadeMax}: ");
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }

        public static void linqIdadeMinMax(List<Cliente> lista){
            Console.WriteLine($"Idade minima: ");
            int idadeMin = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Idade maxima: ");
            int idadeMax = int.Parse(Console.ReadLine());

            DateTime dataMinima = DateTime.Now;
            DateTime dataMaxima = DateTime.Now;

            dataMinima.AddYears(-idadeMin);
            dataMaxima.AddYears(-idadeMax);
            
            var novaLista = lista.Where(x => (x.DataNascimento <= dataMinima && x.DataNascimento >= dataMaxima));
            Console.WriteLine($"Lista de clientes com idade entre {idadeMin} e {idadeMax}: ");
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }

        public static void linqIMC(List<Cliente> lista){
            Console.WriteLine($"IMC minimo: ");
            float imc = float.Parse(Console.ReadLine());

            var novaLista = lista.Where(x => (x.Peso / (x.Altura * x.Altura) >= imc));
            Console.WriteLine($"Lista de clientes com IMC maior ou igual a {imc}: ");
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }

        public static void linqOrdemAlfabetica(List<Cliente> lista){
            Console.WriteLine($"Lista de clientes em ordem alfabetica: ");

            var novaLista = lista.OrderBy(x => x.Nome).ToList();
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }

        public static void linqVelhoParaNovo(List<Cliente> lista){
            Console.WriteLine($"Lista de clientes do mais velho ao mais novo: ");

            var novaLista = lista.OrderBy(x => x.DataNascimento);
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }

        public static void linqAniversariantes(List<Cliente> listaCliente, List<Treinador> listaTreinador){
            Console.WriteLine($"Digite o mes desejado: ");
            int mes = int.Parse(Console.ReadLine());
            
            var novaLista = new List<Pessoa>();
            novaLista.AddRange(listaCliente.Where(x => x.DataNascimento.Month == mes));
            novaLista.AddRange(listaTreinador.Where(x => x.DataNascimento.Month == mes));
            Console.WriteLine($"Lista de clientes aniversariantes do mes {mes}: ");
            Console.WriteLine(string.Join("\n", (novaLista.Select(x => x.Nome))));
        }
    
        public static void criarCliente(ref List<Cliente> listaCliente){
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Altura (em metros): ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Peso (em Kg): ");
            float peso = float.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, cpf, data, altura, peso);
            listaCliente.Add(cliente);
        }

        public static void criarTreinador(ref List<Treinador> listaTreinador){
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("CREF: ");
            string cref = Console.ReadLine();

            Treinador treinador = new Treinador(nome, cpf, data, cref);
            listaTreinador.Add(treinador);
        }
    }
}