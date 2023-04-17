/** Crie um programa que leia um número inteiro e utilize os operadores reduzidos para a calculadora
 * sendo soma, multiplicação, divisão e subtração dele mesmos com 2.**/
using System;

namespace Ex_15
{
    class CalculadoraDecremento
    {
        static void Main(string[] args)
        {
            int numero;
            int i = 2;

            int soma = ((numero + numero) + i);
            int subtracao = ((numero - numero) - i);
            int divisao = ((numero / numero) / i);
            int multiplicacao = ((numero * numero) * 2);

            Console.WriteLine("Digite um número maior que zero: \n");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n- - - - - - - - - - - - - - - -  - -  - - - - - - - - - - -\n ");


            Console.WriteLine("O resultado da soma dos dois números é:\n " + soma);

            Console.WriteLine("\nO resultado da subtração dos dois números é:\n" + subtracao);

            Console.WriteLine("\nO resultado da divisão dos dois números é:\n" + divisao);

            Console.WriteLine("\nO resultado da multiplicação dos dois números é:\n" + multiplicacao);

            Console.WriteLine("\n- - - - - - - - - - - - - - - -  - -  - - - - - - - - - - - ");
        }
    }
}

        