Console.WriteLine("## Estrutura de repetição ##\n");

int i = 1;

repetir:
Console.WriteLine($"i={i}");

i++;
if (i <= 10)
    goto repetir;
Console.WriteLine("Fim do processamento");



Console.ReadLine();