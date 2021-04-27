using System;
using System.Collections.Generic;

public class SortedDictionaryExample
{
    public static void Main(string[] args)
    {
        //SortedList can be modified and can be used as SortedList Dictionary which stores key value pairs
        //Sorted list dictionary consumes less memory but it is slow in storing and retrieval of data while
        //Sorted Dictionary consumes more memory than sorted List Dictionary but has fast data storing and retrieving speed.
        //SortedList<string, string> names = new SortedList<string, string>();
        
        SortedDictionary<string, string> names = new SortedDictionary<string, string>();
        names.Add("1", "Sonoo");
        names.Add("4", "Peter");
        names.Add("5", "James");
        names.Add("3", "Ratan");
        names.Add("2", "Irfan");
        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}