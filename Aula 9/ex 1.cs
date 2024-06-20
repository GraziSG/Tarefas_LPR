using System;

class ex1
{
    public struct Produto
    {
        public string Nome;
        public int Codigo;
        public float Preco;
        public int Quantidade;
    }
    static void Main()
    {
        Produto p1; Produto p2; Produto p3;

        Console.WriteLine("Insira o nome, o código, o preço e a quantidade do produto 1:");
        p1.Nome = Console.ReadLine();
        p1.Codigo = int.Parse(Console.ReadLine());
        p1.Preco = float.Parse(Console.ReadLine());
        p1.Quantidade = int.Parse(Console.ReadLine());


        Console.WriteLine("\nInsira o nome, o código, o preço e a quantidade do produto 2:");
        p2.Nome = Console.ReadLine();
        p2.Codigo = int.Parse(Console.ReadLine());
        p2.Preco = float.Parse(Console.ReadLine());
        p2.Quantidade = int.Parse(Console.ReadLine());


        Console.WriteLine("\nInsira o nome, o código, o preço e a quantidade do produto 3:");
        p3.Nome = Console.ReadLine();
        p3.Codigo = int.Parse(Console.ReadLine());
        p3.Preco = float.Parse(Console.ReadLine());
        p3.Quantidade = int.Parse(Console.ReadLine());

        float ValorTotal = (p1.Preco * p1.Quantidade) + (p2.Preco * p2.Quantidade) + (p3.Preco * p3.Quantidade);

        Console.WriteLine($"\nO valor total é R${ValorTotal}");

    }
}