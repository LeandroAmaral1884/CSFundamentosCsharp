Console.WriteLine("## Operadores relacionais##");

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de x {y}");

Console.WriteLine(x==y);
bool resultado = x == y;
Console.WriteLine(resultado);
Console.WriteLine("---------");
Console.WriteLine(x == y);
Console.WriteLine(x>y);
Console.WriteLine(x<y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x !=y);

Console.WriteLine("---------");
string a = "Curso";
string b= "curso";


Console.WriteLine($"Valor de a {a}");
Console.WriteLine($"Valor de b {b}");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));
Console.ReadLine();