using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_primer_proyecto
{
    internal class program
    {
        static void Main(string[] args)
        {
            //prioridad de los operadores aritmeticos
            //ejercicio obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9 };
            int suma = 0;
            foreach (int num in serie)
            {
                suma += num;

            }
            double prom = suma + suma / serie.Length;
            Console.WriteLine("la suma es : {0}, el promedio {1}", suma, prom);
            // pausa
            Console.ReadLine();





        }
    }
}
