Console.WriteLine("Sáida de dados : Formatação");

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

//escrever nome na mesma linha "Maria tem 25 anos"
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();

Console.WriteLine("---------------concatenação-------------------------");

// usando a concatenação : Usando o operador +

Console.WriteLine(nome + " tem "+ idade+" anos.");
Console.WriteLine("---------------interpolação-------------------------");
// usando a interpolação de strings : $-> a interpolação

Console.WriteLine($"{nome} tem {idade} anos->. ");

// usar holders: usa {} com numeração com inicio em zero
Console.WriteLine("---------------place holders-------------------------");
Console.WriteLine("{0} tem {1} anos....",nome,idade);



Console.ReadLine();
