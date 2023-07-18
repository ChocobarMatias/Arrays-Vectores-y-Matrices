using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Creacion de vector y busqueda por recorrido del maximo y minimo ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numero = 0;//variable que guarda cada numero ingresado en el vector
            int maximo;//variable del valor maximo en el vector
            int minimo;//variable del valor minimo en el vector
            int[] vector = new int[10];//creacion de vector de 10 posiciones
            maximo = int.MinValue;//variable inicializada en el menor valor posible
            minimo = int.MaxValue;//variable inicializada en el maximo valor posible
            for (int i = 0; i < vector.Length; i++)//ciclo para crear y llenar el vector con busqueda de maximo y minimo
            {
                Console.Write(" Ingrese un numero = ");
                numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                vector[i] = numero;
                if (minimo > vector[i])//condicion para probar el si valor es maximo o minimo
                {
                    minimo = vector[i];
                }

                if (maximo < vector[i])
                {
                    maximo = vector[i];
                }
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" valor maximo {maximo} y minimo {minimo}");
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
            
        }
    }
}
