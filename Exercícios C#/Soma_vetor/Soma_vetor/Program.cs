using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Soma_vetor {
    class Program {
        static void Main(string[] args) {

            
            int N;
            double soma, media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros você vai digitar? ");
            N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            soma = 0;

            for(int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
                soma += vet[i];
            }

            media = soma / N;

            Console.Write("VALORES = ");
            for(int i = 0; i < N; i++) {
                Console.Write(vet[i].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));


        }
    }
}
