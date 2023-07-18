using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Resta de todas la posiciones de un vector Numeros ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            int[] numeros = { 5, 12, 8, 23, 4 };
            int resta = 0;// variable acumuladora de la resta de las posicionez del vector
            int longitud = 0;//variable la cual se usa para guardar longitud del vector
            int contador = 0;//contador para realizar comparacion de la longitud
            longitud = numeros.Length;//calculo de la longitud del vector
            Console.Write(" Numeros [");//utilizo para mostrar en pantalla el vector
            while (contador < longitud)//condicion para ingreso en el while
            {
                Console.Write(" "+numeros [contador]+" ");//mostrar en pantalla el vector numeros
                
                resta = numeros[contador] - resta;//acumulador de la resta
                contador++;//contador
            }
            Console.Write("]");//finalizacion del vector
            Console.ReadKey();//esperar como respuesta tocar una tecla para mostrar la resta 
            Console.Clear();//limpieza de la pantalla
            Console.WriteLine();
            Console.WriteLine($" La resta de las posiciones del vector = {resta}");

            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("| Fin del Proceso |");
            Console.WriteLine("*******************");

            Console.ReadKey();
        }
    }
}
