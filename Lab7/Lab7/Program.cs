using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1:
            int counter = 1; // control variable (loop counter)

            while (counter <= 9) // loop-terminating condition
            {
                Console.Write($"{counter}   ");
                counter += 2; // modify loop control variable
            }

            // Question 2:
            for (int i = 30; i <= 45; ++i)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("It is even");
                }
                else if ((i % 2) != 0)
                {
                    Console.WriteLine("It is odd");
                }
            }

            // Question 3:
            int t;
            Console.WriteLine("Enter time");
            t = Convert.ToInt32(Console.ReadLine());
            while (t <= 24)
            {
                if (t >= 0 && t <= 11)
                {
                    Console.WriteLine("Good Morning");
                    t += 1;
                }
                else if (t >= 12 && t <= 16)
                {
                    Console.WriteLine("Good Afternoon");
                    t += 1;
                }
                else if (t > 16)
                {
                    Console.WriteLine("Good Evening");
                    t += 1;
                }
            }

            // Question 4:
            int f = 10;
            while (f < 21)
            {
                Console.WriteLine(f);
                f++; // forgot this line which increments the control variable
            }

            // Question 5:
            for (int m = 0; m < 101; m++)
            {
                if ((m % 2) == 0)
                {
                    Console.WriteLine(m);
                    Console.WriteLine("********");
                }
                else if ((m % 2) != 0)
                {
                    Console.WriteLine(m);
                    Console.WriteLine("********");
                }
            }

            // Question 6: a.
            int y;
            int z;

            for (y = 0; y < 10; y++)
            {
                for (z = 0; z <= y; z++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            // Console.WriteLine();
        }
    }
}
