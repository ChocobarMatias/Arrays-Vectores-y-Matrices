using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Suma total de la fila 2 de la matriz y resta total de la columna numero 3 +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int resta = 0;//acumulador de la resta para columna 3
            int suma = 0;//acumuador para la suma de la fila 2
            int[,] vector = { { 1, 2, 3, 4 }, { 5, 1, 0, 6 }, { 7, 8, 4, 2 }, { 4, 6, 9, 3 } };
            Console.WriteLine("       Matiz Vector 4x4 ");//mensaje muestra en pantalla nombre de la matriz
            Console.WriteLine("------------------------------");//muestra en pantalla lineas
            for (int f = 0; f < vector.GetLength(0); f++)//ciclo para el recorrido de la matriz por fila
            {
                Console.WriteLine();
                for (int c = 0; c < vector.GetLength(1); c++)//ciclo que recorre la matriz por columnas
                {
                    if (c == 2)//condicion para sumar fila 2
                    {
                        resta -= vector[f, c];
                    }
                      if (f == 1)//condicion para restar la columna 3
                      {
                    suma = suma + vector[f, c]; 
                      }
                    Console.Write($"   {vector[f,c]} ");//muestra la matriz por pantalla
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.ReadKey();//espera con una tecla continuar
            Console.Clear();//borra pantalla
            Console.WriteLine();//muestra por pantalla la suma de la fila 2
            Console.WriteLine(" Suma total de la fila 2 =  " + suma);
            Console.WriteLine();//muestra por pantalla la resta de la columna 3
            Console.WriteLine(" Resta total de la columna 3 = " + resta);
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
