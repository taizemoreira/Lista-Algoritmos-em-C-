/**Criar um programa que considere o exercício de fazer um triangulo, um quadrado e o C# com caracteres,
 * e faça cada um deles, porem com o usuário digitando o carácter desejado na criação dos mesmos: **/
using System;

namespace Ex_09
{
    public class SolicitaCaracterDesenho
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra para criar seu desenho: ");
            string letra = Console.ReadLine();
            Console.WriteLine(letra);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("           #                    ###############");
            Console.WriteLine("          ###                   ###############");
            Console.WriteLine("         #####                  ###         ###");
            Console.WriteLine("        #######                 ###         ###");
            Console.WriteLine("       #########                ###         ###");
            Console.WriteLine("      ###########               ###############");
            Console.WriteLine("     #############              ###############");
            Console.WriteLine("    ###############");
            Console.WriteLine("   #################");
            Console.WriteLine("  ###################");
            Console.WriteLine(" #####################");

            Console.WriteLine("     #######");
            Console.WriteLine("   ##########");
            Console.WriteLine("  #####    ###");
            Console.WriteLine(" #####     ###");
            Console.WriteLine(" #####");
            Console.WriteLine(" ####       # #    # #");
            Console.WriteLine(" ####      #####  #####");
            Console.WriteLine(" ####       # #    # #");
            Console.WriteLine(" ####");
            Console.WriteLine("  ####    ####");
            Console.WriteLine("   ##########");
            Console.WriteLine("    ########\n");

            
        }
    }
}