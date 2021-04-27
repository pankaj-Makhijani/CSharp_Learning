using System;

public class MethodParameters
{
    // addstr contain three parameters
    public static void Addstr(string s1, string s2, string s3)
    {
        string result = s1 + s2 + s3;
        Console.WriteLine("Final string is: " + result);
    }

    //use of reference parameters
    static void CompareValue(ref string val1)
    {
        // Compare the value
        if (val1 == "Dog")
        {
            Console.WriteLine("Matched!");
        }

        // Assigning new value
        val1 = "Cat";
    }

    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void AddNum(out int num)
    {
        num = 40;
        num += num;
    }

    // Main Method
    static public void Main()
    {
        // calling the static method with named 
        // parameters without any order
        Addstr(s1: "Geeks", s2: "for", s3: "Geeks");

        // Assigning value
        string val = "Dog";

        // Pass as a reference parameter
        CompareValue(ref val);

        // Display the given value
        Console.WriteLine(val);

        // Creating variable
        // without assigning value
        int num;

        // Pass variable num to the method
        // using out keyword
        AddNum(out num);

        // Display the value of num
        Console.WriteLine("The sum of"
          + " the value is: {0}", num);
    }
}
