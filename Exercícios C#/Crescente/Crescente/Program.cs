using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crescente {
    class Program {
        static void Main(string[] args) {

            int num, num1;

            Console.WriteLine("Digite dois números:");
            num = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());

            if (num > num1) {
                Console.WriteLine("DECRESCENTE!");
            }
            else if (num < num1) {
                Console.WriteLine("CRESCENTE!");
            }
            else {
                Console.WriteLine("IGUAIS!");
            }


        }
    }
}
