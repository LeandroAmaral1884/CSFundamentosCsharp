Console.WriteLine("## Conversão de tipos##\n");

int varInt = 100;              // int usa 4 bytes
double varDouble = varInt;     // double usa 8 bytes

Console.WriteLine(varDouble);

/*byte -> 1 byte
short -> 2 bytes
long -> 8 bytes
float -> 4 bytes
double -> 8 bytes
decimal -> 16 bytes*/

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble=numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
Console.WriteLine("----------------------forçando um conversão----------------");

double varDouble1 = 12.456;              // int usa 4 bytes
int varInt1 = (int)varDouble1;     // double usa 8 bytes(perda de precisão)

Console.WriteLine(varInt1);

int num1 = 10;
int num2 = 4;

float reaultado1 = num1 / num2;   //10/4=2
float reaultado2 = (float)num1 / num2;   //10/4=2.5
Console.WriteLine(reaultado1);
Console.WriteLine(reaultado2);


Console.ReadLine();