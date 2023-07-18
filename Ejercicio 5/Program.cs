using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Busqueda de un nombre (un String) recorriendo el vector nombres ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            bool bandera = false;//bandera tipo booleana para la condicion de busqueda
            string[] nombres = { "camila", "roberto", "ricardo", "karina", "rosario", "nahuel", "carlos" };
            string nombre = "";//variable tipo string para el ingreso de los nombre o cadena
            Console.Write(" Ingresar el nombre que busca = ");//mensaje de muestra en pantalla
            nombre = Console.ReadLine();//ingreso del dato tipo string por parte del usuario
            
            for (int i = 0; i < nombres.Length; i++)//ciclo para recorrer el vecctor 
            {
                if (nombre == nombres[i])// condicion para cada elemento del vector
                {
                   bandera = true;//bandera en verdad para cada elemento 
                }
            }
            Console.WriteLine();
            Console.ReadKey();// espera del tecla para continuar
            Console.Clear();// limpieza de pantalla
            Console.WriteLine();
            if (bandera)//verifica si la bandera es true quiere decir que encontro el nombre ingresado en el vector
            {
                Console.WriteLine(" El nombre buscado SI esta en el vector");
            }
            else
            {//si no esta en el vector muestra ese mensaje por pantalla
                Console.WriteLine(" El nombre buscado NO esta en el vector");
            }

            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" Fin del proceso");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
