using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5 {
    class Program {
        //ESTRUTURA ENQUANTO EM C#
        static void Main(string[] args) {

            int x, soma;

            soma = 0;
            Console.Write("Digite o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            while ( x != 0 ) {
                soma += x;
                Console.Write("Digite outro numero: ");
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("SOMA = " + soma);

        }
    }
}
