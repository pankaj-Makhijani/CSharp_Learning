using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new List<string>();

        // Create a list of strings using collection initializer  
        // var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };

        names.Add("Sonoo Jaiswal");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}