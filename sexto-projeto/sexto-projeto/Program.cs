using System;
using System.Globalization;

/* Ler um número inteiro V e depois ler N pares de números com ponto flutuante com uma casa decimal.
 * Para cda par de número lido, mostrar o resultado da divisão do primeiro pelo segundo, com três
 * casas decimais. Se a divisão não for possível, exibir uma mensagem "não existe"
 */

namespace sexto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double x, y, resultado;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                if (y == 0)
                {
                    Console.WriteLine("não existe");
                }
                else
                {
                    resultado = x / y;
                    Console.WriteLine(resultado.ToString("f3", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
