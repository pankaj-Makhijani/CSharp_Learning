using System;

class Constructor
{

    int num;
    string name;

    //default constructor
    Constructor()
    {
        Console.WriteLine("Constructor Called");
    }

    //parameterized constructor
    Constructor(int num,string name)
    {
        this.num = num;
        this.name = name;
    }

    // It is invoked before the first instance constructor is run.
    static Constructor()
    {
        // The following statement produces the first line of output, and the line occurs only once.
        Console.WriteLine("Static Constructor");
    }
    public static void Main()
    {
        Constructor Constructor1 = new Constructor();
        Constructor Constructor2 = new Constructor(1,"abc");
        Console.WriteLine(Constructor1.name);
        Console.WriteLine(Constructor1.num);
        Console.WriteLine(Constructor2.name);
        Console.WriteLine(Constructor2.num);
    }
}
