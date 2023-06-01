using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_impares {
    class Program {
        static void Main(string[] args) {

            int x, y, troca, soma;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = 0;

            if (x > y) {
                troca = y;
                y = x;
                x = troca;
            }

            for (int i = x; i < y; i++) {
                if ( i % 2 > 0) {
                    soma += i;
                };

            }

            Console.WriteLine("SOMA DOS IMPARES = "+ soma);

        }
    }
}
