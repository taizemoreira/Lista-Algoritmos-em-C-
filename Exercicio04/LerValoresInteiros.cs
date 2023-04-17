//Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
//valores lidos, baseando-se na utilização do conceito de propriedade distributiva.

//Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados os valores
//de A com B, A com C e A com D; depois B com C, B com D e por último C com D.
//Note que para cada operação serão utilizadas seis combinações.
//Assim sendo,devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
//multiplicações
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class LerValoresInteiros
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