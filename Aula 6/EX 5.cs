using System;
class ex5
{
    static void Main()
    {
        float horasTreinadas = 0;
        int dia, mes;

      
            for (int i = 0; i < 5; i++)
            {

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Insira quantas horas você treinou hoje:");
                Console.ResetColor();
                float horaDiaria = float.Parse(Console.ReadLine());

                horasTreinadas += horaDiaria;
            }

            int semana = (int)(1000 / horasTreinadas);
            dia = semana * 5;
            mes = (int)(semana / 4.5);

            Console.WriteLine($"Considerando que você treina {horasTreinadas} horas por semana (desconsiderando sábados e domingos), faltam (aproximadamente) para completar 1000 horas de treinamento: \n{semana} semanas \n{dia} dias \n{mes} meses");
      
    
        
        }
        
}