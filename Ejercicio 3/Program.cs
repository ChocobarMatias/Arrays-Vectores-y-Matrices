using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Calculo del promedio del vector notas de un alaumno ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] notas = { 10, 6, 8, 9, 7, 10 };
            double promedio = 0;//variable para el calculo del promedio de las notas con decimales
            double suma = 0;//variable para la suma de las notas del vector
            Console.Write("Notas = [");//muestra por pantalla el inicio del vector
            for (int i = 0; i < notas.Length; i++)//ciclo para calcular el acumulador suma recorriendo el vector
            {
                suma = suma + notas[i];//acumulador de la suma de los elementos del vector
                Console.Write($" {notas [i]} ");//muestra los elementos del vector
                            }
            Console.Write("] ");//muestra el final dell vector
            Console.ReadKey();//espera de un teclado para continuar
           Console.Clear();//limpia pantalla
          promedio = suma / notas.Length;//division de la acumulador suma sobre la longitud del vector
           
         Console.WriteLine($" Promedio de notas = {promedio}");//muestra el calculo del promedio de las notas

            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.ReadKey();
        }
    }
}
