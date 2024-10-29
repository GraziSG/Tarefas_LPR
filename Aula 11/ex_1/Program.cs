namespace AulaPOO
{
    internal class Aula11
    {
        static void Main()
        {
            Retangulo retangulo = new();

            Console.WriteLine("Insira o valor da altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            double area = retangulo.calcArea();
            double perimetro = retangulo.calPerimetro();

            Console.WriteLine($"\nO valor da área é: {area}");
            Console.WriteLine($"O valor do perímetro é: {perimetro}");


        }
    }
}