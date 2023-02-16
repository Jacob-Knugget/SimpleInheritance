using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}\n");
        }

    }

    // derived class of Animal 
    class Elephant : Animal
    {
        public double _height;
        public int _age;
        public double _tuskLength;

        public Elephant()
            :base()
        {
            _height = 0;
            _age = 0;
            _tuskLength = 0;
        }

        public Elephant(string name, double height, int age, double tuskLength)
            :base(name)
        {
            _height = height;
            _age = age;
            _tuskLength = tuskLength;
        }

        public void display()
        {
            Console.WriteLine("Elephant Information: ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Tusk Length: {_tuskLength}\n");
        }
    }
    class Penguin : Animal
    {
        public double _height;
        public int _age;
        public double _wingSpan;

        public Penguin()
            : base()
        {
            _height = 0;
            _age = 0;
            _wingSpan = 0;
        }

        public Penguin(string name, double height, int age, double wingSpan)
            : base(name)
        {
            _height = height;
            _age = age;
            _wingSpan = wingSpan;
        }

        public void display()
        {
            Console.WriteLine("Penguin Information: ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Wingspan: {_wingSpan}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Elephant firstEl = new Elephant();
            firstEl.name = "Goerge";
            firstEl._height = 9.74;
            firstEl._age = 13;
            firstEl._tuskLength = 1.6;

            //derived class object using parameterized constructor
            Elephant secondEl = new Elephant("Jeff", 12.7, 24, 3.9);

            Penguin firstP = new Penguin();
            firstP.name = "Richard";
            firstP._height = 3.2;
            firstP._age = 2;
            firstP._wingSpan = 4;

            Penguin secondP = new Penguin("Hippy", 2.3, 6, 1);

            firstEl.display();
            firstP.display();
            secondEl.display();
            secondP.display();
        }
    }
}