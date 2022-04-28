using System;

namespace Poupanca
{
    
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculando rendimentos da Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            //rendimento mensal 0,36% = 0.0036

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido + " reais.");

                contadorMes++;
            }
            
            Console.ReadLine();
        }
    }
}
