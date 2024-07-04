using System;
using System.Collections.Generic;
using System.Collections.Specialized;class Exlist
{
    static void Main()
    {
        List<string> Nomes = new();
        var contador = 0;
        int teste = 11;

        int quantidadeNomes = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeNomes; i++)
        {
            string nome = Console.ReadLine();
            Nomes.Insert(i, nome);
        }

        do
        {
            foreach (var name in Nomes)
            {
                if (name.Length < teste)
                {
                    teste = name.Length;

                }
            }
            foreach (var nome in Nomes)
            {
                if (nome.Length == teste)
                {
                    Console.WriteLine(nome);
                    Nomes.Remove(nome);
                    
                }
            }
        }while (contador < quantidadeNomes);
        
    }
}