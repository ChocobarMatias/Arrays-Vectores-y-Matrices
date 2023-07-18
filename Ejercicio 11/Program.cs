using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Busqueda de nombres en una matriz +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            string[,] Frutas = { { "manzana", "pera", "uva" }, { "naranja", "pera", "kiwi" }, { "mango", "pera", "limon" } };
            bool bandera = false;//bandera para la busqueda en la matriz
            string nombre = "";//variable contenedora de string
            Console.Write(" Ingresar el nombre que busca = ");//mensaje que muestra por pantalla pedido de ingreso
            nombre = Console.ReadLine();//ingreso del string
            Console.WriteLine("");
            Console.WriteLine("     Matriz Frutas ");//mensaje con el nombre de la matriz
            Console.WriteLine("________________________");
            Console.WriteLine();
            for (int f = 0; f < Frutas.GetLength(0); f++)//ciclo con el que recorro la matriz
            {//recorrido por filas
                Console.WriteLine();
                for (int c = 0; c < Frutas.GetLength(1); c++)
                {//recorrido por columnas
                       Console.Write($"  {Frutas[f,c]}  ");//muestro la matriz
                    if (nombre == Frutas[f, c])//condicion para la busqueda del nombre
                    {
                        bandera = true;//cuando encuntra el nombre cambia a true la bandera
                    }
                    
                }
                }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

                if (bandera)//cuando es true la bandera 
                {
                    Console.WriteLine(" El nombre buscado SI esta en la matriz");//muestra por pantalla del resultado busqueda
                }                                                               //es positiva
                else
                {
                    Console.WriteLine(" El nombre buscado NO esta en la matriz");//muestra por pantalla resultado de la buqueda
                }                                                               //es negativa
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
