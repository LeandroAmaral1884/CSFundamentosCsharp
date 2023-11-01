Console.WriteLine("## Precedencia de Operadores##");

int x = 10 - 2 * 3;
int y=(10 - 2) * 3;
Console.WriteLine(x);
Console.WriteLine(y);

bool b = !(9 != 8) && 5 >= 7 || 8 >=6;
Console.WriteLine(b);
bool c = !(9 != 8) && (5 >= 7 || 8 >=6);

int t = 5, g = 6, p = 4;
int r = --t * g - ++p;

Console.WriteLine(c);
Console.WriteLine(r);

Console.ReadLine();
