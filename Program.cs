Console.Clear();

string pergunta = "",
nomeUsuário;

Console.WriteLine("--- Chat com o Groot ---\n");
Console.Write("Digite deu nome: ");
nomeUsuário = Console.ReadLine()!;

Thread.Sleep(500); Console.Clear();

while (pergunta != "TCHAU")
{
    Console.Write($"{nomeUsuário}: ");
    pergunta = Console.ReadLine()!.ToUpper().Trim();
    if (pergunta == "TCHAU")
    {
        Resposta("Eu sou Groot!");
    }

    else
    {
        Resposta("Eu sou Groot.");
    }
}

Thread.Sleep(1000);Console.Clear();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Chat encerrado");
Console.ResetColor();

string Resposta (string mensagem)
{
    Thread.Sleep(300);
    Console.Write("                       Groot: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{mensagem}\n");
    Console.ResetColor();
    Thread.Sleep(300);
    return mensagem;
}
