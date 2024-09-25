Random random = new Random();
string[] itensMenu = {"Salada Caesar com frango grelhado", "Lasanha à bolonhesa", "Filé de peixe grelhado com legumes", "Strogonoff de frango com arroz e batata palha", "Feijoada com arroz e couve", "Escondidinho de carne seca com purê de mandioca", "Macarrão ao pesto com tomates cereja", "Bife à milanesa com purê de batata", "Frango à parmegiana com arroz e salada", "Tacos de carne ou frango com guacamole", "Ceviche com batata doce", "Poke bowl com atum, abacate e quinoa", "Quiche de espinafre e ricota com salada", "Hambúrguer artesanal com batatas rústicas"};
int contador = 1;
string escolhas = "";
int nmr;


foreach(string itens in itensMenu)
{
    Console.WriteLine($"{contador}.".PadRight(4) + $"{itens}");
    contador ++;
}


Console.Write("Escolha as opções do cardápio ou digite 0 para gerar um prato aleatorio: ");
while(!int.TryParse(Console.ReadLine(), out nmr) || nmr > itensMenu.Length || nmr < 0){Console.Write("Digite um valor válido: ");}


while(nmr != 0)
{
    escolhas += itensMenu[nmr - 1] + "\n";
    Console.WriteLine($"\nEscolhas:\n{escolhas}");

    Console.Write("Deseja continuar escolhendo? Digite o número do prato ou 0 para sair: ");
    while(!int.TryParse(Console.ReadLine(), out nmr) || nmr > itensMenu.Length || nmr < 0){Console.Write("Digite um valor válido: ");}
}

int randomNmr = random.Next(0, itensMenu.Length + 1);
Console.Write($"Prato gerado: {itensMenu[randomNmr]}");