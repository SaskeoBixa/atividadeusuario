Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("+------------------------------+");
Console.WriteLine("|       Dados do Usuário       |");
Console.WriteLine("+------------------------------+");
Console.Write("| Insira seu nome: ");
String nome = Console.ReadLine()!;

Console.Write("| Insira seu sobrenome: "); 
String sobrenome = Console.ReadLine()!;

Console.WriteLine("+------------------------------+");
Console.ResetColor();
Console.WriteLine($"\nOla, {nome} {sobrenome}, seja bem vindo(a)!\n");