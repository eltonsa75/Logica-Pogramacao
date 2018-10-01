using System;
using System.Globalization;



/* Faça um programa para ler uma quantidade indeterminada de números, contendo cada um, a idade de um indivíduo. O último
 * dado, que não entrará nos cálculos, contém um valor de idade negativa. calcular e imprimir a idade média deste grupo de
 * indivíduos com duas casas decimais. Se for lido um valor negativo já na primeira vez, mostrar a mensagem "IMPOSSIVEL CALCULAR".
 */
namespace quinto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }

            if(cont == 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                    media = (double)soma / cont;
                    Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
                }
            Console.ReadLine();
        }
    }
}
