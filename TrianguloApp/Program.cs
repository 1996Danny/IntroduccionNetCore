using System;

namespace TrianguloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;

            // Mensaje para el ingreso de datos
            Console.WriteLine("Ingrese el número de pisos: ");

            // Ingreso de datos y conversión de str a int
            pisos = Convert.ToInt16(Console.ReadLine());

            int[] arreglo = new int[1];

            for (int i = 0; i < pisos; i++)
            {
                int[] pascal = new int[i + 1];

                // Espacios en blanco antes de los números
                for (int j = 0; j < pisos - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || k == i)
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }

                    Console.Write("[" + pascal[k] + "]");
                }

                arreglo = pascal;

                Console.WriteLine();
            }
        }
    }
}