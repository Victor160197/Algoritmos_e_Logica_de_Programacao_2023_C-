using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa_7 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double c, f;
            char resp;

            do {

                Console.Write("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine());
                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CI));
                Console.Write("Deseja repitir? ");
                resp = char.Parse(Console.ReadLine());


            } while( resp == 's' );

        }
    }
}
