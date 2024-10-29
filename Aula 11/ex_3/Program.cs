using System;

namespace AulaPOOex3
{
    class Aula11
    {
        static void Main()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Insira o nome do aluno e o número da matrícula: ");
            aluno.nome = Console.ReadLine();
            aluno.marticula = short.Parse(Console.ReadLine());
            Console.WriteLine("Insira as notas das 2 provas e do trabalho, respectivamente:");
            aluno.prova1 = double.Parse(Console.ReadLine());
            aluno.prova2 = double.Parse(Console.ReadLine());
            aluno.trabalho = double.Parse(Console.ReadLine());

            double media_aluno = aluno.media();
            double valor_final = aluno.final();

            Console.WriteLine($"\nA média do aluno é: {media_aluno}");

            Console.WriteLine($"Ele precisa tirar {valor_final} para fazer a final");

        }

    }
}