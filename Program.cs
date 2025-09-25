
string sobrenome, nome;
Console.WriteLine("Digite seu sobrenome:");
sobrenome = Console.ReadLine()!;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine()!;
Console.WriteLine($"{nome} {sobrenome}");
Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");