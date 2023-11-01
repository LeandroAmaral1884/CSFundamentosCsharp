Console.WriteLine("##Operadores Logicos##");

bool c1 = 5 > 7;
bool c2 = 9 != 8;
bool resultado;
Console.WriteLine(c1);
Console.WriteLine(c2);
resultado = c1 && c2;
Console.WriteLine("Opradores AND(&&):" + resultado);
resultado = c1 || c2;
Console.WriteLine("Opradores OR(||):" + resultado);
resultado = ! c2;
Console.WriteLine("Opradores NOT(!):" + resultado);

Console.ReadLine();
