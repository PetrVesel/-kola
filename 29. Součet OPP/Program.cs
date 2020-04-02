using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Součet_OPP
{
    class total
    {
        private int amount;

        

        public void HowManyNumbers()
        {
            Console.Write("Kolik čísel chcete sečíst? ");
            amount = int.Parse(Console.ReadLine());
            amount = amount + 1;
        }

        int[] Nums;

        public void EnterTheNumbers()
        {
            int[] Nums = new int[amount];

            for (int i=1; i < amount; i++)
            {
                Console.Write("Zadejte {0}. číslo: ", i);
                while (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.Write("Invalid input. Try again: ");
                }
            }
            

            
        }
        int final = 0;
        public void Final()
        {
            
            

            for (int i = 1; i < amount; i++)
            {
                final = final + Nums[i];
            }

            Console.WriteLine("Součet vašich čísel je {0}", final);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            total myFirstTotal = new total();
            myFirstTotal.HowManyNumbers();
            myFirstTotal.EnterTheNumbers();
            myFirstTotal.Final();

            Console.ReadKey();
        }
    }
}
