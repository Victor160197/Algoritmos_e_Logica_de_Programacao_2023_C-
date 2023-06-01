using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_de_tres {
    class Program {
        static void Main(string[] args) {

            int num, num1, num2, menor;

            Console.Write("Primeiro valor: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            num2 = int.Parse(Console.ReadLine());

            menor = 9999;

            if (num < menor) {
                menor = num;
            } if ( num1 < menor ) {
                menor = num1;
            } if ( num2 < menor ) {
                menor = num2;
            }

            Console.WriteLine("MENOR = " + menor);





        }
    }
}
