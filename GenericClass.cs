using System;

    //Geeric class example
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    //Class containing generic method
    class GenericClass
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Generic class object
            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');

            //normal class containing Generic method
            GenericClass genC = new GenericClass();
            genC.Show("This is generic method");
            genC.Show(101);
            genC.Show('I');
        }
    }