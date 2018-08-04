using System;

namespace You_Win_
{
    class Program
    {
        private static string classify;
        private static string somevalue;

        static void Main(string[] args)
        {
            Console.WriteLine("pick a number between 1-10");
            int x =
            int.Parse(Console.ReadLine());

            Console.WriteLine(x);
                if(x == 8)
            {
                Console.WriteLine("You Win!");
            }
                else if(x <= 8)
            {
                Console.WriteLine("You Lose");
            }
                else if (x >= 8)
            {
                Console.WriteLine("You Lose");
            }
            //now to input ternary oerator


            var BOB = (x == 8) ? "You Win" : "You Lose";



            Console.ReadLine();
        }
    }
}
