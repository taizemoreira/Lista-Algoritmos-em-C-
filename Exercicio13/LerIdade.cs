/** Crie um programa que leia a idade de uma pessoa e deverá ser exibido na tela,
 * se esta pessoa é maior de idade (considerar 18 anos para maior idade). 
Saída:
Maior de idade: false
**/
using System;

namespace Ex_13
{
    class LerIdade
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}
