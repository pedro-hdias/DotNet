
using System;

namespace PrimeiroProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
            /* string fullName = "Pedro Dias";
            Console.WriteLine(fullName);
            short smallNumber = 0; // Uma variável de tipo curto, armazena até 32.76    7 ou 16 bits.
            int normalNumber = 0; // int é um tipo que armazena até 2.47.483.647 ou 32bits.
            long bigNumber = 0; // Números até 9.223.372.036.854.775.807 ou 64bits.
            decimal decimalNumber = 0.00M;
            double doubleNumber = 0; // Variável para decimais no C#.
            bool itsTrue = false; // Essa variável só aceita true ou false. */

            // Calculos aritiméticos
            int soma = 10 + 5;
            int subtracao = 15 - 5;
            int multiplicacao = 10 * 5;
            int divisao = 10 / 5;
            int resto = 10 % 3;
            double potencia = Math.Pow(10, 5);
            Console.WriteLine("As funções aritiméticas de somar, subitrair, multiplicar, dividir, resto da divisão e potenciação são, respectivamente: " + soma + ' ' + subtracao + ' ' + multiplicacao + ' ' + divisao + ' ' + resto + ' ' + potencia);

            // Estruturas de desição
            if (10 > 5)
            {
                Console.WriteLine("é ssim."); // To do
            }
            else if (10 < 11)
            {
                Console.WriteLine('<11');
            }
            else
            {
                Console.WriteLine("Não."); // to do if not work the behind.
            }

        }
    }
}