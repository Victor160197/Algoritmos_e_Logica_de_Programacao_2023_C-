using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_negativos {
    class Program {
        static void Main(string[] args) {
            int ordem, negativos;
            Console.Write("Qual a ordem da matriz? ");
            ordem = int.Parse(Console.ReadLine());
            negativos = 0;

            int[,] mat = new int[ordem, ordem];
            int[] principal = new int[ordem];

            for (int i = 0; i < ordem; i++) {
                for (int j = 0; j < ordem; j++) {
                    Console.Write("Elemento["+i+","+j+"]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                    if (i == j) {
                        principal[i] = mat[i, j];
                    }
                    if (mat[i, j] < 0) {
                        negativos += 1;
                    }
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < ordem; i++) {
                Console.Write(principal[i] + " ");
            }
            Console.WriteLine();
            Console.Write("QUANTIDADE DE NEGATIVOS = " + negativos);

        }
    }
}
