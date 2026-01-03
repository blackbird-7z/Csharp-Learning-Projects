using System.Text; 

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Pressione ENTER para entrar na Matrix...");
Console.ReadKey();
Console.Clear();

while (!Console.KeyAvailable)
{
    StringBuilder linha = new StringBuilder();

    int larguraTela = Console.WindowWidth;

    for (int j = 0; j < larguraTela; j++)
    {
        int n = Random.Shared.Next(5);

        // Lógica ternária (if/else em uma linha só)
        string caractere = (n < 2) ? n.ToString() : " ";

        linha.Append(caractere);
    }

    Console.WriteLine(linha);
    System.Threading.Thread.Sleep(33);
}

Console.ResetColor();
Console.WriteLine("\nDesconectado da Matrix.");