using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Calculo de la suma de 2 matriz y muestra por pantalla la nueva matriz +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[,] matrizSuma = new int[3,3];//inicializo matriz suma donde se guardara el resultado de la suma de A con B
            int[,] matrizA = { { 14, 42, 32 }, { 22, 35, 48 }, { 39, 60, 97 } };
            int[,] matrizB = { { 32, 65, 19 }, { 12, 48, 72 }, { 23, 56, 80 } };
            Console.WriteLine();//muestro el nombre la matriz A
            Console.WriteLine("*******************");
            Console.WriteLine("    matrizA ");
            Console.WriteLine("________________");
            for (int f = 0; f < matrizA.GetLength(0); f++)//ciclo para mostrar la matriz A
            {
                Console.WriteLine();
                for (int c = 0; c < matrizA.GetLength(1); c++)
                {
                    Console.Write("   "+matrizA[f,c]+" ");//muestro por pantalla la matrizA
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("        +   ");
            Console.WriteLine("*******************");
            Console.WriteLine("    matrizB ");
            Console.WriteLine("________________");
            for (int f = 0; f < matrizB.GetLength(0); f++)
            {
                Console.WriteLine();
                for (int c = 0; c < matrizB.GetLength(1); c++)
                {
                    Console.Write("   " + matrizB[f, c] + " ");//muestro por pantalla la matriz B
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("    Matriz Suma ");
            Console.WriteLine("___________________");
            for (int f = 0; f < matrizSuma.GetLength(0); f++)
            {
                Console.WriteLine();
                for (int c = 0; c < matrizSuma.GetLength(1); c++)
                {
                    matrizSuma[f,c] = matrizA[f,c] + matrizB[f,c];//variable que asigno el valor de la suma de cada elemento
                    Console.Write("   " + matrizSuma[f, c] + " ");//muestro por pantalla la matriz suma resultante
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso ");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
