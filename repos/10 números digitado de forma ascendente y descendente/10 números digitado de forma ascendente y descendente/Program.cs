using System;

class ProgramaOrdenamiento
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Ingrese 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Orden ascendente
        Array.Sort(numeros);
        Console.WriteLine("\nNúmeros en orden ascendente:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        // Orden descendente
        Array.Reverse(numeros);
        Console.WriteLine("\n\nNúmeros en orden descendente:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
