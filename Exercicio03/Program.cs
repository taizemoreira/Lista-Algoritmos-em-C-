//// 3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
//comissão será de 5% do total da venda e que você tem os seguintes dados:
//-Identificação do vendedor
//- Código da peça
//- Preço unitário da peça
//- Quantidade vendida 
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine("**********************************");
            Console.WriteLine("****  PAGAMENTO DE COMISSÃO   ****");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Informe a identificação do vendedor: ");
            string nomeVendedor = Console.ReadLine();

            Console.WriteLine("Informe o código da peça:");
            double codigoPeca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o preço unitário da peça:");
            double precoUnitarioPeca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade vendida:");
            double qtdeVendida = Convert.ToDouble(Console.ReadLine());

            // personaliza o console com sons e cores
            Console.Beep(2000, 500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Realizando o cálculo...");
            Console.WriteLine();

            // Calculando a comissão
            double totalVenda = precoUnitarioPeca * qtdeVendida;

            double comissaoVendedor = (totalVenda * 0.05);

            //Mostre o resultado
            Console.WriteLine("1. Identificação do vendedor: " + nomeVendedor);
            Console.WriteLine("2. Código da peça: " + codigoPeca);
            Console.WriteLine("3. Preço unitário da peça: " + precoUnitarioPeca);
            Console.WriteLine("4. Quantidade de peças vendidas: " + qtdeVendida);
            Console.WriteLine("5. O valor total da venda será de R$: " + totalVenda + " reais");

            Console.WriteLine();

            Console.WriteLine("COMISSÃO DO VENDEDOR: " + comissaoVendedor + " reais");

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