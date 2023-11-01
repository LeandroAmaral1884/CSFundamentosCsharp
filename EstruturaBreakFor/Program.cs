Console.WriteLine("##  Estrutura braek e continue for ##");

for(; ; )
{

    Console.WriteLine("Tecle algo (X sai)");
    var opcao=Console.ReadLine();
    Console.WriteLine(opcao.ToUpper());
    if( opcao =="X" || opcao =="x")
    {
        Console.WriteLine("Acabou.....");
        break;
    }
}

for(int i = 1; i <= 10; i++)
{
    if (i == 4)
        continue;
    if (i == 7)
        continue;
    Console.WriteLine(i);
}

int n= 1;
while(n <= 10)
{
    if(n == 5)
    {
        n++;
        continue;
    }
    if (n == 8)
    {
        break;
    }
    Console.WriteLine($"n={n}");
    n++;
}


Console.WriteLine("Fim do processamento.....");
Console.ReadLine();