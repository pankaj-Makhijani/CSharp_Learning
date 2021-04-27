// C# program to illustrate the use of
//'virtual' and 'override' modifiers
using System;

class baseClass
{

    // show() is 'virtual' here
    public virtual void show()
    {
        Console.WriteLine("Base class");
    }

    public void show1()
    {
        Console.WriteLine("Base class");
    }
}


// class 'baseClass' inherit
// class 'derived'
class derived : baseClass
{

    //virtual method overrided using override keyword
    public override void show()
    {
        Console.WriteLine("Derived class using override keyword");
    }

    // overriding by using new keyword
    new public void show1()
    {
        Console.WriteLine("Derived class using new keyword");
    }
}

class MethodOverride
{

    // Main Method
    public static void Main()
    {

        baseClass obj;

        // 'obj' is the object
        // of class 'baseClass'
        obj = new baseClass();

        // it invokes 'show()'
        // of class 'baseClass'
        obj.show();
        obj.show1();


        // the same object 'obj' is now
        // the object of class 'derived'
        obj = new derived();

        // it invokes 'show()' of class 'derived'
        // 'show()' of class 'derived' is overridden
        // for 'override' modifier
        obj.show();
        obj.show1();

    }
}