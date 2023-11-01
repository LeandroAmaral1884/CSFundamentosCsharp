Console.WriteLine("## Estrutura for ##");

int numero, resultado;

Console.WriteLine("Digite um numero inteiro para tabuada:\n");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (int x = 1; x <= 10; x++)
    {
        resultado = x * numero;
        Console.WriteLine($"{numero}x{x}={resultado}");


    }
}

else { Console.WriteLine("Numero invalido....\n"); }
Console.WriteLine("Fim do processamento.....");

Console.ReadLine();

