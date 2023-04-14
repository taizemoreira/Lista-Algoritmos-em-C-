////Faça um programa que:
//-Leia a cotação do dólar
//- Leia um valor em dólares
//- Converta esse valor para Real
//- Mostre o resultado
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class LerCotacaoDolar
    {
        static void Main(string[] args)
        {
            // personaliza o cabeçalho do console
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("**********************************");
            Console.WriteLine("****    COTAÇÃO DO DÓLAR    ******");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            // Leia a cotação do dólar
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Informe a cotação do dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em dólares:");
            double valorEmDolar = double.Parse(Console.ReadLine());

            // personaliza o console com sons e cores
            Console.Beep(2000, 500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Realizando o cálculo...");
            Console.WriteLine();

            // Converta esse valor para Real
            double valorEmReais = (valorEmDolar * cotacaoDolar);

            //Mostre o resultado
            Console.WriteLine("**********************************");
            Console.WriteLine("**** RESULTADO DO CÁLCULO ********");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            Console.WriteLine("O valor em reais é: " + valorEmReais);
           
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione qualquer tecla para encerrar o programa...");

            // espera que o usuário pressione uma tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}