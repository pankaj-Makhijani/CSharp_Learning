//In order to use the write meethod of console class from system namespace, we are importing system namespace at the start of the file. Similar to header files in C programming.
using System;

    //Creating class program, c# is an OOP language.
    class Program
    {
        //Making main function static means CLR will automatically call this method without creating it's object
        //Void means we do not want to return anything from this method
        //string args is used so that we can pass some default argument while starting the program execution
        static void Main(string[] args)
        {
            //Writeline points to next line after writing while write dont moves to the next line
            Console.Write("Hello World!");
            Console.WriteLine("Hello World!");
            //Readline reads the entire key while read & readkey reads only the next character. The only difference in read and readkey is that readkey returns the unicode value of the pressedkey while read returns the original character. Readkey is usually used to hold the terminal screen of console apps in c#.
            Console.ReadLine();
            Console.Read();
            Console.ReadKey();
        }
    }