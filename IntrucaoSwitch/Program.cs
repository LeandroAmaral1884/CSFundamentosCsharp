using System.Runtime.CompilerServices;

Console.WriteLine("##Intrução Switch##\n");

Console.WriteLine(" Informe valor da Compra:\t");
var compra = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("INforme o numero de parcelas (1 á 3): \t");
var numeroParcela = Convert.ToInt32(Console.ReadLine());

switch (numeroParcela)
{
    case 1:
        Console.WriteLine($"\n Prestação R$ :{compra / numeroParcela}");
        break;


    case 2:
        Console.WriteLine($"\n Prestação R$ :{compra / numeroParcela}");
        break;

    case 3:
        Console.WriteLine($"\n Prestação R$ :{compra / numeroParcela}");
        break;
}
Console.WriteLine("Fim do processamento.\n");

Console.WriteLine("Informe um número inteiro:\t");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine($" Número {numero} é par");
        break;


    case 1:
        Console.WriteLine($" Número {numero} é impar");
        break;




}
Console.WriteLine("Fim do processamento.\n");

Console.WriteLine("Informe o mês:\t");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":

        Console.WriteLine("Este mês 31 dias.");

        break;
    case "fevereiro":
        Console.WriteLine("Este mês 28 e 29 dias.");
        break;

    default:
        Console.WriteLine("Este mês 30 dias.");

        break;
}
Console.WriteLine("##Intrução Switch alinhada ##\n");

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é Gerente(1) ou Programador(2)?\n");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junior (1) ou Senior(2)?\t");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{

    case 1:
        Console.WriteLine("\n Bem vindo Gerente");
        break;

    case 2:
        Console.WriteLine("\n Bem vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\n Você é Junior");
                break;

            case 2:
                Console.WriteLine("Você é Senior");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        }


        break;

    default:
        Console.WriteLine("Não consigo indentificar");

        break;
}
Console.WriteLine("Fim do processamento.\n");
Console.ReadLine();
