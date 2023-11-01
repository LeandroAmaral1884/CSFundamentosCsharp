Console.WriteLine("##@ Operador Uniário e Ternário");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);


Console.WriteLine("Informe numero:\n");
var n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("Informe temperatura:\n");
var temp=Convert.ToDouble(Console.ReadLine());

var resultado1=temp>27?"Quente":"Normal";
Console.WriteLine($"Tempera está {resultado1}");

Console.WriteLine("Informe valor X\n");
var x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe valor Y\n");
var Y = Convert.ToInt32(Console.ReadLine());

var resultado2 = x > Y ? "X maior que y" :
    x < Y ? "X menor que y" :
    x == Y ? " X igual que y" : "Sem resultado";
Console.WriteLine(resultado2);
    

Console.ReadLine();
