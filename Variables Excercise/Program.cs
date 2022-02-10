using System;

namespace Variables_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstTime = "This is my first string" ;
            int myAge = 21;
            char favLetter = 'M';
            bool imTired = false;
            double favDecimal = 4.20;
            decimal wishfullMoney = 1000000.99m;

            Console.WriteLine($"I just started learning c# {firstTime},it only took me {myAge} years to try.");
            Console.WriteLine($"I was going to put true for the next value but tab was {imTired}");
            Console.WriteLine(favDecimal);
            Console.WriteLine("no further explnation needed for previous line");
            Console.WriteLine(wishfullMoney);
            Console.WriteLine($"i think im making this more complcated then it needs to be plus my name starts with an {favLetter} ");

        }
    }
}
