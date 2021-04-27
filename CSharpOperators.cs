using System;
    class CSharpOperators
    {
        static void Main(string[] args)
        {

            /* Operators in C#
            Arithmetic Operators
            Relational Operators
            Logical Operators
            Bitwise Operators
            Assignment Operators
            Conditional Operator */
            Console.WriteLine("C# Operators\n\n\n");
            Console.WriteLine("Arithmetic Operators\n");

            int result;
            int x = 10, y = 5;

            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);

            int a = 10, res;

            // post-increment example:
            // res is assigned 10 only, 
            // a is not updated yet
            res = a++;

            //a becomes 11 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // post-decrement example:
            // res is assigned 11 only, a is not updated yet
            res = a--;

            //a becomes 10 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-increment example:
            // res is assigned 11 now since a
            // is updated here itself
            res = ++a;

            // a and res have same values = 11
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-decrement example:
            // res is assigned 10 only since
            // a is updated here itself
            res = --a;

            // a and res have same values = 10
            Console.WriteLine("a is {0} and res is {1}", a, res);

            Console.WriteLine("Relational Operators\n");
            bool result1;
            int m = 5, n = 10;

            // Equal to Operator
            result1 = (m == n);
            Console.WriteLine("Equal to Operator: " + result1);

            // Greater than Operator
            result1 = (x > y);
            Console.WriteLine("Greater than Operator: " + result1);

            // Less than Operator
            result1 = (m < n);
            Console.WriteLine("Less than Operator: " + result1);

            // Greater than Equal to Operator
            result1 = (m >= n);
            Console.WriteLine("Greater than or Equal to: " + result1);

            // Less than Equal to Operator
            result1 = (m <= n);
            Console.WriteLine("Lesser than or Equal to: " + result1);

            // Not Equal To Operator
            result1 = (m != n);
            Console.WriteLine("Not Equal to Operator: " + result1);


            Console.WriteLine("Logical Operators\n");
            bool aa = true, bb = false, result2;

            // AND operator
            result2 = aa && bb;
            Console.WriteLine("AND Operator: " + result2);

            // OR operator
            result2 = aa || bb;
            Console.WriteLine("OR Operator: " + result2);

            // NOT operator
            result2 = !aa;
            Console.WriteLine("NOT Operator: " + result2);


            Console.WriteLine("Bitwise Operators\n");
            int xx = 5, yy = 10, result3;

            // Bitwise AND Operator
            result3 = xx & yy;
            Console.WriteLine("Bitwise AND: " + result3);

            // Bitwise OR Operator
            result3 = xx | yy;
            Console.WriteLine("Bitwise OR: " + result3);

            // Bitwise XOR Operator
            result3 = xx ^ yy;
            Console.WriteLine("Bitwise XOR: " + result3);

            // Bitwise AND Operator
            result3 = ~xx;
            Console.WriteLine("Bitwise Complement: " + result3);

            // Bitwise LEFT SHIFT Operator
            result3 = xx << 2;
            Console.WriteLine("Bitwise Left Shift: " + result3);

            // Bitwise RIGHT SHIFT Operator
            result3 = xx >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result3);


            Console.WriteLine("Assignment Operator");
            int p = 15;

            // it means p = p + 10
            p += 10;
            Console.WriteLine("Add Assignment Operator: " + p);

            // initalize variable p again
            p = 20;

            // it means p = p - 5
            p -= 5;
            Console.WriteLine("Subtract Assignment Operator: " + p);

            // initalize variable p again
            p = 15;

            // it means p = p * 5
            p *= 5;
            Console.WriteLine("Multiply Assignment Operator: " + p);

            // initalize variable p again
            p = 25;

            // it means p = p / 5
            p /= 5;
            Console.WriteLine("Division Assignment Operator: " + p);

            // initalize variable p again
            p = 25;

            // it means p = p % 5
            p %= 5;
            Console.WriteLine("Modulo Assignment Operator: " + p);

            // initalize variable p again
            p = 8;

            // it means p = p << 2
            p <<= 2;
            Console.WriteLine("Left Shift Assignment Operator: " + p);

            // initalize variable p again
            p = 8;

            // it means p = p >> 2
            p >>= 2;
            Console.WriteLine("Right Shift Assignment Operator: " + p);

            // initalize variable p again
            p = 12;

            // it means p = p >> 4
            p &= 4;
            Console.WriteLine("Bitwise AND Assignment Operator: " + p);

            // initalize variable p again
            p = 12;

            // it means p = p >> 4
            p ^= 4;
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + p);

            // initalize variable p again
            p = 12;

            // it means p = p >> 4
            p |= 4;
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + p);


            Console.WriteLine("Conditional Operators\n\n");
            int r = 5, q = 10, result4;

            // To find which value is greater
            // Using Conditional Operator
            result4 = r > q ? r : q;

            // To display the result 
            Console.WriteLine("Result: " + result4);
        }
    }
