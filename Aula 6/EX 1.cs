using System;

class ex1
{
    static void Main()
    {
        int contador1 = 0;
        int contador2 = 0;
        double acumulador = 0;

        Console.WriteLine("Insira a quantidade de números que serão digitados: ");
        int numDigit = int.Parse(Console.ReadLine());


        while (contador2 < numDigit)
        {
            Console.WriteLine("Digite um número");
            int numAnalisado = int.Parse(Console.ReadLine());

            contador2++;

            if (numAnalisado % 2 == 0)
            {
                acumulador += numAnalisado;
                contador1++;
            }
        }
  
        double media = acumulador/contador1;

        Console.WriteLine(media);
    }
}