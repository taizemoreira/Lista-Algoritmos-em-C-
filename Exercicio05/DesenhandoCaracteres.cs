/** Crie um programa que mostre um triangulo, e  um quadrado utilizando o caracter #. 
 * não utilizar o caracter \n.

No mesmo programa anterior, e utilizando o conceito anterior escrever C# com os mesmos caracteres.
Porem a letra C deverá ter a cor de fundo diferente do padrão e a # deverá ser diferente da padrão 
e diferente do C.
No mesmo programa anterior que solicite o nome, diga olá para o nome da pessoa em uma cor diferente de texto. 
Solicite a idade e imprima de os parabéns pela idade da pessoa mostrando a idade junto em outra cor. **/
using System;
using System.Drawing;

namespace Exercicio05
{
    class DesenhandoCaracteres
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("           #                    ###############");
            Console.WriteLine("          # #                   #             #");
            Console.WriteLine("         #   #                  #             #");
            Console.WriteLine("        #     #                 #             #");
            Console.WriteLine("       #       #                #             #");
            Console.WriteLine("      #         #               #             #");
            Console.WriteLine("     #           #              ###############");
            Console.WriteLine("    #             #");
            Console.WriteLine("   #               #");
            Console.WriteLine("  #                 #");
            Console.WriteLine(" #####################\n");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("     #######");
            Console.WriteLine("   ##########");
            Console.WriteLine("  #####    ###");
            Console.WriteLine(" #####     ###");
            Console.WriteLine(" ####");
            Console.WriteLine(" ####           # #    # #");
            Console.WriteLine(" ####          #####  #####");
            Console.WriteLine(" ####           # #    # #");
            Console.WriteLine(" ####");
            Console.WriteLine("  ####    ####");
            Console.WriteLine("   ##########");
            Console.WriteLine("    ########\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual é o seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Qual é a sua idade?");
            var idade = Console.ReadLine();
            Console.WriteLine("Parabéns! sua idade é " + idade + " anos");
        }
    }
}

