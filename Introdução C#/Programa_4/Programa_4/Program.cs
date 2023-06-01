using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_4 {
    class Program {
        static void Main(string[] args) {
            //ESTRUTURA CONDICIONAL EM C# 
            int hora;

            Console.Write("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia !");
            } else {
                Console.WriteLine("Boa Tarde!");
            };

        }
    }
}
