using System;
using System.Globalization;

namespace terceiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string x;
            int y;
            double z;

            /* Split utilizado para dar espaço e quebra de linha */
            string[] vet = Console.ReadLine().Split(' ');

            x = vet[0];
            y = int.Parse(vet[1]);
            /* CultureInfo.InvariantCulture uitlizado para substituir , por . */
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadLine();

        }
    }
}
