Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("+------------------------------+");
Console.WriteLine("|       Dados do Usuário       |");
Console.WriteLine("+------------------------------+");
Console.WriteLine("| Insira seu nome:             |");
String nome = Console.ReadLine().PadLeft(1 , '|')!;

Console.WriteLine("| Insira seu sobrenome:        |");
String sobrenome = Console.ReadLine()!;

Console.WriteLine("+------------------------------+");
Console.ResetColor();
Console.WriteLine($"\nOla, {nome} {sobrenome}, seja bem vindo(a)!");