using System;
using System.Collections.Generic;

public class SortedSetExample
{
    public static void Main(string[] args)
    {
        // Create a set of strings  
        var names = new SortedSet<string>();

        // Create a set of strings  
        // var names = new SortedSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };
        names.Add("Sonoo");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");
        names.Add("Ankit");//will not be added  

        // Iterate SortedSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}