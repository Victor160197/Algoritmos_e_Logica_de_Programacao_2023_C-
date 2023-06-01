using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa_8 {
    class Program {
        //VETORES EM C#
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, N;
            Console.Write("Quantos números você vai digitar?");
            N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            for (i = 0; i < N; i++) {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS DIGITADOS:");
            for (i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
            
        }
    }
}
