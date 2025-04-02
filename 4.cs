class Program
{

    public struct Person
    {
        public string Name;
        public string Number;

        //constructor
        public Person(string name, string number)
        {
            Name = name;
            Number = number;
        }

    }


    public static List<Person> people = new List<Person>();
    public static int peopleCounter = 0;

    static void showMenu()
    {
        Console.Clear();
        Console.WriteLine("------Menu------");
        Console.WriteLine(" 1-add");
        Console.WriteLine(" 2-edit");
        Console.WriteLine(" 3-search");
        Console.WriteLine(" 4-delete");
        Console.WriteLine(" 5-list");
        Console.WriteLine(" 6-exit");
        Console.Write("Choose your option: ");
    }

    public static void AddPerson()
    {
        Console.Clear();
        Console.WriteLine("Name is: ");
        string name = Console.ReadLine();
        Console.WriteLine("Number is: ");
        string number = Console.ReadLine();
        people.Add(new Person(name, number));
    }

    public static void searchPerson()
    {
        Console.Clear();
        Console.WriteLine("Name is: ");
        string name = Console.ReadLine();
        bool found = false;
        foreach (Person person in people)
        {
            if (person.Name == name)
            {
                Console.WriteLine($"{people.IndexOf(person) + 1} = {person.Name} : {person.Number}");
                found = true;

            }
        }
        if (!found)

        {
            Console.WriteLine("Not Found!");
        }
        Console.ReadKey();
    }


    public static void editPerson()
    {
        Console.Clear();
        Console.WriteLine("Name is: ");
        string name = Console.ReadLine();
        bool found = false;
        int editednodenumber = 0;
        foreach (Person person
            in people)
        {
            if (person.Name == name)
            {
                editednodenumber = people.IndexOf(person);
                found = true;

            }
        }
        if (!found)

        {
            Console.WriteLine("Not Found!");
        }
        else
        {
            Console.WriteLine("new name is: ");
            string newname = Console.ReadLine();
            Console.WriteLine("new number is: ");
            string newnumber = Console.ReadLine();
            people[editednodenumber] = new Person(newname, newnumber);
            Console.WriteLine("edited successfully!");
        }
        Console.ReadKey();
    }

    public static void deletePerson()
    {
        Console.Clear();
        Console.WriteLine("Name is: ");
        string name = Console.ReadLine();
        bool found = false;
        int deletednodenumber = 0;
        foreach (Person person
            in people)
        {
            if (person.Name == name)
            {
                deletednodenumber = people.IndexOf(person);
                found = true;

            }
        }
        if (!found)

        {
            Console.WriteLine("Not Found!");
        }
        else
        {
            Console.WriteLine("Sure? (y/n)");
            string decision = Console.ReadLine();
            if (decision == "y")
            {
            people.Remove(people[deletednodenumber]);
            Console.WriteLine("deleted successfully!");
            }
            else
            {
                Console.WriteLine("You ignored!");
            }
        }
        Console.ReadKey();
    }

    public static void ShowPersonList()
    {
        foreach (Person person in people)
        {
            {
                Console.WriteLine($"{people.IndexOf(person) + 1} = {person.Name} : {person.Number}");
            }
        }
        Console.ReadKey();
    }
    static void Main()
    {
        int selectedOption = 0;
        do
        {
            showMenu();
            string input = Console.ReadLine();
            selectedOption = int.Parse(input);
            switch (selectedOption)
            {
                case 1:
                    AddPerson();
                    break;
                case 2:
                    editPerson();
                    break;
                case 3:
                    searchPerson();
                    break;
                case 4:
                    deletePerson();
                    break;
                case 5:
                    ShowPersonList();
                    break;
            }

        } while (selectedOption != 6);
    }
}