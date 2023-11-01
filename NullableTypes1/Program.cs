Console.WriteLine("##Nullable Types!##\n");

int? i = null;
double? d = null;
bool? b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);
///tem converter todos ?? nullble Types
int? x = null;
int r = x ?? 0;

Console.WriteLine(r);
///tem declarar todos ? nullble Types
int? e = 4;
int? p = 3;
int? n = e*p;

Console.WriteLine(n);

int? t = 100;
int? k = null;

if(t.HasValue)
{

    Console.WriteLine($"b = {t.Value}");
}
else
    Console.WriteLine(" B não possui valor(null)");
if (k.HasValue)
{

    Console.WriteLine($"b = {k.Value}");
}
else
    Console.WriteLine("K não possui valor(null)");
Console.ReadLine();


