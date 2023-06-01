using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_9 {
    class Program {
        //MATRIZES EM C# 
        static void Main(string[] args) {
            int l, c;
            Console.Write("Quantas linhas terá a matriz? ");
            l = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas terá a matriz? ");
            c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for(int i = 0; i < l; i++) {
                for(int j = 0; j < c; j++) {
                    Console.Write("Elemento["+ i +","+ j +"]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA: ");

            for(int i = 0; i < l; i++) {
                for(int j = 0; j < c; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
