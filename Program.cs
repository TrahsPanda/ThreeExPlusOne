using System;

namespace ThreeExPlusOne
{
    class Program
    {
        public static uint x;
        public static void Input()
        {
            Console.WriteLine("Please enter an input:\n");
            x = UInt32.Parse(Console.ReadLine());
            while (true)
            {
                if (x < 0)
                {
                    Console.WriteLine("Sorry, negatives are not supported.");
                    continue;
                }
                if (x > 0)
                    break;
                else
                    Console.WriteLine("Please try again.");
            }
        }

        public static void Main(String[] args)
        {
            Input();
            Console.Clear();
            Console.WriteLine("Input: {0}", x);
            uint y = 3 * x + 1;
            Console.WriteLine(y);
            while (y > 1)
            {
                if (y % 2 == 0) // If Even, divide by 2
                    y /= 2;
                else if (y % 2 != 0) // If Odd, add 1
                    y++;
                Console.WriteLine(y);
            }
            
        }
    }
}