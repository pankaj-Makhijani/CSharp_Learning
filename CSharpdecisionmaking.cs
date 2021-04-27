using System;

    class CSharpdecisionmaking
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Conditional Statement\n\n");
            
            Console.WriteLine("C# if Statement\n");
            string name = "hello";
            if (name == "hello")
            {
                Console.WriteLine("Hello World");
            }
            
            Console.WriteLine("C# if-else Statement\n");
            string name1 = "Hello";
            if (name1 == "Hello")
            {
                Console.WriteLine("Hello World");
            }
            else
            {
                Console.WriteLine("hy world");
            }

            Console.WriteLine("C# if else-if else Statement\n");
            int i = 20;

            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");

            Console.WriteLine("C# Nested If Statement\n");

            int j = 10;

            if (j == 10)
            {

                // Nested - if statement
                // Will only be executed if statement
                // above it is true
                if (j < 12)
                    Console.WriteLine("j is smaller than 12 too");
                else
                    Console.WriteLine("j is greater than 15");
            }

            Console.WriteLine("C# Switch Statement\n");

            int number = 30;
            switch (number)
            {
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    break;
                case 30:
                    Console.WriteLine("case 30");
                    break;
                default:
                    Console.WriteLine("None matches");
                    break;
            }

        }
    }