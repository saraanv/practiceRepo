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
        public string Name;
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    class Dog:Animal
    {
        public void HopHop()
        {
            Console.WriteLine($"{Name} is Hop Hopping!");
        }
    }

    class Duck : Animal
    {
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
        public override double GetArea() => radius*radius*Math.PI;
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Length;
        public override double GetArea() => Length * Width;
    }

    static void Main()
    {
        //Person person = new Person();
        //person.Name = "Sara";
        //person.Age = 21;
        //person.introduce();
        //Dog dog = new Dog();
        //dog.Name = "Jesy";
        //dog.Eat();
        //dog.HopHop();
        //Duck duck = new Duck();
        //duck.Name = "Jane";
        //duck.Eat();
        //duck.Flying();
        Circle circle = new Circle();
        circle.radius = 10;
        circle.GetArea();
        Console.WriteLine($"your circle area is {circle.GetArea()}");
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Length = 10;
        rectangle.GetArea();
        Console.WriteLine("__________________________");
        Console.WriteLine($"your rectangle area is {rectangle.GetArea()}");
    }
}