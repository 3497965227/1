using System;
namespace homework1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "";
            string o = "";
            int n = 0;
            int d = 0;
            int t = 0;
            Console.Write("Please input an integer number");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input an OS");
            o = Console.ReadLine();
            Console.Write("Please input another number");
            s = Console.ReadLine();
            d = Int32.Parse(s);
            switch (o)
            {
                case "+": t = n + d; Console.WriteLine($"{n}{o }{d }={t}"); break;
                case "-": t = n - d; Console.WriteLine($"{n}{o }{d }={t}"); break;
                case "*": t = n * d; Console.WriteLine($"{n}{o }{d }={t}"); break;
                case "/":
                    if (d == 0)
                    {
                        Console.Write("zero is not allowed to be divided");
                    }
                    else
                    {
                        t = n / d;
                        Console.WriteLine($"{n}{o}{d}={t}");
                    }
                    break;
            }

        }
    }
}
