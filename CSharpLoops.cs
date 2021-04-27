using System;

    class CSharpLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop in C#\n\n");
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("Hello World");

                // Increment the value of x for
                // next iteration
                x++;
            }

            Console.WriteLine("For loop in C#\n\n");
            for (int i = 1; i <= 4; i++)
                Console.WriteLine("Hello World");

            Console.WriteLine("Do-While loop in C#\n\n");
            int j = 21;
            do
            {
                // The line will be printed even
                // if the condition is false
                Console.WriteLine("Hello World");
                j++;
            }
            while (j < 20);

            Console.WriteLine("Nested For loop in C#\n\n");
            // loop within loop
            for (int p = 2; p < 3; p++)
                for (int q = 1; q < p; q++)
                    Console.WriteLine("Hello World");

            Console.WriteLine("Continue in C#\n\n");
            for (int m = 1; m < 3; m++)
            {
                if (m == 2)
                    continue;

                Console.WriteLine("Hello World");
            }

            Console.WriteLine("Break in C#\n\n");
            for (int n = 1; n < 3; n++)
            {
                if (n == 2)
                    break;

                Console.WriteLine("Hello World");
            }
        }
    }