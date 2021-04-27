using System;

    class csharpfundamentals
    {
        static void Main(string[] args)
        {
            // declaring character
            char a = 'G';

            // Integer data type is generally
            // used for numeric values
            int i = 89;

            Console.WriteLine("The below code is the exampl of Value data types in C#\n\n");

            //Every datatype in C# has MinValue and MaxValue method associated with it which returns maximum or minimum value it can store
            Console.WriteLine("Max value of int " + int.MaxValue + "Min value of int" + int.MinValue);

            short s = 56;
            
            // this will give error as number
            // is larger than short range
            // short s1 = 87878787878;

            // long uses Integer values which 
            // may signed or unsigned
            long l = 4564;

            // UInt data type is generally
            // used for unsigned integer values
            uint ui = 95;

            ushort us = 76;
            // this will give error as number is
            // larger than short range

            // ulong data type is generally
            // used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value
            // is double in C#
            double d = 8.358674532;

            // for float use 'f' as suffix
            float f = 3.7330645f;

            // for float use 'm' as suffix
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);


            Console.WriteLine("Signed Byte in C#\n");
            sbyte x = 126;

            // sbyte is 8 bit 
            // singned value
            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);

            // It overflows here because
            // byte can hold values 
            // from -128 to 127
            x++;
            Console.WriteLine(x);

            // Looping back within 
            // the range
            x++;
            Console.WriteLine(x);

            Console.WriteLine("Unsigned Byte In C#");

            byte y = 0;

            // byte is 8 bit 
            // unsigned value
            Console.WriteLine(y);

            y++;
            Console.WriteLine(y);

            y = 254;

            // It overflows here because
            // byte can hold values from
            // 0 to 255
            y++;
            Console.WriteLine(y);

            // Looping back within the range
            y++;
            Console.WriteLine(y);

            Console.WriteLine("Boolean data type in C#");
            // boolean data type
            bool b = true;
            if (b == true)
                Console.WriteLine("Hi Geek");

            /*The Reference Data Types will contain a memory address of variable value
             because the reference types won’t store the variable value directly in memory.
             The built-in reference types are string, object.*/
            Console.WriteLine("Reference Data Type Example\n\n\n");
            // declaring string
            string w = "Geeks";

            //append in w
            w += "for";
            w = w + "Geeks";
            Console.WriteLine(w);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            Console.WriteLine(obj.GetType());


            /*The Pointer Data Types will contain a memory address of the variable value.
            To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
            ampersand (&): It is Known as Address Operator. It is used to determine the address of a variable.
            asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.*/
            Console.WriteLine("Pointer Data Type Example\n\n\n");

            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address 
                // location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);


                /*We can use @ so that compiler will not check the succedding statement we can also use @ before 
                 reserved keywords in order to use them like a normal variables*/
                Console.WriteLine("Use of @ symbol\n\n\n");

                //Here compiler will check the below line and replace \t with appropirate spaces 
                String m = "Hello \t World";

                //Here compiler wont check the statement and therefore \t will be printed on the output screen
                String m2 = @"Hello \t World";

                Console.WriteLine(m);
                Console.Write(m2);

            }
        }
    }
