//EXERCICIO 3

using System;

class Matriz
{
    static void Main()
    {
        int opcao1, opcao2;
        int[,] Cidaddes = {
            {0,1,2,3,4,},
            {1,0,524,521,882 },
            {2,524,0,434,586 },
            {3,521,434,0,429 },
            {4,882,586,429,0}
        };
        do { 
        
            Console.WriteLine("\nEscolha duas cidades para ver a distância entre elas: \n1 = Vitória \n2 = Belo Horizonte \n3 = Rio de Janeiro \n4 = São Paulo");
            opcao1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Aguardando segunda opção...");
            opcao2 = int.Parse(Console.ReadLine());

            int distancia = Cidaddes[opcao1, opcao2];

            Console.WriteLine($"A distância entre essas cidades é: {distancia}km");
        } while (opcao1 != opcao2);
    }
}