using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Me diga qual temperatura você deseja que eu converta?");
        Console.WriteLine("1: Celsius para Fahrenheit");
        Console.WriteLine("2: Celsius para Kelvin");
        Console.WriteLine("3: Fahrenheit para Celsius");
		Console.WriteLine("4: Fahrenheit para Kelvin");
		Console.WriteLine("5: Kelvin para Celsius");
		Console.WriteLine("6: Kelvin para Fahrenheit");
		
        int escolha = Convert.ToInt32(Console.ReadLine());
        double temperatura;

        Console.Write("Por favor, digite a temperatura: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine($"{temperatura}°C = {(temperatura * 9 / 5) + 32}°F");
                break;
            case 2:
                Console.WriteLine($"{temperatura}°C = {temperatura + 273.15}K");
                break;
            case 3:
                Console.WriteLine($"{temperatura}°F = {(temperatura - 32) * 5 / 9}°C");
                break;
            case 4:
				 Console.WriteLine($"{temperatura}°F = {(temperatura - 32) * 5 / 9 + 273.15}K");
                break;
            case 5:
                Console.WriteLine($"{temperatura}K = {temperatura - 273.15}°C");
                break;
			case 6:
            Console.WriteLine($"{temperatura}K = {(temperatura - 273.15) * 9 / 5 + 32}°F");
                break;
            
        }
    }
}