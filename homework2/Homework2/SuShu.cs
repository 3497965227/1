using System;
using System.Collections.Generic;

namespace Homework2
{

    public class SuShu
    {

        public static void Main(string[] args)
        {
           
                Console.Write("请输入一个整数:");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factorize(num);
                Console.Write("素因子有:");
                factors.ForEach(f => Console.Write("\t" + f));

         
        }
        
        private static List<int> Factorize(int num)
        {
            if (num <= 1) ;

            List<int> factors = new List<int>();
            
            for (int factor = 2; factor * factor <= num; factor++)
            {
                while (num % factor == 0)
                { 
                    factors.Add(factor);
                    num = num / factor;
                }
            }
            if (num != 1) factors.Add(num);

            return factors;
        }
    }
}
