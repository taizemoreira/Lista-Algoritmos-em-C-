/** Crie um programa que leia um número inteiro,
 * calcule o dobro do número e eleve ao quadrado por ultimo some 1 com incremento. **/

using System;

namespace Ex_10
{
    class LerNumeroInteiro
    {
        static void Main(string[] args)
        {
            int numero;
            int i = 1;

            Console.WriteLine("Digite um número maior que zero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O resultado da operação é: {(((2 * numero) * 2) + i)}");
        }
    }
}