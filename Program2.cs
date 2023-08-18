using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "ROBERTO RODRIGUEZ";
        int longitud = nombre.Length;

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine();

        char[] arregloNombre = new char[longitud];

        for (int i = 0; i < longitud; i++)
        {
            arregloNombre[i] = nombre[i];
            Console.WriteLine("Valor en posición " + i + ": " + arregloNombre[i]);
        }

        Console.WriteLine("");

        Console.WriteLine("Tamaño del arreglo: " + longitud);
    }
}

//JOSE ROBERTO ORELLANA RODRIGUEZ