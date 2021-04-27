using System;
using System.Collections.Generic;

public class QueueExample
{
    public static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Sonoo");
        names.Enqueue("Peter");
        names.Enqueue("James");
        names.Enqueue("Ratan");
        names.Enqueue("Irfan");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Dequeue: " + names.Dequeue());
        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    }
}