using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa_1 {
    class Program {
        static void Main(string[] args) {
            //SAÍDA DE DADOS EM C#
            Console.Write("Bom dia");
            Console.Write("Boa Noite");

            Console.WriteLine(" ");
            Console.WriteLine("1°");

            Console.WriteLine("Bom Dia");
            Console.WriteLine("Bom Noite");

            Console.WriteLine("2°");

            int x, y;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("3°");

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade;
            double altura;
            double salario;
            string nome;
            string profissao;
            char sexo;
            

            idade = 26;
            altura = 1.75;
            salario = 3000.00;
            nome = "José Victor";
            profissao = "Programador";
            sexo = 'M';

            Console.WriteLine("O funcionario "+ nome +" tem "+idade+"anos é do sexo "+sexo+
            " e altura "+ altura.ToString("F2", CI) +" trabalha como "+profissao+
            ", e ganha R$"+salario.ToString("F2", CI));



        }
    }
}
