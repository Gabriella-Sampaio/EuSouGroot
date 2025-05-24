Console.Clear();

string pergunta = "",
       resposta = "Eu sou o Groot";

Console.WriteLine("Converse com o Groot");

while (pergunta != "TCHAU")
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!.ToUpper();

    Console.Write($"Resposta: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{resposta}\n");
    Console.ResetColor();
}

Console.WriteLine("Boa conversa, tchau");
