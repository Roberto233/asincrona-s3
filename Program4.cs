namespace array
{
    class programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Funcion BinarySearch");
            Console.WriteLine("--------------------");

            Console.WriteLine("");

            Console.WriteLine("Arreglo de caracteres");
            Console.WriteLine("---------------------");

            Console.WriteLine("");

            string[] a = { "Sol", "Dedo", "Casa"};

            System.Array.Sort(a);
            foreach (var p in a)
                Console.WriteLine(p);
        
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            int caracter1 = Array.BinarySearch(a, "Sol");
            int caracter2 = Array.BinarySearch(a, "Dedo");
            int caracter3 = Array.BinarySearch(a, "Casa");

            Console.WriteLine("Posicion del caracter Sol: " + caracter1);
            Console.WriteLine("Posicion del caracter Dedo: " + caracter2);
            Console.WriteLine("Posicion del caracter Casa: " + caracter3);

            Console.ReadLine();
        }
    }
}

//JOse Roberto Orellana Rodriguez
