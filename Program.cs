using System.Diagnostics;
using DotnetAvaliacao1;

List<Treinador> listaTreinadores = new List<Treinador>();
List<Cliente> listaClientes = new List<Cliente>();

int acao = 0;
do {
    Console.WriteLine($"1 - Treinadores com idade entre dois valores");
    Console.WriteLine($"2 - Clientes com idade entre dois valores");
    Console.WriteLine($"3 - Clientes com IMC maior que (n)");
    Console.WriteLine($"4 - Clientes em ordem alfabética");
    Console.WriteLine($"5 - Clientes do mais velho para mais novo");
    Console.WriteLine($"6 - Treinadores e clientes aniversariantes do mês informado");
    Console.WriteLine($"7 - Criar cliente");
    Console.WriteLine($"7 - Criar treinador");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine($"Digite uma opcao: ");
    acao = int.Parse(Console.ReadLine());
    
    switch(acao){
        case 0:
            Console.WriteLine($"Finalizando... \n");
        break;
        
        case 1:
            Academia.linqIdadeMinMax(listaTreinadores);
        break;
        
        case 2:
            Academia.linqIdadeMinMax(listaClientes);
        break;
        
        case 3:
            Academia.linqIMC(listaClientes);
        break;
        
        case 4:
            Academia.linqOrdemAlfabetica(listaClientes);
        break;
            
        case 5:
            Academia.linqVelhoParaNovo(listaClientes);
        break;
        
        case 6:
            Academia.linqAniversariantes(listaClientes, listaTreinadores);
        break;
        
        case 7:
            Academia.criarCliente(ref listaClientes);
        break;

        case 8:
            Academia.criarTreinador(ref listaTreinadores);
        break;
        
        default:
            Console.WriteLine($"Opcao invalida");
        break;
        
        
    }

} while (acao != 0);