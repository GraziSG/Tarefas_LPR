using System;

class Matriz
{
    static void Main()
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matriz2 = new int[3, 3];
        int[,] matriz_resultante = new int[3, 3];

        Console.WriteLine("Adicione os 9 números da Matriz 1:");

        for (int linhas = 0; linhas < 3; linhas++)
        {
            for (int colunas = 0; colunas < 3; colunas++)
            {
                matriz1[linhas, colunas] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nAdicione os 9 números da Matriz 2:");
        for (int linhas = 0; linhas < 3; linhas++)
        {
            for (int colunas = 0; colunas < 3; colunas++)
            {
                matriz2[linhas, colunas] = int.Parse(Console.ReadLine());
            }
        }

        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
              //  matriz_resultante[l, c] = 0;
                for (int k = 0; k < 3; k++)
                {
                    matriz_resultante[l, c] += matriz1[l, k] * matriz2[k, c];
                }
            }
        }
        Console.WriteLine("\nResultado:\n");

        for (int l = 0;l < 3; l++)
        {
            for(int c = 0;c < 3; c++)
            {
                Console.WriteLine(matriz_resultante[l, c] + " ");
            }
        }
    }
}
/*
 * Logica pensada depois de ter feito tudo isso: 
 * Percebeu  que as matrizes utilizam o mesmo indice so que invertido? Basicamente indice 1 da matriz 1 eh o indice 2 da matriz 2 :D
 * Tambem da para perceber que a multiplicacao em si das linhas so alteram o valor do indice 1, por isso que ele eh "l" na conta, ele se mantem no mesmo valor ate trocar de linha :D

matriz1[0, 0] * matriz2[0, 0] + matriz1[0, 1] * matriz2[1, 0] + matriz1[0, 2] * matriz2[2, 0],

matriz1[0, 0] * matriz2[0, 1] + matriz1[0, 1] * matriz2[1, 1] + matriz1[0, 2] * matriz2[2, 1],

matriz1[0, 0] * matriz2[0, 2] + matriz1[0, 1] * matriz2[1, 2] + matriz1[0, 2] * matriz2[2, 2]},


{
    matriz1[1, 0] * matriz2[0, 0] + matriz1[1, 1] * matriz2[1, 0] + matriz1[1, 2] * matriz2[2, 0],

matriz1[1, 0] * matriz2[0, 1] + matriz1[1, 1] * matriz2[1, 1] + matriz1[1, 2] * matriz2[2, 1],

matriz1[1, 0] * matriz2[0, 2] + matriz1[1, 1] * matriz2[1, 2] + matriz1[1, 2] * matriz2[2, 2]
*/
