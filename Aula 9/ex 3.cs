using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class ex3
{
    static int PontuacaoTotal = 0;
    public struct Herois
    {
        public string Nome;
        public string Poder;
        public int Pontuacao;
    }
    
      static Herois CadastrarHerois()
    {
        Herois h;
        Console.WriteLine ("\nInsira o nome do(a) herói(na): ");
        h.Nome = Console.ReadLine();
        Console.WriteLine("Insira o poder dele(a): ");
        h.Poder = Console.ReadLine();
        Console.WriteLine("Insira a pontuação:");
        h.Pontuacao = int.Parse(Console.ReadLine());
        return h;
    }
    static void SelecionarEquipe(Herois h)
    {
        Console.WriteLine($"\nHerói(na): {h.Nome} \nPoder: {h.Poder}");
    }
    static int CalcularPontos(Herois h)
    {      
        PontuacaoTotal += h.Pontuacao;
        return PontuacaoTotal;
    } 
    static void ExibirEquipe(Herois h)
    {
        Console.WriteLine($"\nHerói(na): {h.Nome} \nPoder: {h.Poder} \nPontuação: {h.Pontuacao}");
    }
    static void Main() 
    {
        short opcao;
        Herois[] herois = new Herois [5];
        Herois[] herois_escolhidos = new Herois[3];
        short i;
        int escolha1, escolha2, escolha3;
        do
        {
            Console.WriteLine("Bem vindo ao SSHM (Sistema de Seleção de Heróis da Marvel!");
            Console.WriteLine("\nPor favor selecione a opção desejada:");
            Console.WriteLine("1 = Cadastrar 5 Heróis \n2 = Selecionar Equipe \n3= Exibir Equipe \n4 = Sair do Programa");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:               
                    for (i = 0; i < 5; i++)
                    {
                        herois[i] = CadastrarHerois();     
                    }
                break;

                case 2:
                    Console.WriteLine("\nSelecione o número de 3 heróis(nas) para a equipe (o primeiro é 1 e assim por diante");
                    for (i = 0; i < 5; i++)
                    {
                        SelecionarEquipe(herois[i]);
                    }
                   // do
                   // {
                        escolha1 = int.Parse(Console.ReadLine());
                        escolha2 = int.Parse(Console.ReadLine());
                        escolha3 = int.Parse(Console.ReadLine());

                      /*  if(escolha1 == escolha2 || escolha2 == escolha3 || escolha3 == escolha1)
                        {
                            Console.WriteLine("Você digitou números iguais, por favor escolha novamente");
                        }*/

                   // } while (escolha1 == escolha2 || escolha2 == escolha3 || escolha3 = escolha1);
                    for (i = 0; i < 5; i++)
                    {
                        //do
                       // {
                            int escolha = i + 1;
                            if (escolha1 == escolha) herois_escolhidos[i] = herois[i];
                            else if (escolha2 == escolha) herois_escolhidos[i] = herois[i];
                            else if (escolha3 == escolha) herois_escolhidos[i] = herois[i];
                            
                      //  } while (herois_escolhidos.Length < 3);
                        for (i = 0; i < 3; i++)
                        {
                            CalcularPontos(herois_escolhidos[i]);
                        }
                    }
                break;

                case 3:
                       for (i = 0; i < 3; i++)
                    {
                        ExibirEquipe(herois_escolhidos[i]);
                        Console.WriteLine($"\nPontuação total = {PontuacaoTotal}");
                    }
                break;

                default:
                    Console.WriteLine("Saindo do programa...");                
                break;
            }
        } while (opcao != 4);
    
    }
}
