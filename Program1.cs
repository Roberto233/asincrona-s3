using System;

class Program
{
    static void Main()
    {
        int[] arreglo;
        Console.WriteLine("-------------------------------------------------");
        Console.Write("Ingrese el tamaño del arreglo (mínimo 5): ");
        int tamaño = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-------------------------------------------------");

        if (tamaño < 5)
        {
            Console.WriteLine("");
            Console.WriteLine("El tamaño no debe ser menor a 5.");
            return;
        }
        arreglo = new int[tamaño]; 
        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine("");
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Valores del arreglo:");
        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine("");
            Console.WriteLine($"Valor {i + 1}: {arreglo[i]}");
        }
        Console.WriteLine("-------------------------------------------------");
    }
}
//Jose Roberto Orellana Rodriguez.