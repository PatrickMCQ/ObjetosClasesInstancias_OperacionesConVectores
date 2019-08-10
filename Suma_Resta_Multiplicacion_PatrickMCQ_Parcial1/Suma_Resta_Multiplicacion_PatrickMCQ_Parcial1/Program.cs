using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_Resta_Multiplicacion_PatrickMCQ_Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new SumaVector(new List<int> { 10, 24 });
            var v2 = new SumaVector(new List<int> { 2, 4 });

            SumaVector MO = v1.Suma(v2);
            Console.WriteLine("Suma de dos Vectores: ");
            foreach(int i in MO.Componentes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            SumaVector RE = v1.Resta(v2);
            Console.WriteLine("Resta de dos Vectores: ");
            foreach (int i in RE.Componentes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            SumaVector MU = v1.Multiplicacion(v2);
            Console.WriteLine("Multiplicación de dos Vectores: ");
            foreach (int i in MU.Componentes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.ReadKey();

        }


    }
}
