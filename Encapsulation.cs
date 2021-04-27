using System;

public class Encap
{
//    private int num;
  //  private string name;
    
    //getters and setters are used for encapsulation in C#
    public int num
    {
        get
        {
            return num;
        }
        set
        {
            num = value;
        }
    }

    public string name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class Encapsulation
{
    static void Main()
    {
        Encap e = new Encap();
        e.num = 20;
        e.name = "pankaj";
        Console.WriteLine("Name :" + e.name);
        Console.WriteLine("Num :" + e.num);
    }
}