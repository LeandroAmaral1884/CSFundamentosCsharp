Console.WriteLine("##Struct DateTime##\n");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual.AddYears(12));

// criar data especifica usa formato:aaaa,mm,dd

DateTime dataHoje = new DateTime(2022, 08, 06);
Console.WriteLine(dataHoje);

// criar data especifica usa formato:aaaa,mm,dd

DateTime dataHoraHoje = new DateTime(2022, 08, 06, 19, 50, 55);
Console.WriteLine(dataHoraHoje);

//Extrair iinbformações da dataAtual
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

Console.WriteLine($"hoje:{dataAtual}\n");

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

//Obter o dia da semana e o ano

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadLine();
