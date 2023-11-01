Console.WriteLine("##-------------- Conversão de tipos 2 ToString ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1=valorInt.ToString();
string s2=valorDouble.ToString();
string s3=valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


Console.WriteLine("------------## Conversão de tipos 2 Convert ##\n");

int valorInt1 = 10;
double valorDouble1 = 5.35;
bool valorBoolean1 = true;

Console.WriteLine(Convert.ToString(valorInt1));
Console.WriteLine(Convert.ToDouble(valorInt1));
Console.WriteLine(Convert.ToString(valorBoolean1));
Console.WriteLine(Convert.ToUInt32(valorDouble1));

Console.WriteLine("------------## Conversão de tipos 2 Convert Overflow Exception  ##\n");

/*int varInt2 = 100000;
Console.WriteLine(Convert.ToByte(varInt2));*/

Console.ReadLine();
