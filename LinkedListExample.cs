using System;
using System.Collections.Generic;

public class LinkedListExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("Sonoo Jaiswal");
        names.AddLast("Ankit");
        names.AddLast("Peter");
        names.AddLast("Irfan");
        // names.AddFirst("John");//added to first index  

        //insert new element before "Peter"  
        LinkedListNode<String> node = names.Find("Peter");
        names.AddBefore(node, "John"); //Inserting John before peter node
        names.AddAfter(node, "Lucy"); //inserting Lucy after peter node

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}