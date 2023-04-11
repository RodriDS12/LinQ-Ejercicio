using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var valoresLQ = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sumaLQ = valoresLQ.Sum();
            Console.WriteLine(sumaLQ);

            var valoresLQ2 = new List<int> {1,2,3,4,5,6,7,8,9};
            var valoresParesLQ2 = valoresLQ2.Where(valor => valor % 2 == 0).ToList();
            var sumaLQ2 = valoresParesLQ2.Sum();
            Console.WriteLine(sumaLQ2);

            var valoresLQ3 = new List<int>() { 3, 6, 9, 7, 4, 1, 2, 5, 8 };
            var valoresOrdeandos = valoresLQ3.OrderByDescending(x => x);

            foreach (var valorOrdenado in valoresOrdeandos)
            {

                Console.WriteLine(valorOrdenado);

            }

            Console.WriteLine("");

            var valoresLQ4 = new List<int>() { 3,6,9,7,4,1,2,5,8 };
            var valoresOrdenado2 = valoresLQ4.OrderBy(x => x);

            foreach (var valorOrdenado in valoresOrdeandos)
            {
                Console.Write(valorOrdenado);

            }

            Console.WriteLine("");

        }
    }
}
