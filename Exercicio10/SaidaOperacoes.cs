/**Crie um programa que solicite ao usuário dois números decimais, 
 * esses números devem ser armazenados em variáveis do tipo decimal.
 * Após isso, o sistema deve dar a saída das seguintes operações com os
 * números informados: soma, subtração, divisão e multiplicação. **/
using System;

namespace Ex_10
{
    class SaidaOperacoes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número contendo vírgula\n");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número contendo vírgula");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n************************************************************");

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double divisao = numero1 / numero2; 
            double multiplicacao = numero1 * numero2;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O resultado da soma dos dois números é:\n " + soma);
          
            Console.WriteLine("\nO resultado da subtração dos dois números é:\n" + subtracao);

            Console.WriteLine("\nO resultado da divisão dos dois números é:\n" + divisao);

            Console.WriteLine("\nO resultado da multiplicação dos dois números é:\n" + multiplicacao);
        }
    }
}
