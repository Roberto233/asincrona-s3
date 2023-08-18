
int[] c = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("----------------------------");
Console.WriteLine("Arreglo de numeros definidos");
Console.WriteLine("----------------------------");

foreach (var i in c)
    Console.WriteLine(i);

Console.WriteLine("");
Console.WriteLine("----------------------------");
Console.WriteLine("Funcion Reverse");
Console.WriteLine("----------------------------");

System.Array.Reverse(c, 0, c.Length);
foreach (var h in c)
    Console.WriteLine(h);


Console.WriteLine("");
Console.WriteLine("----------------------------");
Console.WriteLine("Funcion Sort");
Console.WriteLine("----------------------------");

System.Array.Sort(c);
foreach (var h in c)
    Console.WriteLine(h);

Console.WriteLine("----------------------------");

Console.ReadKey();


//Jose Roberto Orellana Rodriguez