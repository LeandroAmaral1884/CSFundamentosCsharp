Console.WriteLine("## Estrutura de repetição While ##\n");

int i = 1;
while (i <= 10)
{
    Console.WriteLine($"i={i}");
    i++;
}
Console.WriteLine("Fim do Processamento...");
int e = 10;
while (e > 0)
{
    Console.WriteLine($"e={e}");
    e--;
}
Console.WriteLine("Fim do Processamento...");


int numero;
int contador = 1;

Console.WriteLine("\n Digite numero maior que 1:\t");
numero=Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    //loop while
    Console.WriteLine($"\n## Tabuada do {numero} ##");

    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero*contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\n Numero maior que 1");
}
Console.WriteLine("Fim do processamento");
Console.ReadLine();