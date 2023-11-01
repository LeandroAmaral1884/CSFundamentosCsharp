Console.WriteLine("##Instrução If,IfeElse##\n");

Console.WriteLine("Cliente Especial 1 (S/N)");

var resposta = Console.ReadLine();

if (resposta == "s")
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Cliente Especial 2 (true/false)");

var resposta2 = Convert.ToBoolean(Console.ReadLine());

if (resposta2)
{
    Console.WriteLine("Desconto de 10%\n");
}
bool crienteEspecial = false;
Console.WriteLine("Cliente Especial 3 (S/N)\t");

var resposta3 = Console.ReadLine();

if (resposta3 == "s")
{
    crienteEspecial = true;
}
if (crienteEspecial)
{
    Console.WriteLine("Desconto de 10%\n");
}

Console.WriteLine("##Instrução If,IfeElse##\n");

Console.WriteLine("Informe numero X:\t");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe numero y:\t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"X maior {x}");
}
if(x < y)
{
    Console.WriteLine($"Y maior {y}");
}
if(x == y)
{
    Console.WriteLine($"X e Y são iguais {y} e {x}\n\n");
}
Console.WriteLine("Iinforme  a nota:\t");
int nota=Convert.ToInt32(Console.ReadLine());

if (nota >7)
{
    Console.WriteLine("Aluno aprovado");
}
else
{ Console.WriteLine("Aluno reprovado\n"); }

Console.WriteLine("## Instrução If,If eElse if ##\n");

Console.WriteLine("Informe numero A:\t");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe numero B:\t");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"X maior {a}");
}
else {
    if (a < b)
    {
        Console.WriteLine($"Y maior {b}");
    }
    else

    {
        Console.WriteLine($"X e Y são iguais {a} e {b}\n\n");
    }
}


Console.WriteLine("Fim do processamento");

Console.ReadLine();
