using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tempo em segundos: ");
        if(int.TryParse(Console.ReadLine(), out int totalSegundos))
        {
            for (int i = totalSegundos; i >= 0; i--)
            {
                TimeSpan ts = TimeSpan.FromSeconds(i);
                Console.Clear();
                Console.WriteLine($"Tempo restante: {ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}:{ts.Milliseconds /10:D2}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Tempo esgotado!");

        }
        else
        {
            Console.WriteLine("Entrada Inválida. Por favor, insira um número inteiro.");
        }
    }
}
