Console.WriteLine("Operadores Aritméticos##\n");
Console.WriteLine("Informe valor de x:");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

/*Console.WriteLine($"soma x+y = {x+y}");
Console.WriteLine($"subtração x-y = {x-y}");
Console.WriteLine($"multiplicação x*y = {x*y}");
double divisao =(double) x / y;
Console.WriteLine($"divisão x/y = {divisao}");
Console.WriteLine($"módulo x%y = {x%y}");
*/
Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x) }");
Console.WriteLine($"\nPotência de x elevado y = {Math.Pow(x,y) }");
Console.WriteLine($"\nValor minimo de x e y = {Math.Min(x,y) }");
Console.WriteLine($"\nValor maximo de x e y = {Math.Max(x,y) }");
Console.WriteLine($"\nConseno de x = {Math.Cos(x) }");
Console.WriteLine($"\nSeno de x = {Math.Sin(x) }");
Console.WriteLine($"\nExponencial de x = {Math.Exp(x) }");



Console.ReadLine();
