using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string continuar;

        do
        {
            int dado = random.Next(1, 7);
            Console.WriteLine($"Dado: {dado}");
            DesenharDado(dado);

            Console.WriteLine("Deseja lançar o dado novamente? (s/n)");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        Console.WriteLine("Obrigado por jogar!");
    }

    static void DesenharDado(int valor)
    {
        switch (valor)
        {
            case 1:
                Console.WriteLine("+---------+");
                Console.WriteLine("|         |");
                Console.WriteLine("|    •    |");
                Console.WriteLine("|         |");
                Console.WriteLine("+---------+");
                break;
            case 2:
                Console.WriteLine("+---------+");
                Console.WriteLine("| •       |");
                Console.WriteLine("|         |");
                Console.WriteLine("|       • |");
                Console.WriteLine("+---------+");
                break;
            case 3:
                Console.WriteLine("+---------+");
                Console.WriteLine("| •       |");
                Console.WriteLine("|    •    |");
                Console.WriteLine("|       • |");
                Console.WriteLine("+---------+");
                break;
            case 4:
                Console.WriteLine("+---------+");
                Console.WriteLine("| •     • |");
                Console.WriteLine("|         |");
                Console.WriteLine("| •     • |");
                Console.WriteLine("+---------+");
                break;
            case 5:
                Console.WriteLine("+---------+");
                Console.WriteLine("| •     • |");
                Console.WriteLine("|    •    |");
                Console.WriteLine("| •     • |");
                Console.WriteLine("+---------+");
                break;
            case 6:
                Console.WriteLine("+---------+");
                Console.WriteLine("| •     • |");
                Console.WriteLine("| •     • |");
                Console.WriteLine("| •     • |");
                Console.WriteLine("+---------+");
                break;
        }
    }
}
