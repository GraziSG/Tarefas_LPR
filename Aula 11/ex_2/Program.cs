using System;

namespace AulaPOOex2
{
    class Aula11
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salarioBruto);
            funcionario.MostrarDados();

            short opcao;

            Console.WriteLine("\nVocê deseja aumentar o salário desse funcionário? \n0 = NÃO\n1 = SIM");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao) 
            {
                case 0: Console.WriteLine("\nPrograma finalizando..."); break;
                case 1: 
                    Console.WriteLine("\nDigite o valor percentual do aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    funcionario.AumentSalario(porcentagem);
                    funcionario.MostrarDados();
                    break;
                default: Console.WriteLine("\nPrograma finalizando..."); break;
            }         
        }
    }
}