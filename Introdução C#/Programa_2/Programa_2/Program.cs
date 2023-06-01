using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa_2 {
    class Program {
        static void Main(string[] args) {
            //PROCESSAMENTO DE DADOS / CASTING EM C# 
            int x, y;
            x = 5;
            y = x * 2;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("1°");

            CultureInfo CI = CultureInfo.InvariantCulture;
            int x1, y1;
            x1 = 5;
            y1 = x1 * 2;
            Console.WriteLine(x1);
            Console.WriteLine(y1.ToString("F1", CI));

            Console.WriteLine("2°");

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2 * h;
            Console.WriteLine(area);

            Console.WriteLine("3°");

            int a, b, resultado;
            a = 2;
            b = 5;
            resultado = b / 2;
            Console.WriteLine(resultado);

        }
    }
}
