Random random = new Random();
int lenght;
string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
string senha = "";

Console.Write("Digite o tamanho da senha (mín. 6 e máx. 16): ");
while(!int.TryParse(Console.ReadLine(), out lenght) || lenght < 6 || lenght > 16){Console.Write("Digite um valor válido: ");}

for(int i = 1; i <= lenght; i++)
{
    int ranNum = random.Next(0, chars.Length + 1);
    senha += chars[ranNum];
}

Console.Write($"Senha Aleatória Gerada: {senha}");
