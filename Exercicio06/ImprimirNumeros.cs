/* Crie um programa que imprima os números de 01 até 10, importante ter os zeros a esquerdas.
 *  Porem só deverá imprimir o próximo número quando o usuário pressionar qualquer tecla.*/
using System;

namespace Exercicio06
{
    class ImprimirNumeros
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("==============================================");
            Console.WriteLine("Seguiremos uma sequência numérica de 1 a 10. " +
                "\nPressione a tecla enter para prosseguir: ");
            Console.WriteLine("==============================================");
            Console.ReadLine();
            Console.WriteLine("01");
            Console.ReadLine();
            Console.WriteLine("Pressione a tecla enter para prosseguir para o próximo número:");
            Console.ReadLine();
            Console.WriteLine("02");
            Console.ReadLine();
            Console.WriteLine("03");
            Console.ReadLine();
            Console.WriteLine("04");
            Console.ReadLine();
            Console.WriteLine("05");
            Console.ReadLine();
            Console.WriteLine("06");
            Console.ReadLine();
            Console.WriteLine("07");
            Console.ReadLine();
            Console.WriteLine("08");
            Console.ReadLine();
            Console.WriteLine("09");
            Console.ReadLine();
            Console.WriteLine("10");
            Console.WriteLine("Você chegou ao final do programa!");
        }
    }
}
