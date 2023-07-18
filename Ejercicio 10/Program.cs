using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Producto de 2 Matrices y muestra en pantalla la nueva matriz producto +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[,] matrizProducto = new int[3, 3];//matriz resultante del producto de AxB
            int suma = 0;//acumulador de la suma de los productos de las matrices
            int b = 0;//contador para reiniciar suma
            int[,] matrizA = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            int[,] matrizB = { { 3, 6, 9 }, { 1, 4, 7 }, { 2, 5, 8 } };
            Console.WriteLine();//muestro el nombre la matriz A
            Console.WriteLine("*******************");
            Console.WriteLine("    matrizA ");
            Console.WriteLine("________________");
            for (int f = 0; f < matrizA.GetLength(0); f++)//ciclo que muestra la matriz A
            {
                Console.WriteLine();
                for (int c = 0; c < matrizA.GetLength(1); c++)
                {
                    Console.Write("   " + matrizA[f, c] + " ");//muestra por pantalla los elementos de la matriz
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("        x   ");
            Console.WriteLine("*******************");
            Console.WriteLine("    matrizB ");
            Console.WriteLine("________________");
            for (int f = 0; f < matrizB.GetLength(0); f++)//ciclo que muestra la matriz B
            {
                Console.WriteLine();
                for (int c = 0; c < matrizB.GetLength(1); c++)
                {
                    Console.Write("   " + matrizB[f, c] + " ");//muestra por pantalla los elementos de la matriz
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.ReadKey();//espera de teclado para continuar
            Console.Clear();//limpieza de pantalla
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("    Matriz Producto ");
            Console.WriteLine("___________________");
            for (int f = 0; f < 3; f++)//ciclo para mostrar la matriz prodructo
            {
                Console.WriteLine();
                int contador = 0;
                while (contador < 3)//condicion para inciar el producto de la matriz por medio de un contador por elemento
                {
                    for (int c = 0; c < 3;c++)
                 
                    {
                        for (int a = 0; a < 3; a++)//ciclo para calcular los elemento de la matriz producto
                        {
                            suma = suma + (matrizA[f, a] * matrizB[a, c]);//acumulador de la suma del producto de los elementos
                            b++;//contador incremento
                            if (contador < 3)//con esta condicion asigno cada elemento a la nueva matriz
                            {
                                matrizProducto[f, c] = suma;//asignacion de elementos
                             
                            }
                            
                            if (b >= 3)//condicion para reiniciar el acumulador suma y no tener elementos repetidos
                            {
                                suma = 0;
                                b = 0;//reincio del contador no tener elemento duplicados
                            }
                            
                        }

                       Console.Write("  " + matrizProducto[f, c] + " ");//muestra por pantalla de la nueva matriz
                contador++;//incremento del contador del ciclo while
                }
                    }
                 }

            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso ");
            Console.WriteLine("*****************");
            Console.ReadKey();           
        }
    }
}
