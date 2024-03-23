using System;
class ex4
{
    static void Main()
    {
        int digito;
        int acumulador = 0;

        Console.WriteLine("Insira um valor inteiro:");
        int valor = int.Parse(Console.ReadLine());

        int quadrado = valor * valor;

        while (quadrado > 0)
        {
            digito = quadrado % 10;
            acumulador += digito;
            quadrado /= 10;
        }
        // coringuei fazendo esse exercício

        Console.WriteLine(acumulador);
    }
}