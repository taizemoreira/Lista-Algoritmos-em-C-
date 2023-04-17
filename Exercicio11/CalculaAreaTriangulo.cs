/** Crie um programa que calcule a área de um triângulo equilátero. 
 * A medida dos lados deve ser informada pelo usuário. **/
using System;

namespace Ex_11
{
    class CalculaAreaTriangulo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a medida dos lados do triângulo equilátero: ");
            float ladosTriangulo = Convert.ToInt32(Console.ReadLine());

            float area = (ladosTriangulo) / 3;


            Console.WriteLine("\na área do triângulo é: " + area + "cm");
   
        }
    }
}