using System;

namespace NumerosPrimosVerdadeiroOuFalso
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string left = string.Empty;
            string strNumber = string.Empty;

            do
            {
                Console.WriteLine("Digite um número!");
                strNumber = Console.ReadLine();

                short.TryParse(strNumber, out short number);

                bool primeNumber = p.IsPrimeNumber(number);

                if (primeNumber)
                {
                    Console.WriteLine("É primo!");
                }
                else
                {
                    Console.WriteLine("Não é primo!");
                }

                Console.WriteLine();

                Console.WriteLine("Deseja sair? (s/n)");
                left = Console.ReadLine();

            } while (left == "N" || left == "n");


        }


        public bool IsPrimeNumber(short number)
        {
            short count = 0;
            for(short i = 1; i <= number; i++)
            {
                float rest = number % i;
                if(rest == 0)
                {
                    count++;
                }
            }

            if(count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
