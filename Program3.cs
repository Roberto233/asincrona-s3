
string[] a = { "Perro", "Casa", "Cebra", "Tortuga",
"Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

Console.WriteLine("");
Console.WriteLine("---------------------------------");
Console.WriteLine("Arreglo con posicion inicializada");
Console.WriteLine("---------------------------------");
Console.WriteLine("");

foreach (var i in a)
    Console.WriteLine(i);

Console.WriteLine("");
Console.WriteLine("----------------");
Console.WriteLine("Arreglo ordenado");
Console.WriteLine("----------------");
Console.WriteLine("");

System.Array.Sort(a, 0, a.Length);
foreach (var j in a)
    Console.WriteLine(j);

Console.ReadLine();

//Jose Roberto Orellana Rodriguez