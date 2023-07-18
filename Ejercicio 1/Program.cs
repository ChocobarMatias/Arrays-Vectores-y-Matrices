using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();//Borrado inicial de pantalla
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Suma de todas la posiciones de un Vector ");//Mensaje inicial
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            int suma = 0;//Inicializaccion de la variable acumuladora
            int[] vector = { 20, 32, -10, 54, 102 };//vector                                
            Console.WriteLine();
            Console.Write(" Vector = [");//opcional que agregue para mostrar el vector
            //Ciclo for el cual realiza recorrdo por el vector por emdio de un acumulador
            for (int i = 0; i < vector.Length; i++)
            {
               suma = suma + vector[i];//acumulador de la suma 
                Console.Write($"  {vector[i]}");//muestra en pantalla el vector
            }
            Console.Write(" ]");//cierre del vector
            Console.ReadKey();//pulso de tecla para continuar
            Console.Clear();//limpieza de pantalla despues de pulsar tecla 
            Console.WriteLine();// mensaje de la suma del vector y muesta del valor por pantalla
            Console.WriteLine($" La suma de todas las posiciones del Vector es : {suma}");
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");

            Console.ReadKey();
        }
    }
}
