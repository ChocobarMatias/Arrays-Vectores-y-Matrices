using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Suma de los elemento de una matriz  ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int suma = 0;//acumulador
            int[,] numeros = { { 2, 4, 6 }, { 10, 3, 9 }, { 4, 5, 1 } };
            for (int f = 0; f < numeros.GetLength(0); f++)//for de la filas 
            {
                Console.WriteLine();
                for (int c = 0; c < numeros.GetLength(1); c++)//for de la columnas
                {
                   Console.Write("  "+numeros[f, c]+"  ");//muestra la matriz inicial
                    suma = suma + numeros[f, c];// suma de los elementos de una matriz guardadas en acumulador
                 }
             }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();//muestra por panatalla el mensaje de la sumas de tormenta
            Console.WriteLine(" Suma de todos los elementos de la matriz = " + suma);
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
