int valoraleat = 0;
int total = 0;

Random randNum = new Random();
int num = randNum.Next(1, 100);

while (num != valoraleat)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Adivinhe um número aleatório: ");
    Console.ResetColor();
    if (int.TryParse(Console.ReadLine(), out valoraleat))

        if (valoraleat < num)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Valor Acima!");
            Console.ResetColor();
            total++;
        }
        else if (valoraleat > num)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Valor Abaixo!");
            Console.ResetColor();
            total++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nNúmero Certo!\n");
            Console.ResetColor();
            total++;
        }
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"O numero era {num}.");
Console.WriteLine($"A quantidade de tentativas foram {total}.\n");
Console.ResetColor();