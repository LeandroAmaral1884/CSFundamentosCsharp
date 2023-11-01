Console.WriteLine("## Estrutura de repetição While 2 ##\n");

while(true)
{
    Console.WriteLine("\n Informe um numero inteiro:(Para sair digite 999)");
    int numero=Convert.ToInt32(Console.ReadLine());

    if(numero == 999 )
    {
        break;
    }

    if(numero%2==0)
        Console.WriteLine($"{numero} é par");
    else
        Console.WriteLine($"{numero} é impar");
}
Console.WriteLine(" Fim do Processamento...");

int x = 0;
while(x<5)
{
    int y = 0;
    {
        Console.Write($"{x},{y}");
        y++;
    }

    x++;
    Console.WriteLine();
}
Console.WriteLine("Fim do processamento....");
Console.ReadLine();
