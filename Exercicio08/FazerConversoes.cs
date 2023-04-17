/* Considere as seguintes variáveis de origem:
int numeroInteiro = 10;
decimal numeroDecimal = 23.5m;
string numeroEmString = "78";
double numeroDouble = 3.71;
Utilize as variáveis acima e aplique as conversões usando o método de
conversão ideal para cada situação.*/
using System;

namespace Exercicio08
{
    class FazerConversoes
    {
        static void Main(string[] args)
        {

            int numeroInteiro = 10;
            Console.WriteLine(Convert.ToInt32(numeroInteiro));

            decimal numeroDecimal = 23.5m;
            Console.WriteLine(Convert.ToDecimal(numeroDecimal));

            string numeroEmString = "78";
            Console.WriteLine(Convert.ToString(numeroEmString));

            double numeroDouble = 3.71;
            Console.WriteLine(Convert.ToDouble(numeroDouble));
        }
    }
}
