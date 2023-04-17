/** Crie um programa que solicite ao usuário o comprimento em cm dos três lados de um triângulo 
 * e após isso indique se o triângulo é do tipo: equilátero, escaleno ou isósceles 
Saída...
Equilátero: false
Escaleno: true
Isósceles: false **/
using System;

namespace Ex_12
{
    class VerificarLadosTriangulo
    {
        static void Main(string[] args)
        {
            bool saida;

            Console.WriteLine("Informe o valor do Primeiro lado: ");
            float a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do Segundo lado: ");
            float b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do Terceiro lado: ");
            float c = Convert.ToInt32(Console.ReadLine());


            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                Console.WriteLine("Não é um triângulo");
            }
            else if ((a == b) & (a == c))
            {
                //Equilátero: false
                saida = false;
                Console.WriteLine("Equilatero ", saida);
            }
            else if ((a == b) || (a == c) || (b == c))
            {
                //Isósceles: false
                saida = false;
                Console.WriteLine("Isósceles ", saida);
            }
            else
            {
                //Escaleno: true
                saida = true;
                Console.WriteLine("Escaleno ", saida);
            }
        }
    }
}
