using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6 {
    //ESTRUTURA PARA EM C#
    class Program {
        static void Main(string[] args) {
            int n, i, x, soma;
            soma = 0;

            Console.Write("Quantos números serão digitados? ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                Console.Write("Digite um número: ");
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine("Soma = " + soma);

        }
    }
}
