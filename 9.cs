using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    class Person
    {
        public string Name;
        public int Age;
        public string Fathername;
        bool IsReadyForMarriage;

        public void introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and my age is {Age}");
        }
    }

    class Animal
    {
        private string Secretname;
        public string Name
        {
            get { return $"my name is {Secretname}."; }
            set { Secretname = value; }
        }
        public int Age;
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    class Dog : Animal
    {
        public void HopHop()
        {
            Age++;
            Console.WriteLine($"{Name} is Hop Hopping!");
        }
    }

    class Duck : Animal
    {
        public static string color = "Green";
        public static void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public void Flying()
        {
            Console.WriteLine($"{Name} is flying!");
        }
    }

    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double radius;
        public override sealed double GetArea() => radius * radius * Math.PI;
    }

    class Minicircle : Circle
    {
        //public override double GetArea() => 10;  // we can not override because it's Sealed on Parent
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Length;
        public override double GetArea() => Length * Width;
    }

    public class Car
    {
        public string Model { get; }
        public string Color { get; }
        public int Year { get; }
        public string Enginetype { get; }
        public bool Iselectric { get; }
        private bool IsOn { get; set; }
        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public string IsTurnedOn()
        {
            return IsOn ? "This car is on" : "This car is off";
        }

        public Car (string model, string color, int year, string enginetype, bool iselectric)
        {
            Model = model;
            Color = color;
            Year = year;
            Enginetype = enginetype;
            Iselectric = iselectric;
            TurnOn();
        }
    }

    public static void ModifyValue(ref int number)
    {
        number += 10;
    }
    public static void GetValue(out int number, out string text)
    {
        number = 42;
        text = "Hi C#";
    }
    public static void PrintValue(in int number)
    {
        Console.WriteLine(number);
    }

    static void Main()
    {
        int value = 5;
        ModifyValue(ref value);
        Console.WriteLine(value);

        int num;
        string str;
        GetValue(out num, out str);
        Console.WriteLine($"{num} , {str}");

        value = 20;
        PrintValue(in value); 
        //var car = new Car("Tesla", "Red", 2025, "Electric", true);
        //Console.WriteLine(car.IsTurnedOn());
        //car.TurnOff();
        //Console.WriteLine(car.IsTurnedOn());
        //Minicircle minicircle = new Minicircle();
        //minicircle.radius = 10;
        //minicircle.GetArea();
        //Console.WriteLine($"your circle area is {minicircle.GetArea()}");
        //Person person = new Person();
        //person.Name = "Sara";
        //person.Age = 21;
        //person.introduce();
        //Dog dog = new Dog();
        //dog.Name = "Jesy";
        //dog.Eat();
        //dog.HopHop();
        //dog.Age++;
        //Duck duck = new Duck();
        //duck.Name = "Jane";
        //duck.Eat();
        //Console.WriteLine(Duck.color);
        //duck.Flying();
        //Duck.Quack();
        //Circle circle = new Circle();
        //circle.radius = 10;
        //circle.GetArea();
        //Console.WriteLine($"your circle area is {circle.GetArea()}");
        //Rectangle rectangle = new Rectangle();
        //rectangle.Width = 10;
        //rectangle.Length = 10;
        //rectangle.GetArea();
        //Console.WriteLine("__________________________");
        //Console.WriteLine($"your rectangle area is {rectangle.GetArea()}");

    }
}