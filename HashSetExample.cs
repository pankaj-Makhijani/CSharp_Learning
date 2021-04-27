using System;
using System.Collections.Generic;

public class HashSetExample
{
    public static void Main(string[] args)
    {
        // It is similar to list but it does not contains duplicate values
        // Use HashSet when youu want to store unique values
        // Create a set of strings  
        var names = new HashSet<string>();

        // Create a set of strings  
        // var names = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };
        names.Add("Sonoo");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");
        names.Add("Ankit");//will not be added  

        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}