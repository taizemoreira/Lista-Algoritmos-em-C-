//1) Faça um programa para calcular o estoque médio de uma peça, sendo que:
//ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class CalcularEstoque
    {
        static void Main(string[] args)
        {
            // personaliza o cabeçalho do console
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("**********************************");
            Console.WriteLine("**** CALCULADORA DE ESTOQUE ******");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            // solicita ao usuário que informe a quantidade mínima e a quantidade máxima
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite a quantidade mínima: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima:");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            // personaliza o console com sons e cores
            Console.Beep(2000, 500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Realizando o cálculo...");
            Console.WriteLine();

            // calcula o estoque médio
            double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;

            // personaliza o console com mais cores e efeitos
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**********************************");
            Console.WriteLine("**** RESULTADO DO CÁLCULO ********");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            Console.WriteLine("A quantidade mínima informada foi: " + quantidadeMinima);
            Console.WriteLine("A quantidade máxima informada foi: " + quantidadeMaxima);
            Console.WriteLine();
            Console.Write("O estoque médio é: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(estoqueMedio);
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