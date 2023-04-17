/* Crie um programa e após isso crie duas variáveis string recebendo o
valor 76 e 24 e entregue como saída do programa o valor 100 através de uma soma. 
A conversão da primeira variável deve ser realizada através do uso do Convert e 
a segunda através do uso do Parse.*/
using System;

namespace Exercicio03
{
    class CriandoVariaveis
    {
        static void Main(string[] args)
        {
            int numero1 = Convert.ToInt32("76"); 
            int numero2 = Int32.Parse("24");

            Console.Write("O resultado da soma 76 + 24 é: " + (76 + 24)); 
        }
    }
}
           