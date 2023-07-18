using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" creacion de vector notas 6 elementos calculo de promedio y promocion ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] notas = new int[6];//creacion de vector
            int nota = 0;//nota del alumno
            int suma = 0;//acumulador
            int promedio = 0;//promedio de las notas ingresadas
            for (int i = 0; i < notas.Length; i++)//ciclo para el ingreso de las notas y incremento del acumulador suma
            {
                Console.Write($". Ingresar la {i+1}° nota del alumno = ");
                nota = Int32.Parse(Console.ReadLine());
                suma = suma + nota;//acumulador
                Console.WriteLine();
            }
            Console.ReadKey();//espera de opcion de tecclado para continuar
            Console.Clear();//limpieza de pantalla
            Console.WriteLine();
            promedio = suma / (notas.Length);//calculo del promedio acumulador suma sobre longitud del vector
            Console.WriteLine();
            Console.WriteLine($" EL promedio de las notas del alumno es : {promedio}");//muestra del promedio en pantalla

            if (promedio >= 7)//condicion if para verificar la promocion
            {
                Console.WriteLine();
                Console.WriteLine("  Promociono la materia");
            }
            else
            {
                if (promedio == 6)//condicion para verificar regularizacion
                {
                    Console.WriteLine();
                    Console.WriteLine("  Quedo regular en la materia");
                }
                else
                {//muestra por pantalla si desaprobo la materia cuando nos e cumple las otras dos opciones
                    Console.WriteLine();
                    Console.WriteLine("  Desaprobo la materia");
                }
            }
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
