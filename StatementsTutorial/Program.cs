using System;

namespace StatementsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //// more if...else practice
            //Console.WriteLine("Enter a number:");
            //var aNbr = Console.ReadLine();
            //var Nbr = Convert.ToInt32(aNbr);
            //    if(Nbr % 2 ==0)
            //{ Console.WriteLine($"{aNbr} is even!"); }
            //    else
            //{ Console.WriteLine($"{aNbr} is odd :("); }

            // for() example
            var ints = new[] { 77,32,94,46,28 };
            for (var idx = 0; idx < 5; idx++)
            {
                Console.WriteLine($" idx: {idx} | ints[idx]: {ints[idx]}");
                //idx = index #, ints[idx] = value in index#
            }




            var ans = 0;
            for (var nbr = 0; nbr <= 50; nbr++)
            {
                if (nbr % 5 == 0 || nbr % 7 == 0)
                    ans += nbr;
            }
            Console.WriteLine($"This is the sum of numbers 1 to 50 divisable by 5 or 7 : {ans}");
        }
    }
}
