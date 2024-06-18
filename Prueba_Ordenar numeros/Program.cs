using System;

class Program
{
    static void Main()
    {
        // arreglo  para almacenar los números ingresados
        int[] numeros = new int[10];

       
        Console.WriteLine("Ingrese 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        // Mostramos los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");

        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

