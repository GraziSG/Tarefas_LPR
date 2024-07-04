using System;
using System.Collections.Generic;
using System.Linq;

class Exdici
{
    static void Main()
    {
        Dictionary<string, int> Pessoas = new Dictionary<string, int>
         { { "João", 17 },{ "Maria", 18 },{ "Pedro", 16 },{ "Ana", 19 },{ "Lucas", 20 } };

        int soma = 0;
        double media = 0;
        int maiorIdade = 0, menorIdade = 300;

        foreach (var idade in Pessoas)
        {
            soma += idade.Value;
            if (idade.Value > maiorIdade)
            {
                maiorIdade = idade.Value;
            }
            if(idade.Value < menorIdade)
            {
                menorIdade = idade.Value;
            }
        }
        media = soma / Pessoas.Count;
        Console.WriteLine($"Média: {media}\n");

        foreach (var acimaMedia in Pessoas)
        {
            if (acimaMedia.Value > media)
            {
                Console.WriteLine($"{acimaMedia.Key} tem idade acima da média ({acimaMedia.Value})");
            }
           
        }
        foreach (var pessoa in Pessoas)
        {
            if (pessoa.Value == maiorIdade) Console.WriteLine($"\n{pessoa.Key} é a pessoa mais velha com {pessoa.Value} anos");
            else if (pessoa.Value == menorIdade) Console.WriteLine($"\n{pessoa.Key} é a pessoa mais nova com {pessoa.Value} anos");
        }
        Console.WriteLine("\nDigite a idade que deseja remover:");
        int idadeRemover = int.Parse( Console.ReadLine() );

        Console.WriteLine("\nLista depois de remover: \n");
        foreach(var remove  in Pessoas)
        {
            if (remove.Value == idadeRemover) Pessoas.Remove(remove.Key);
       }
        foreach(var pessoa in Pessoas)
        {
            Console.WriteLine($"{pessoa.Key},{pessoa.Value}");
        }
    }
}
