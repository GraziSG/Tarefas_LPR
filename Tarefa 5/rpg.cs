using System;

class ex3a
{
    static void Main()
    {
        Console.WriteLine("Selecione o número da classe desejada: \n1 = Ocultista \n2 = Especialista \n3 = Combatente\n");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Você escolheu a classe ocultista!");
                Console.ResetColor();
                Console.WriteLine("Habilidades = Capacidade de Executar Rituais e Possibilidade de Transcendência");

                break;

            case 2:

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você escolheu a classe especialista!");
                Console.ResetColor();
                Console.WriteLine("Habilidades = Precisão de Mira e Geração de Estratégia");

                break;

            case 3:

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Você escolheu a classe combatente!");
                Console.ResetColor();
                Console.WriteLine("Habilidades = Ataque Surpresa e Bônus por Dano");

                break;
        
            default:

                Console.WriteLine("Número inválido, por favor selecione 1,2 ou 3");

                break;

        } 
    }
}