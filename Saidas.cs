using System;
using System.Globalization;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine();
            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + " cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + " cujo preço é $ " + preco2.ToString("F2") + "\n");

            Console.WriteLine("Registro: " + idade + " anos de idade, " + "código " + codigo + " e gênero: " + genero + "\n");

            Console.WriteLine("Medida com oito casas decimais: " + preco3.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais): " + preco3.ToString("F3"));
            Console.WriteLine("Separador decimal invariante culture: " + preco3.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
