using System;
class ex3
{
    static string heroi1, heroi2, heroi3, heroi4, heroi5, poder1, poder2, poder3, poder4, poder5, heroi_escolhido1, heroi_escolhido2, heroi_escolhido3, poder_escolhido1, poder_escolhido2, poder_escolhido3;
    static int pontuacao_heroi1, pontuacao_heroi2, pontuacao_heroi3, pontuacao_heroi4, pontuacao_heroi5, pontuacao_escolhida1, pontuacao_escolhida2, pontuacao_escolhida3, PontoTotal;
    
    static void Cadastro1()
    {
        Console.WriteLine("\nInsira o nome do(a) herói(ina):");
        heroi1 = Console.ReadLine();
        Console.WriteLine("Insira o poder:");
        poder1 = Console.ReadLine();
        Console.WriteLine("Insira a pontuação");
        pontuacao_heroi1 = int.Parse(Console.ReadLine());

        Cadastro2();
    }
    static void Cadastro2()
    {
        Console.WriteLine("\nInsira o nome do(a) herói(ina):");
        heroi2 = Console.ReadLine();
        Console.WriteLine("Insira o poder:");
        poder2 = Console.ReadLine();
        Console.WriteLine("Insira a pontuação");
        pontuacao_heroi2 = int.Parse(Console.ReadLine());

        Cadastro3();
    }
    static void Cadastro3()
    {
        Console.WriteLine("\nInsira o nome do(a) herói(ina):");
        heroi3 = Console.ReadLine();
        Console.WriteLine("Insira o poder:");
        poder3 = Console.ReadLine();
        Console.WriteLine("Insira a pontuação");
        pontuacao_heroi3 = int.Parse(Console.ReadLine());

        Cadastro4();
    }
    static void Cadastro4()
    {
        Console.WriteLine("\nInsira o nome do(a) herói(ina):");
        heroi4 = Console.ReadLine();
        Console.WriteLine("Insira o poder:");
        poder4 = Console.ReadLine();
        Console.WriteLine("Insira a pontuação");
        pontuacao_heroi4 = int.Parse(Console.ReadLine());

        Cadastro5();
    }
    static void Cadastro5()
    {
        Console.WriteLine("\nInsira o nome do(a) herói(ina):");
        heroi5 = Console.ReadLine();
        Console.WriteLine("Insira o poder:");
        poder5 = Console.ReadLine();
        Console.WriteLine("Insira a pontuação");
        pontuacao_heroi5 = int.Parse(Console.ReadLine());

        Main();
    }

    static void SelecionarHeroi()
    {
        Console.WriteLine("\nVocê pode escolher até três heróis(inas), selecione os números dos escolhidos:");
        Console.WriteLine($"1 = Nome: {heroi1} Poder: {poder1} \n2 = Nome: {heroi2} Poder: {poder2} \n3 = Nome: {heroi3} Poder: {poder3} \n4 = Nome: {heroi4} Poder: {poder4} \n5 = Nome: {heroi5} Poder: {poder5}");
        int opcao1 = int.Parse(Console.ReadLine());
        int opcao2 = int.Parse(Console.ReadLine());
        int opcao3 = int.Parse(Console.ReadLine());

        switch (opcao1)
        {
            case 1:
                heroi_escolhido1 = heroi1;
                poder_escolhido1 = poder1;
                pontuacao_escolhida1 = pontuacao_heroi1;
                break;

            case 2:
                heroi_escolhido1 = heroi2;
                poder_escolhido1 = poder2;
                pontuacao_escolhida1 = pontuacao_heroi2;
                break;

            case 3:
                heroi_escolhido1 = heroi3;
                poder_escolhido1 = poder3;
                pontuacao_escolhida1 = pontuacao_heroi3;
                break;

            case 4:
                heroi_escolhido1 = heroi4;
                poder_escolhido1 = poder4;
                pontuacao_escolhida1 = pontuacao_heroi4;
                break;

            case 5:
                heroi_escolhido1 = heroi5;
                poder_escolhido1 = poder5;
                pontuacao_escolhida1 = pontuacao_heroi5;
                break;
        }

        switch (opcao3)
        {
            case 1:
                heroi_escolhido3 = heroi1;
                poder_escolhido3 = poder1;
                pontuacao_escolhida3 = pontuacao_heroi1;
                break;

            case 2:
                heroi_escolhido3 = heroi2;
                poder_escolhido3 = poder2;
                pontuacao_escolhida3 = pontuacao_heroi2;
                break;

            case 3:
                heroi_escolhido3 = heroi3;
                poder_escolhido3 = poder3;
                pontuacao_escolhida3 = pontuacao_heroi3;
                break;

            case 4:
                heroi_escolhido3 = heroi4;
                poder_escolhido3 = poder4;
                pontuacao_escolhida3 = pontuacao_heroi4;
                break;

            case 5:
                heroi_escolhido3 = heroi5;
                poder_escolhido3 = poder5;
                pontuacao_escolhida3 = pontuacao_heroi5;
                break;
        }

        switch (opcao2)
        {
            case 1:
                heroi_escolhido2 = heroi1;
                poder_escolhido2 = poder1;
                pontuacao_escolhida2 = pontuacao_heroi1;
                break;

            case 2:
                heroi_escolhido2 = heroi2;
                poder_escolhido2 = poder2;
                pontuacao_escolhida2 = pontuacao_heroi2;
                break;

            case 3:
                heroi_escolhido2 = heroi3;
                poder_escolhido2 = poder3;
                pontuacao_escolhida2 = pontuacao_heroi3;
                break;

            case 4:
                heroi_escolhido2 = heroi4;
                poder_escolhido2 = poder4;
                pontuacao_escolhida2 = pontuacao_heroi4;
                break;

            case 5:
                heroi_escolhido2 = heroi5;
                poder_escolhido2 = poder5;
                pontuacao_escolhida2  = pontuacao_heroi5;
                break;

                
        }

        PontoTotal = CalcularPontos();
    }
       static int CalcularPontos()
        {
         return pontuacao_escolhida1 + pontuacao_escolhida2 + pontuacao_escolhida3;
        
        }
    
    static void Exibir()
    {
        Console.WriteLine("\nSua equipe é composta por:");
        Console.WriteLine($"1 = {heroi_escolhido1} com o poder {poder_escolhido1} \n2 = {heroi_escolhido2} com o poder {poder_escolhido2} \n3 = {heroi_escolhido3} com o pode {poder_escolhido3}");
        Console.WriteLine($"Sua pontuação total é: {PontoTotal}");
    }
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nBem vindo ao SSHM (Sistema de Seleção de Heróis da Marvel! Selecione a opção desejada:");
            Console.WriteLine("1 = Cadastrar os 5 heróis \n2 = Escolher equipe \n3 = Exibir equipe \n4 = Sair do programa");
            opcao = int.Parse( Console.ReadLine() );

            switch( opcao )
            {
                case 1:
                    Cadastro1();
                    break;

                case 2:
                    SelecionarHeroi();
                    break;

                case 3:
                    Exibir();
                    break;

                 case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Número inválido");
                    break;

            }




        } while (opcao != 4);
    }
}