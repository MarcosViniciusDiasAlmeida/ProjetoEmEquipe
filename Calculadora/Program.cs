
Console.Write("Digite o primeiro valor: "); 
if(double.TryParse(Console.ReadLine(), out double Valor1))
{
Console.Write("Digite o segundo valor: ");
if(double.TryParse(Console.ReadLine(), out double Valor2))
{
    Console.Write("Insira o Operador (+) (-) (*) (/): ");
    string operador = Console.ReadLine();
    switch(operador)
    {
        case "+":
        Console.WriteLine($"O resultado é: {(Valor1+Valor2)}");
        break;
        
        case "-":
        Console.WriteLine($"O resultado é: {(Valor1-Valor2)}");
        break;

         case "*":
        Console.WriteLine($"O resultado é: {(Valor1*Valor2)}");
        break;

        case "/":
        if(Valor2==0)
            Console.WriteLine("Não é possível realizar a divisão por 0");
        else
            Console.WriteLine($"O resultado é: {(Valor1/Valor2)}");
        break;
    }
}
else
{
    Console.WriteLine("O valor inserido deve ser Numérico, digite um novo valor");
}
}
else
{
    Console.WriteLine("O valor inserido deve ser Numérico, digite um novo valor");
}
