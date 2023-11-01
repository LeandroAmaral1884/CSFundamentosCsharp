Console.WriteLine("\n #3Entrda de dados##");
Console.WriteLine("\n Informe o seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("\n Informe o sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

//concatenação
Console.WriteLine("Seu nome é " + nome);
Console.WriteLine("Sua idade é " + idade);

// interpolação
Console.WriteLine($"Seu nome é {nome}");
Console.WriteLine($"Seu idade é  {idade}");

Console.ReadKey();