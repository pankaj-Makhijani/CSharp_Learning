using System;

    // Class Declaration
    public class Dog
    {

        // Instance Variables
        String name;
        String breed;
        int age;
        String color;

        // Constructor Declaration of Class
        public Dog(String name, String breed,
                      int age, String color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        // Property 1
        public String getName()
        {
            return name;
        }

        // Property 2
        public String getBreed()
        {
            return breed;
        }

        // Property 3
        public int getAge()
        {
            return age;
        }

        // Property 4
        public String getColor()
        {
            return color;
        }

        // Method 1
        public String toString()
        {
            return ("Hi my name is " + this.getName()
                    + ".\nMy breed, age and color are " + this.getBreed()
                    + ", " + this.getAge() + ", " + this.getColor());
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating object
            Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
            Console.WriteLine(tuffy.toString());
        }
    }
